namespace form_cs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.btnFileChooser = new System.Windows.Forms.Button();
            this.txtContainer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblBlobNotification = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstMessageList = new System.Windows.Forms.ListBox();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.btnMessageList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateMessage = new System.Windows.Forms.Button();
            this.rtMessage = new System.Windows.Forms.RichTextBox();
            this.btnCreateQueue = new System.Windows.Forms.Button();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDownByteArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBlobs = new System.Windows.Forms.ListBox();
            this.cboContainers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.txtFromInstanceID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrganizationID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbregistery = new System.Windows.Forms.TabControl();
            this.tbPatient = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cboPracticePatient = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.btnInserPatient = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cboPracticeClient = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInfoRegistry = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tbregistery.SuspendLayout();
            this.tbPatient.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tbClient.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(232, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload File to Blob Storage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateContainer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSelectedFile);
            this.groupBox2.Controls.Add(this.btnFileChooser);
            this.groupBox2.Controls.Add(this.txtContainer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBlobName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 277);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.Location = new System.Drawing.Point(328, 22);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(34, 27);
            this.btnCreateContainer.TabIndex = 13;
            this.btnCreateContainer.Text = "+";
            this.btnCreateContainer.UseVisualStyleBackColor = true;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose a File";
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSelectedFile.Location = new System.Drawing.Point(5, 111);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(357, 20);
            this.lblSelectedFile.TabIndex = 11;
            this.lblSelectedFile.Text = "Selected File :";
            // 
            // btnFileChooser
            // 
            this.btnFileChooser.Location = new System.Drawing.Point(142, 64);
            this.btnFileChooser.Name = "btnFileChooser";
            this.btnFileChooser.Size = new System.Drawing.Size(138, 29);
            this.btnFileChooser.TabIndex = 10;
            this.btnFileChooser.Text = "Choose File";
            this.btnFileChooser.UseVisualStyleBackColor = true;
            this.btnFileChooser.Click += new System.EventHandler(this.btnFileChooser_Click);
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(142, 22);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(180, 26);
            this.txtContainer.TabIndex = 9;
            this.txtContainer.Text = "07052016";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Container Name";
            // 
            // txtBlobName
            // 
            this.txtBlobName.Location = new System.Drawing.Point(142, 148);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(220, 26);
            this.txtBlobName.TabIndex = 17;
            this.txtBlobName.Text = "sampleBlob";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blob Name";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(9, 269);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 32);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Download AS File";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblBlobNotification
            // 
            this.lblBlobNotification.AutoSize = true;
            this.lblBlobNotification.Location = new System.Drawing.Point(185, 450);
            this.lblBlobNotification.Name = "lblBlobNotification";
            this.lblBlobNotification.Size = new System.Drawing.Size(35, 13);
            this.lblBlobNotification.TabIndex = 5;
            this.lblBlobNotification.Text = "label5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpload);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(34, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 62);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(129, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 32);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Upload Blob";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(24, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 54);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Storage Queue Management";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstMessageList);
            this.groupBox5.Controls.Add(this.btnGetMessage);
            this.groupBox5.Controls.Add(this.btnMessageList);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.btnDeleteMessage);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.btnCreateMessage);
            this.groupBox5.Controls.Add(this.rtMessage);
            this.groupBox5.Controls.Add(this.btnCreateQueue);
            this.groupBox5.Controls.Add(this.txtQueueName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(24, 543);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(373, 388);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inputs";
            // 
            // lstMessageList
            // 
            this.lstMessageList.FormattingEnabled = true;
            this.lstMessageList.Location = new System.Drawing.Point(10, 145);
            this.lstMessageList.Name = "lstMessageList";
            this.lstMessageList.Size = new System.Drawing.Size(222, 186);
            this.lstMessageList.TabIndex = 23;
            this.lstMessageList.Visible = false;
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(208, 84);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(115, 32);
            this.btnGetMessage.TabIndex = 22;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // btnMessageList
            // 
            this.btnMessageList.Location = new System.Drawing.Point(57, 84);
            this.btnMessageList.Name = "btnMessageList";
            this.btnMessageList.Size = new System.Drawing.Size(125, 32);
            this.btnMessageList.TabIndex = 21;
            this.btnMessageList.Text = "Fetch Message List";
            this.btnMessageList.UseVisualStyleBackColor = true;
            this.btnMessageList.Click += new System.EventHandler(this.btnMessageList_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Show Editor";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Location = new System.Drawing.Point(247, 266);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(115, 32);
            this.btnDeleteMessage.TabIndex = 19;
            this.btnDeleteMessage.Text = "Delete Message";
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(247, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update Message";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreateMessage
            // 
            this.btnCreateMessage.Location = new System.Drawing.Point(247, 158);
            this.btnCreateMessage.Name = "btnCreateMessage";
            this.btnCreateMessage.Size = new System.Drawing.Size(115, 32);
            this.btnCreateMessage.TabIndex = 17;
            this.btnCreateMessage.Text = "Create Message";
            this.btnCreateMessage.UseVisualStyleBackColor = true;
            this.btnCreateMessage.Click += new System.EventHandler(this.btnCreateMessage_Click);
            // 
            // rtMessage
            // 
            this.rtMessage.Location = new System.Drawing.Point(9, 137);
            this.rtMessage.Name = "rtMessage";
            this.rtMessage.Size = new System.Drawing.Size(223, 193);
            this.rtMessage.TabIndex = 16;
            this.rtMessage.Text = "";
            // 
            // btnCreateQueue
            // 
            this.btnCreateQueue.Location = new System.Drawing.Point(329, 28);
            this.btnCreateQueue.Name = "btnCreateQueue";
            this.btnCreateQueue.Size = new System.Drawing.Size(34, 27);
            this.btnCreateQueue.TabIndex = 15;
            this.btnCreateQueue.Text = "+";
            this.btnCreateQueue.UseVisualStyleBackColor = true;
            this.btnCreateQueue.Click += new System.EventHandler(this.btnCreateQueue_Click);
            // 
            // txtQueueName
            // 
            this.txtQueueName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQueueName.Location = new System.Drawing.Point(143, 31);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(180, 20);
            this.txtQueueName.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Queue Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDownByteArray);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnRefresh);
            this.groupBox6.Controls.Add(this.btnDelete);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.lstBlobs);
            this.groupBox6.Controls.Add(this.cboContainers);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.btnDown);
            this.groupBox6.Location = new System.Drawing.Point(417, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(425, 335);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Get Blobs";
            // 
            // btnDownByteArray
            // 
            this.btnDownByteArray.Location = new System.Drawing.Point(113, 269);
            this.btnDownByteArray.Name = "btnDownByteArray";
            this.btnDownByteArray.Size = new System.Drawing.Size(133, 32);
            this.btnDownByteArray.TabIndex = 17;
            this.btnDownByteArray.Text = "Download AS byteArray";
            this.btnDownByteArray.UseVisualStyleBackColor = true;
            this.btnDownByteArray.Click += new System.EventHandler(this.btnDownByteArray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Rename Blob";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(318, 59);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 20);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 269);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Blob";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Available BlobFiles";
            // 
            // lstBlobs
            // 
            this.lstBlobs.FormattingEnabled = true;
            this.lstBlobs.Location = new System.Drawing.Point(9, 84);
            this.lstBlobs.Name = "lstBlobs";
            this.lstBlobs.Size = new System.Drawing.Size(400, 173);
            this.lstBlobs.TabIndex = 11;
            // 
            // cboContainers
            // 
            this.cboContainers.FormattingEnabled = true;
            this.cboContainers.Location = new System.Drawing.Point(115, 27);
            this.cboContainers.Name = "cboContainers";
            this.cboContainers.Size = new System.Drawing.Size(294, 21);
            this.cboContainers.TabIndex = 10;
            this.cboContainers.SelectedIndexChanged += new System.EventHandler(this.cboContainers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Container";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnInitialize);
            this.groupBox7.Controls.Add(this.txtFromInstanceID);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtOrganizationID);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(24, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(777, 66);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Initialize";
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(639, 22);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(79, 27);
            this.btnInitialize.TabIndex = 14;
            this.btnInitialize.Text = "Update";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // txtFromInstanceID
            // 
            this.txtFromInstanceID.Location = new System.Drawing.Point(457, 23);
            this.txtFromInstanceID.Name = "txtFromInstanceID";
            this.txtFromInstanceID.Size = new System.Drawing.Size(167, 26);
            this.txtFromInstanceID.TabIndex = 2;
            this.txtFromInstanceID.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(328, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "FromInstanceID";
            // 
            // txtOrganizationID
            // 
            this.txtOrganizationID.Location = new System.Drawing.Point(139, 26);
            this.txtOrganizationID.Name = "txtOrganizationID";
            this.txtOrganizationID.Size = new System.Drawing.Size(183, 26);
            this.txtOrganizationID.TabIndex = 1;
            this.txtOrganizationID.Text = "ORG001A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Organization ID";
            // 
            // tbregistery
            // 
            this.tbregistery.Controls.Add(this.tbPatient);
            this.tbregistery.Controls.Add(this.tbClient);
            this.tbregistery.Location = new System.Drawing.Point(417, 523);
            this.tbregistery.Name = "tbregistery";
            this.tbregistery.SelectedIndex = 0;
            this.tbregistery.Size = new System.Drawing.Size(425, 441);
            this.tbregistery.TabIndex = 24;
            // 
            // tbPatient
            // 
            this.tbPatient.Controls.Add(this.groupBox8);
            this.tbPatient.Controls.Add(this.groupBox9);
            this.tbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatient.Location = new System.Drawing.Point(4, 22);
            this.tbPatient.Name = "tbPatient";
            this.tbPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tbPatient.Size = new System.Drawing.Size(417, 415);
            this.tbPatient.TabIndex = 0;
            this.tbPatient.Text = "Patient";
            this.tbPatient.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Location = new System.Drawing.Point(12, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(377, 54);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Patient Registry";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cboPracticePatient);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.btnSearchPatient);
            this.groupBox9.Controls.Add(this.btnInserPatient);
            this.groupBox9.Controls.Add(this.txtPatientName);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.txtPatientID);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(12, 73);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(377, 201);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            // 
            // cboPracticePatient
            // 
            this.cboPracticePatient.FormattingEnabled = true;
            this.cboPracticePatient.Location = new System.Drawing.Point(148, 95);
            this.cboPracticePatient.Name = "cboPracticePatient";
            this.cboPracticePatient.Size = new System.Drawing.Size(220, 28);
            this.cboPracticePatient.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Select Practice";
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(7, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 51);
            this.label14.TabIndex = 17;
            this.label14.Text = "label14";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(263, 146);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(86, 32);
            this.btnSearchPatient.TabIndex = 16;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // btnInserPatient
            // 
            this.btnInserPatient.Location = new System.Drawing.Point(172, 146);
            this.btnInserPatient.Name = "btnInserPatient";
            this.btnInserPatient.Size = new System.Drawing.Size(85, 32);
            this.btnInserPatient.TabIndex = 15;
            this.btnInserPatient.Text = "Register";
            this.btnInserPatient.UseVisualStyleBackColor = true;
            this.btnInserPatient.Click += new System.EventHandler(this.btnInserPatient_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(148, 61);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(220, 26);
            this.txtPatientName.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Patient Name";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(148, 26);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(220, 26);
            this.txtPatientID.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Local Patient ID";
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.groupBox10);
            this.tbClient.Controls.Add(this.groupBox11);
            this.tbClient.Location = new System.Drawing.Point(4, 22);
            this.tbClient.Name = "tbClient";
            this.tbClient.Padding = new System.Windows.Forms.Padding(3);
            this.tbClient.Size = new System.Drawing.Size(417, 415);
            this.tbClient.TabIndex = 1;
            this.tbClient.Text = "Client";
            this.tbClient.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cboPracticeClient);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.btnSearchClient);
            this.groupBox10.Controls.Add(this.btnInsertClient);
            this.groupBox10.Controls.Add(this.txtClientName);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.txtClientID);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(15, 78);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(374, 207);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            // 
            // cboPracticeClient
            // 
            this.cboPracticeClient.FormattingEnabled = true;
            this.cboPracticeClient.Location = new System.Drawing.Point(149, 99);
            this.cboPracticeClient.Name = "cboPracticeClient";
            this.cboPracticeClient.Size = new System.Drawing.Size(219, 28);
            this.cboPracticeClient.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Select Practice";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(7, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 51);
            this.label15.TabIndex = 17;
            this.label15.Text = "label15";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(254, 150);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(86, 32);
            this.btnSearchClient.TabIndex = 16;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.Location = new System.Drawing.Point(163, 150);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(85, 32);
            this.btnInsertClient.TabIndex = 15;
            this.btnInsertClient.Text = "Register";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(148, 62);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(217, 26);
            this.txtClientName.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Client Name";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(148, 26);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(217, 26);
            this.txtClientID.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "Local Client ID";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Location = new System.Drawing.Point(15, 23);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(374, 54);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(95, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Client Registry";
            // 
            // lblInfoRegistry
            // 
            this.lblInfoRegistry.AutoSize = true;
            this.lblInfoRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoRegistry.ForeColor = System.Drawing.Color.Red;
            this.lblInfoRegistry.Location = new System.Drawing.Point(581, 504);
            this.lblInfoRegistry.Name = "lblInfoRegistry";
            this.lblInfoRegistry.Size = new System.Drawing.Size(0, 20);
            this.lblInfoRegistry.TabIndex = 25;
            this.lblInfoRegistry.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 983);
            this.Controls.Add(this.lblInfoRegistry);
            this.Controls.Add(this.tbregistery);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblBlobNotification);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tbregistery.ResumeLayout(false);
            this.tbPatient.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tbClient.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileChooser;
        private System.Windows.Forms.TextBox txtContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBlobNotification;
        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstMessageList;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Button btnMessageList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateMessage;
        private System.Windows.Forms.RichTextBox rtMessage;
        private System.Windows.Forms.Button btnCreateQueue;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBlobs;
        private System.Windows.Forms.ComboBox cboContainers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.TextBox txtFromInstanceID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOrganizationID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tbregistery;
        private System.Windows.Forms.TabPage tbPatient;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ComboBox cboPracticePatient;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnInserPatient;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tbClient;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cboPracticeClient;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Button btnInsertClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblInfoRegistry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDownByteArray;
    }
}

