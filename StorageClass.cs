using EnCryptDecrypt;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AzureStorageHandler
{
    public class RegistoryHandler
    {
        internal static string ConnectionStr = "";
        public RegistoryHandler(string constr)
        {
            ConnectionStr = constr;
        }
        public DataTable GetPracticeList()
        {
            DataTable resultTable = new DataTable();
            string querySQL = "select id,practice from practices";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
            {
                sqlCon.Open();
                using (SqlCommand sqCommand = new SqlCommand(querySQL, sqlCon))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sqCommand);
                    adapter.Fill(resultTable);
                }
            }
            return resultTable;
        }
        public bool CheckForClientExistance(string clientRegistryGUID)
        {
            string querySQl = "SELECT COUNT(clientRegistryID) FROM clientRegistry where clientRegistryGUID=@guid";
            int countOfExistance = 0;
            using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
            {
                sqlCon.Open();

                using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                {
                    sqCommand.CommandType = CommandType.Text;
                    sqCommand.Parameters.Add("@GUID", SqlDbType.VarChar).Value = clientRegistryGUID;
                    string result = sqCommand.ExecuteScalar().ToString();
                    int.TryParse(result, out countOfExistance);
                }
            }
            if (countOfExistance > 0)
                return true;
            else
                return false;
        }
        public bool CheckForPatientExistance(string patientRegistryGUID)
        {
            string querySQl = "SELECT COUNT(patientRegistryID) FROM patientRegistry where patientRegistryGUID=@guid";
            int countOfExistance = 0;
            using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
            {
                sqlCon.Open();

                using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                {
                    sqCommand.CommandType = CommandType.Text;
                    sqCommand.Parameters.Add("@GUID", SqlDbType.VarChar).Value = patientRegistryGUID;
                    string result = sqCommand.ExecuteScalar().ToString();
                    int.TryParse(result, out countOfExistance);
                }
            }
            if (countOfExistance > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientRegistryGUID">NOT USED NOW</param>
        /// <param name="practicePatientID">LocalPatient ID</param>
        /// <param name="practiceID">instanceID/PracticeID</param>
        /// <param name="practicePatientGUID">NOT USED NOW</param>
        /// <param name="clientCreatedAt">datetime</param>
        /// <returns></returns>
        public string InsertIntoPatientReg(string patientRegistryGUID,
                                        string practicePatientID,
                                        string practiceID,
                                        string practicePatientGUID,
                                        DateTime clientCreatedAt)
        {
            try
            {
                string querySQl = "Select registryPatientID from patientsToPractices where practicePatientID=" + practicePatientID;
                bool canInsert = true;
                string patientID = string.Empty;
                using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
                {
                    using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                    {
                        if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                        object queryResult = sqCommand.ExecuteScalar();
                        if (queryResult != null && (int)queryResult != 0)
                        {
                            patientID = "Patient already Exist, Global ID : " + ((int)queryResult).ToString();
                        }
                        else
                        {
                            canInsert = false;
                        }

                    }
                    if (!canInsert)
                    {
                        querySQl = "INSERT INTO patientRegistry(patientRegistryGUID,patientCreatedAt)VALUES" +
                                      "(@GUID,@CreatedAt);SELECT SCOPE_IDENTITY();";

                        DataSet resultSet = new DataSet();
                        using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                        {
                            sqCommand.CommandType = CommandType.Text;
                            sqCommand.Parameters.Add("@GUID", SqlDbType.VarChar).Value = patientRegistryGUID;
                            sqCommand.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = clientCreatedAt;
                            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqCommand);
                            sqlAdapter.Fill(resultSet);
                        }
                        if (resultSet.Tables[0].Rows.Count > 0)
                        {
                            patientID = resultSet.Tables[0].Rows[0][0].ToString();

                            querySQl = "INSERT INTO patientsToPractices(" +
                                       "registryPatientID,practicePatientID,practiceID,practicePatientGUID,createdAt)" +
                                       "VALUES" +
                                       "(@registryPatientID," +
                                       " @practicePatientID," +
                                       " @practiceID," +
                                       " @practicePatientGUID," +
                                       " @createdAt" +
                                       ");";
                            using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                            {
                                if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                                sqCommand.CommandType = CommandType.Text;
                                sqCommand.Parameters.Add("@registryPatientID", SqlDbType.VarChar).Value = patientID;
                                sqCommand.Parameters.Add("@practicePatientID", SqlDbType.VarChar).Value = practicePatientID;
                                sqCommand.Parameters.Add("@practiceID", SqlDbType.VarChar).Value = practiceID;
                                sqCommand.Parameters.Add("@practicePatientGUID", SqlDbType.VarChar).Value = practicePatientGUID;
                                sqCommand.Parameters.Add("@createdAt", SqlDbType.DateTime).Value = clientCreatedAt;
                                int mnResult = sqCommand.ExecuteNonQuery();
                                if (mnResult <= 0)
                                {
                                    patientID = "Error Occured while executing the query";
                                }
                            }
                            patientID = "Patient Created, Global ID : " + resultSet.Tables[0].Rows[0][0].ToString();

                        }
                    }

                }
                return patientID;
            }
            catch (Exception ex)
            {
                return "Error Occured while executing the query" + ex.ToString();

            }



        }
        public string InsertIntoClientReg(string clientRegistryGUID,
                                          string practiceClientID,
                                          string practiceID,
                                          string practiceClientGUID,
                                          DateTime clientCreatedAt)
        {
            try
            {

                string querySQl = "Select registryClientID from clientsToPractices where practiceClientID=" + practiceClientID;
                bool canInsert = true;
                string clientID = String.Empty;
                using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
                {
                    using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                    {
                        if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                        object queryResult = sqCommand.ExecuteScalar();
                        if (queryResult != null && (int)queryResult != 0)
                        {
                            clientID = "Client already Exist, Global ID : " + ((int)queryResult).ToString();
                        }
                        else
                        {
                            canInsert = false;
                        }

                    }
                    if (!canInsert)
                    {

                        querySQl = "INSERT INTO clientRegistry(clientRegistryGUID,clientCreatedAt)VALUES" +
                                       "(@GUID,@CreatedAt);SELECT SCOPE_IDENTITY();";
                        DataSet resultSet = new DataSet();
                        using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                        {
                            sqCommand.CommandType = CommandType.Text;
                            sqCommand.Parameters.Add("@GUID", SqlDbType.VarChar).Value = clientRegistryGUID;
                            sqCommand.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = clientCreatedAt;
                            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqCommand);
                            sqlAdapter.Fill(resultSet);
                        }
                        if (resultSet.Tables[0].Rows.Count > 0)
                        {
                            clientID = resultSet.Tables[0].Rows[0][0].ToString();
                            querySQl = "INSERT INTO clientsToPractices(" +
                                       "registryClientID,practiceClientID,practiceID,practiceClientGUID,createdAt)" +
                                       "VALUES" +
                                       "(@registryClientID," +
                                       " @practiceClientID," +
                                       " @practiceID," +
                                       " @practiceClientGUID," +
                                       " @createdAt" +
                                       ");";
                            using (SqlCommand sqCommand = new SqlCommand(querySQl, sqlCon))
                            {
                                if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                                sqCommand.CommandType = CommandType.Text;
                                sqCommand.Parameters.Add("@registryClientID", SqlDbType.VarChar).Value = clientID;
                                sqCommand.Parameters.Add("@practiceClientID", SqlDbType.VarChar).Value = practiceClientID;
                                sqCommand.Parameters.Add("@practiceID", SqlDbType.VarChar).Value = practiceID;
                                sqCommand.Parameters.Add("@practiceClientGUID", SqlDbType.VarChar).Value = practiceClientGUID;
                                sqCommand.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = clientCreatedAt;
                                int mnResult = sqCommand.ExecuteNonQuery();
                                if (mnResult <= 0)
                                {
                                    clientID = "Error Occured while executing the query";
                                }
                            }
                            clientID = "Client Created, Global ID : " + resultSet.Tables[0].Rows[0][0].ToString();

                        }
                    }
                }
                return clientID;
            }
            catch (Exception ex)
            {
                return "Error Occured while executing the query" + ex.ToString();

            }



        }

    }
    public class BlobStorage
    {
        public int blobid = 0;
        internal static string StorageConnectionString = "";
        public CloudStorageAccount storageAccount;
        public string FromOrganizationID;
        public BlobStorage(string constr, string FromOrganizationID)
        {
            StorageConnectionString = constr;
            ReInitiate();
            this.FromOrganizationID = FromOrganizationID;
        }
        public BlobStorage(string constr)
        {
            StorageConnectionString = constr;
            ReInitiate();
        }
        public bool CreateContainer(string ContainerName, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                ReInitiate();
                CloudBlobClient client = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = client.GetContainerReference(ContainerName);
                container.CreateIfNotExists();
                return true;
            }
            catch
            {

                return false;
            }

        }
        /// <summary>
        /// For re-initiate the connection to the storage account
        /// create another connection if we loss the current one
        /// </summary>
        private void ReInitiate()
        {

            if (storageAccount == null)
            {
                storageAccount = CloudStorageAccount.Parse(StorageConnectionString);
            }
        }
        /// <summary>
        /// Will return an Html string the contains the list of containers
        /// and a sub-list of files
        /// in case of any errors/failure it will return 
        /// error message(html) 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<string>> GetMyContainers()
        {
            ReInitiate();
            try
            {
                Dictionary<string, List<string>> ContainerView = new Dictionary<string, List<string>>();
                //StringBuilder htmlBuilder = new StringBuilder();
                var storageClient = storageAccount.CreateCloudBlobClient();
                //htmlBuilder.Append("<h3> Select The BlobFile </h3>");
                //htmlBuilder.Append("<ul>");
                foreach (var container in storageClient.ListContainers())
                {
                    if (!ContainerView.ContainsKey(container.Name))
                    {
                        ContainerView.Add(container.Name, new List<string>());
                    }
                    //htmlBuilder.Append("<li>" + container.Name);
                    var currentContainer = storageClient.GetContainerReference(container.Name);
                    // htmlBuilder.Append("<ul id='" + container.Name + "'>");
                    foreach (IListBlobItem item in container.ListBlobs(null, false))
                    {
                        if (item.GetType() == typeof(CloudBlobDirectory))
                        {
                            // we know this is a sub directory now
                            CloudBlobDirectory subFolder = (CloudBlobDirectory)item;
                            foreach (var folder in subFolder.ListBlobs())
                            {
                                if (folder.GetType() == typeof(CloudBlobDirectory))
                                    ContainerView[container.Name].AddRange(checkInSubFolders((CloudBlobDirectory)folder));
                            }
                            var listBlobs = subFolder.ListBlobs();
                        }
                        else
                        {
                            string Container = ((CloudBlockBlob)item).Name.TrimStart();
                            ContainerView[container.Name].Add(Container);//"<li onclick='selectTheFile(this);' id='liBlob" + blobid++ + "'> " + ((CloudBlockBlob)item).Name.Trim() + "</li>");
                        }
                    }
                    //foreach (var blobItem in currentContainer.ListBlobs().OfType<CloudBlockBlob>().Select(b => b.Name).ToList())
                    //{
                    //    string Container = "'" + container.Name.TrimStart() + "'";
                    //    htmlBuilder.Append("<li onclick='selectTheFile(this);' id='liBlob" + blobid++ + "'> " + blobItem + "</li>");
                    //}
                    //htmlBuilder.Append("</ul>");
                    // htmlBuilder.Append("</li>");
                }
                // htmlBuilder.Append("</ul>");
                return ContainerView;
            }
            catch (Exception exe)
            {
                string exception = exe.ToString();

                return new Dictionary<string, List<string>>();
            }
        }
        public List<string> checkInSubFolders(CloudBlobDirectory currentDirectory, List<string> li = null)
        {
            if (li == null) li = new List<string>();
            if (currentDirectory.GetType() == typeof(CloudBlobDirectory))
            {
                CloudBlobDirectory subFolder = (CloudBlobDirectory)currentDirectory;
                foreach (var folder in subFolder.ListBlobs())
                {
                    if (folder.GetType() == typeof(CloudBlobDirectory))
                    {
                        checkInSubFolders((CloudBlobDirectory)folder, li);
                    }
                    else
                    {
                        string Container = ((CloudBlockBlob)folder).Name.Trim();
                        li.Add(Container);
                    }
                }
            }
            else
            {
                string Container = currentDirectory.ToString().TrimStart();
                li.Add(Container);
            }
            return li;
        }
        /// <summary>
        /// It will accepts two inputs for file and the container, 
        /// will process the file and save the file to the container
        /// which is specified in the second parameter
        /// </summary>
        /// <param name="azureFile">This will be the file info of the uploaded file</param>
        /// <param name="blobContainerName">will be the name of the container</param>
        /// <returns> true for success and false for failure</returns>
        public string UploadToBlobStorage(string fileName, FileStream azureFile, string blobContainerName, int FromInstanceId, int ToInstanceId = 0)
        {
            ReInitiate();
            try
            {
                string newFilePath = azureFile.Name;
                string extension = Path.GetExtension(newFilePath);
                string fileNme = fileName.Replace("/", "_").Replace("\\", "_");
                CloudBlobClient client = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = client.GetContainerReference(blobContainerName);
                container.CreateIfNotExists();
                CloudBlockBlob blob = container.GetBlockBlobReference(fileName + extension);
                blob.UploadFromStream(azureFile);
                return "Successfully uploaded..!";
            }
            catch (Exception ex)
            {
                return "Error Occured..!" + ex.ToString();
            }

        }

        /// <summary>
        /// Will give you the specified file from the specified storage
        /// will return false if the file or storage is not found
        /// and also in case of any error.
        /// if the operation is success full it will store the file 
        /// in the ~/Downloads folder
        /// </summary>
        /// <param name="BlobContainer"> name of the blob container</param>
        /// <param name="outFileName">NAme of the file wanted to be fetched</param>
        /// <returns> true for success and false for failure</returns>
        public T GetFileBack<T>(string outPath, string BlobContainer, string outFileName, int FromInstanceId, int ToInstanceId = 0)
        {
            ReInitiate();
            try
            {
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference(BlobContainer);
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(outFileName);
                if (typeof(T) == typeof(bool))
                {
                    if (!Directory.Exists(outPath))
                    {
                        Directory.CreateDirectory(outPath);
                    }
                    string outFilePath = outPath + outFileName.Replace("/", "_").Replace("\\", "_");
                    using (var fileStream = System.IO.File.OpenWrite(outFilePath))
                    {
                        blockBlob.DownloadToStream(fileStream);
                    }
                    return (T)Convert.ChangeType(true, typeof(T)); ;
                }
                else if (typeof(T) == typeof(byte[]))
                {
                    blockBlob.FetchAttributes();
                    long fileByteLength = blockBlob.Properties.Length;
                    byte[] fileContent = new byte[fileByteLength];
                    blockBlob.DownloadToByteArray(fileContent, 0);
                    return (T)Convert.ChangeType(fileContent, typeof(T));
                }
                else
                {
                    return (T)Convert.ChangeType(null, typeof(T));
                }

            }
            catch
            {
                return (T)Convert.ChangeType(false, typeof(T));
            }

        }
        /// <summary>
        /// This function will rename a particular blob in the specified container
        /// Actually what is happening is create new blob, copy the old one to new one
        /// Delete the old reference
        /// </summary>
        /// <param name="container"> Name of the container</param>
        /// <param name="blobName">current Name/path pf the blob</param>
        /// <param name="newBlobName">new Name/path pf the blob</param>
        /// <returns>boolean value represents the operation status</returns>
        public bool RenameBlob(string blobContainerName, string blobName, string newBlobName)
        {
            try
            {
                CloudBlobClient client = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = client.GetContainerReference(blobContainerName);
                string extension = blobName.Substring(blobName.LastIndexOf(".") + 1);
                newBlobName += "." + extension;
                CloudBlob existBlob = container.GetBlobReference(blobName);
                CloudBlob newBlob = container.GetBlobReference(newBlobName);
                //create a new blob
                newBlob.StartCopy(existBlob.Uri);
                existBlob.DeleteIfExists();
                return true;
            }
            catch (Exception exe)
            {
                string error = exe.ToString();
                return false;
            }


        }
        /// <summary>
        /// Will delete a specific file from the specific container
        /// will return false if the file or storage is not found
        /// and also in case of any error.
        /// </summary>
        /// <param name="BlobContainer"> name of the blob container</param>
        /// <param name="outFileName">NAme of the file wanted to be fetched</param>
        /// <returns> true for success and false for failure</returns>
        public bool DeleteBlobFile(string BlobContainer, string FileName, int FromInstanceId, int ToInstanceId = 0)
        {
            ReInitiate();
            try
            {
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer container = blobClient.GetContainerReference(BlobContainer);
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(FileName.Trim());
                blockBlob.Delete();
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
    public class QueueStorage
    {
        internal static string StorageConnectionString = "";
        public CloudStorageAccount storageAccount;
        public string FromOrganizationID;
        public QueueStorage(string constr, string FromOrganizationID)
        {
            StorageConnectionString = constr;
            this.FromOrganizationID = FromOrganizationID;
            ReInitiate();
        }
        public QueueStorage(string constr)
        {
            StorageConnectionString = constr;
            ReInitiate();
        }
        /// <summary>
        /// For re-initiate the connection to the storage account
        /// create another connection if we loss the current one
        /// </summary>
        private void ReInitiate()
        {

            if (storageAccount == null)
            {
                storageAccount = CloudStorageAccount.Parse(StorageConnectionString);
            }
        }
        public bool CreateQueue(string QueueName, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(QueueName);
                queue.CreateIfNotExists();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
        /// <summary>
        /// This will Creats a queue if the specified queue is not yet created
        /// Then add the message to the queue
        /// will true/false as result
        /// </summary>
        /// <param name="messageContent"> message contents for the queue</param>
        /// <param name="queueReference"> queue reference name</param>
        /// <returns> true for success and false for failure</returns>
        public bool CreateQueueMessage(DataTable messageContentTable, string queueReference, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                string key = FromOrganizationID + FromInstanceId.ToString("000");
                string messageContent = JSONHandler.GetEquivalentJSON(messageContentTable);
                messageContent = CryptorEngine.Encrypt(messageContent, true, key);
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(queueReference);
                queue.CreateIfNotExists();
                CloudQueueMessage message = new CloudQueueMessage(messageContent);
                queue.AddMessage(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// will return HTML List as string that containg list of queue name 
        /// and a sub list of queue elements
        /// will return html string of error message
        /// </summary>
        /// <param name="queueReference"> queue reference name</param>
        /// <returns> true for success and false for failure</returns>
        public object GetQueueMessages<T>(string queueReferenceName, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                if (typeof(T) == typeof(List<string>))
                {
                    List<string> MessageList = new List<string>();
                    CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                    CloudQueue q = queueClient.GetQueueReference(queueReferenceName);
                    q.FetchAttributes();
                    int messageCount = q.ApproximateMessageCount == null ? 0 : (int)q.ApproximateMessageCount;
                    if (messageCount - 1 > 0)
                    {
                        foreach (var message in q.GetMessages(messageCount - 1))
                        {
                            MessageList.Add(message.Id);
                        }
                    }
                    else
                    {
                        MessageList.Add("No messages found");
                    }
                    return MessageList;
                }
                else
                {
                    StringBuilder htmlBuilder = new StringBuilder();
                    htmlBuilder.Append("<ul>");
                    CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                    CloudQueue q = queueClient.GetQueueReference(queueReferenceName);
                    q.FetchAttributes();
                    int messageCount = q.ApproximateMessageCount == null ? 0 : (int)q.ApproximateMessageCount;
                    foreach (var message in q.GetMessages(messageCount - 1))
                    {
                        htmlBuilder.Append("<li>" + message.Id + "</li>");
                    }
                    htmlBuilder.Append("</ul>");
                    return htmlBuilder.ToString();
                }

            }
            catch (Exception ex)
            {
                string exceptionString = ex.ToString();
                return new List<string>() { "Operation Failed" };
            }
        }
        /// <summary>
        /// We can delete only the top elements of the so we require only the 
        /// queue name for performin delete operation
        /// boolean value will be returned to indicate the result of operation
        /// </summary>
        /// <param name="queueReference"> queue reference name</param>
        /// <returns> true for success and false for failure</returns>
        public bool DeleteMessageFromQueue(string queueReference, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(queueReference);
                CloudQueueMessage retrievedMessage = queue.GetMessage();
                queue.DeleteMessage(retrievedMessage);
                return true;
            }
            catch
            {

                return false;
            }
        }
        /// <summary>
        /// Return the top message from the specified queue storage
        /// will return the message if success else return null
        /// </summary>
        /// <param name="queueReference"> queue reference name</param>
        /// <returns>message if success null if failure</returns>
        public string GetMessageFromQueue(string queueReference, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {
                string key = FromOrganizationID + FromInstanceId.ToString("000");
                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(queueReference);
                CloudQueueMessage message = queue.GetMessage();
                string cipherMessage = message.AsString;
                string JSONMessage = CryptorEngine.Decrypt(cipherMessage, true, key);
                return JSONMessage;
            }
            catch
            {

                return null;
            }
        }
        /// <summary>
        /// update the fetched message of the specified queue
        /// </summary>
        /// <param name="queueReference"> queue reference name</param>
        /// <param name="newMessage">content to update</param>
        /// <returns> true for success and false for failure</returns>
        public bool UpdateQueueMessage(string queueReference, DataTable messageContentTable, int FromInstanceId, int ToInstanceId = 0)
        {
            try
            {

                CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
                CloudQueue queue = queueClient.GetQueueReference(queueReference);
                CloudQueueMessage message = queue.GetMessage();
                string newMessage = JSONHandler.GetEquivalentJSON(messageContentTable);
                message.SetMessageContent(newMessage);
                queue.UpdateMessage(message,
                    TimeSpan.FromSeconds(60.0),  // Make it visible for another 60 seconds.
                    MessageUpdateFields.Content | MessageUpdateFields.Visibility);
                return true;
            }
            catch
            {

                return false;
            }
        }

    }

}
