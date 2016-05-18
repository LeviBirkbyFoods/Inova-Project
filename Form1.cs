using AzureStorageHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_cs
{
    public partial class Form1 : Form
    {
        public string inputFileName = string.Empty;
        public string OrganizationID = String.Empty;
        public int FromInstanceID = 0;
        public string selectedValue = String.Empty;
        public BlobStorage storageBlobInstance;// = new BlobStorage(ConfigurationManager.AppSettings["constr"].ToString(), "ORG001A");
        public QueueStorage storageQueueInstance;// = new QueueStorage(ConfigurationManager.AppSettings["constr"].ToString(), "ORG001A");
        public RegistoryHandler RegistoryHandlerInstance;
        public Dictionary<string, List<string>> BindingDictonary;
        public Form1()
        {
            InitializeComponent();
            lblBlobNotification.Visible = false;
            if (txtOrganizationID.Text == String.Empty || txtFromInstanceID.Text == "")
            {
                MessageBox.Show("Please Set the OrganizationID and FromInstanceID to Proceed");
                txtOrganizationID.Focus();
            }
            else
            {
                Initializer();
            }
        }
        public void Initializer()
        {
            OrganizationID = txtOrganizationID.Text;
            FromInstanceID = Convert.ToInt32(txtFromInstanceID.Text);
            storageBlobInstance = new BlobStorage(ConfigurationManager.AppSettings["constr"].ToString(), OrganizationID);
            storageQueueInstance = new QueueStorage(ConfigurationManager.AppSettings["constr"].ToString(), OrganizationID);
            RegistoryHandlerInstance = new RegistoryHandler(ConfigurationManager.AppSettings["constrForDb"].ToString());
            LoadContainers();
            LoadPractice();
        }
        public void LoadPractice()
        {
            DataTable bindingTable = RegistoryHandlerInstance.GetPracticeList();
            cboPracticeClient.DataSource = new BindingSource(bindingTable, null);
            cboPracticePatient.DataSource = new BindingSource(bindingTable, null);
            cboPracticeClient.ValueMember = "id";
            cboPracticeClient.DisplayMember = "practice";
            cboPracticePatient.ValueMember = "id";
            cboPracticePatient.DisplayMember = "practice";
        }
        private void btnFileChooser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                inputFileName = openFileDialog1.FileName;
                lblSelectedFile.Text = "Selected File :" + new FileInfo(inputFileName).Name;
            }
        }
        public void setSuccessMessage(string message = "Process Initiated")
        {
            lblBlobNotification.Text = message;
            lblBlobNotification.ForeColor = Color.Green;
            lblBlobNotification.Visible = true;
        }
        public void setErrorMessage(string message = "Process Aborted")
        {
            lblBlobNotification.Text = message;
            lblBlobNotification.ForeColor = Color.Red;
            lblBlobNotification.Visible = true;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            if (inputFileName != String.Empty)
            {
                FileStream fstream = new FileStream(inputFileName, FileMode.Open);
                string blobFileName = txtBlobName.Text;
                string container = txtContainer.Text;
                string result = storageBlobInstance.UploadToBlobStorage(blobFileName, fstream, container, 5);
                MessageBox.Show(result + "Please wait... Container is refreshing");
                BindingDictonary[container].Add(blobFileName);
            }
        }
        public void LoadContainers()
        {
            lblBlobNotification.Visible = false;
            BindingDictonary = storageBlobInstance.GetMyContainers();
            cboContainers.DataSource = new BindingSource(BindingDictonary, null);
            cboContainers.DisplayMember = "Key";
            cboContainers.ValueMember = "Key";
            if (selectedValue != string.Empty)
            {
                cboContainers.SelectedValue = selectedValue;
            }
        }
        public void ReLoadContainers()
        {
            cboContainers.DataSource = new BindingSource(BindingDictonary, null);
            cboContainers.DisplayMember = "Key";
            cboContainers.ValueMember = "Key";
            if (selectedValue != string.Empty)
            {
                cboContainers.SelectedValue = selectedValue;
            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            string blobFileName = lstBlobs.SelectedItem.ToString();
            string container = cboContainers.SelectedValue.ToString();
            string outFolder = String.Empty;
            folderBrowserDialog1.Description = "Select Folder";
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outFolder = folderBrowserDialog1.SelectedPath + @"\";
            }
            if (storageBlobInstance.GetFileBack<bool>(outFolder, container, blobFileName, 5))
                MessageBox.Show("File saved to " + outFolder);
            else
                MessageBox.Show("Operation Failed");
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            if (storageBlobInstance.CreateContainer(txtContainer.Text, 5))
            {
                setSuccessMessage("Container Created Successfully, Please wait while refreshing the list");
                selectedValue = txtContainer.Text;
                LoadContainers();
            }
            else
            {
                setErrorMessage("Container Creation Failed");
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreateQueue_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            setSuccessMessage("Process Initiated");
            if (storageQueueInstance.CreateQueue(txtQueueName.Text, 5))
            {
                setSuccessMessage("Queue Created Successfully");
            }
            else
            {
                setErrorMessage("Queue Creation Failed");
            }
        }

        private void btnCreateMessage_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            DataTable MessageTable = new DataTable();
            MessageTable.Columns.Add("FromInstanceID");
            MessageTable.Columns.Add("Message");
            MessageTable.Columns.Add("Date");
            DataRow drow = MessageTable.NewRow();
            drow["FromInstanceID"] = "5";
            drow["Message"] = rtMessage.Text;
            drow["Date"] = DateTime.Now;
            MessageTable.Rows.Add(drow);
            setSuccessMessage("Process Initiated");
            if (storageQueueInstance.CreateQueueMessage(MessageTable, txtQueueName.Text, 5))
            {
                setSuccessMessage("Message Created Successfully");
            }
            else
            {
                setErrorMessage("Message Creation Failed");
            }
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            setSuccessMessage("Process Initiated");
            if (storageQueueInstance.DeleteMessageFromQueue(txtQueueName.Text, 5))
            {
                setSuccessMessage("Message Deleted Successfully");
            }
            else
            {
                setErrorMessage("Message Deletion Failed");
            }
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            setSuccessMessage("Process Initiated");
            string lastMessage = storageQueueInstance.GetMessageFromQueue(txtQueueName.Text, 5);
            if (lastMessage != null)
            {
                rtMessage.Text = lastMessage;
                setSuccessMessage("Message Fetched Successfully");
            }
            else
            {
                setErrorMessage("Message Fetching Failed");
            }
            lstMessageList.Visible = false;
            rtMessage.Visible = true;

        }

        private void btnMessageList_Click(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            setSuccessMessage("Process Initiated");
            List<string> MessageList = (List<string>)storageQueueInstance.GetQueueMessages<List<string>>(txtQueueName.Text, 5);
            lstMessageList.DataSource = new BindingSource(MessageList, null);
            setSuccessMessage("Process Completed");
            lstMessageList.Visible = true;
            rtMessage.Visible = false;
        }

        private void cboContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBlobNotification.Visible = false;
            var selectedItem = (KeyValuePair<string, List<string>>)cboContainers.SelectedItem;
            if (!selectedItem.Equals(null))
            {
                List<string> BlobList = selectedItem.Value;
                lstBlobs.DataSource = BlobList;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedValue = cboContainers.SelectedValue.ToString();
            string blobFileName = lstBlobs.SelectedItem.ToString();
            string container = cboContainers.SelectedValue.ToString();
            if (storageBlobInstance.DeleteBlobFile(container, blobFileName, 5))
            {
                BindingDictonary[container].Remove(blobFileName);
                setSuccessMessage("Message Deleted Successfully");
                ReLoadContainers();
            }
            else
            {
                setErrorMessage("Message Deletion Failed");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectedValue = cboContainers.SelectedValue.ToString();
            LoadContainers();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            OrganizationID = txtOrganizationID.Text;
            FromInstanceID = Convert.ToInt32(txtFromInstanceID.Text);
            MessageBox.Show("Thank you... ! We are Initializing the Details... This may take few minutes");
            storageBlobInstance = new BlobStorage(ConfigurationManager.AppSettings["constr"].ToString(), OrganizationID);
            storageQueueInstance = new QueueStorage(ConfigurationManager.AppSettings["constr"].ToString(), OrganizationID);
            LoadContainers();
            LoadPractice();
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
        private void btnInserPatient_Click(object sender, EventArgs e)
        {
            lblInfoRegistry.Text = RegistoryHandlerInstance.InsertIntoPatientReg("", txtPatientID.Text, cboPracticePatient.SelectedValue.ToString(), "", DateTime.Now);
        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            lblInfoRegistry.Text = RegistoryHandlerInstance.InsertIntoPatientReg("", txtClientID.Text, cboPracticeClient.SelectedValue.ToString(), "", DateTime.Now);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newBlobName = Microsoft.VisualBasic.Interaction.InputBox("Enter new Blob Name without extension",
                       "Rename Blob",
                       "Default",
                       0,
                       0);
            if (newBlobName != "" && cboContainers.SelectedValue != null && lstBlobs.SelectedValue != null)
            {
                selectedValue = cboContainers.SelectedValue.ToString();
                string extension = lstBlobs.SelectedValue.ToString();
                if (extension.Contains("."))
                    extension = extension.Substring(extension.LastIndexOf("."));
                if (storageBlobInstance.RenameBlob(cboContainers.SelectedValue.ToString(),
                    lstBlobs.SelectedValue.ToString(), newBlobName))
                {
                    setSuccessMessage("Blob Renamed successfully");
                    BindingDictonary[selectedValue][lstBlobs.SelectedIndex] = newBlobName + extension;
                }
                else
                {
                    setErrorMessage("Operation failed");
                }
                ReLoadContainers();
            }
        }

        private void btnDownByteArray_Click(object sender, EventArgs e)
        {

            lblBlobNotification.Visible = false;
            string blobFileName = lstBlobs.SelectedItem.ToString();
            string container = cboContainers.SelectedValue.ToString();
            byte[] FileContent = storageBlobInstance.GetFileBack<byte[]>("", container, blobFileName, 5);
            if (FileContent != null)
            {
                string arrayContent = System.Text.Encoding.UTF8.GetString(FileContent);
                MessageBox.Show("File Content is " + arrayContent);
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtMessage.Visible = true;
            lstMessageList.Visible = false;
        }
    }
}
