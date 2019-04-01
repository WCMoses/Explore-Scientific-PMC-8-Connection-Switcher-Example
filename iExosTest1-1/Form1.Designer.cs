namespace iExosTest1_1
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label17 = new System.Windows.Forms.Label();
            this.chkShowAdvancedOptions = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdDetails = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpBasic = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdBasic2CheckCurrentConnection = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmdBasic2ViaUdp = new System.Windows.Forms.Button();
            this.cmdBasic2ViaTCP = new System.Windows.Forms.Button();
            this.cmdBasic2ViaAscom = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbBasic2SerialPort = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBasic2IpPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBasic2MountType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBasic2IpAddress = new System.Windows.Forms.TextBox();
            this.tpAdvanced = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdAdvancedEsgp0 = new System.Windows.Forms.Button();
            this.cmdAdvancedESY = new System.Windows.Forms.Button();
            this.cmdAdvancedEsx = new System.Windows.Forms.Button();
            this.cmdSendCustomCommand = new System.Windows.Forms.Button();
            this.txtCommandToSend = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsConnectionMethod = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCurrentWiFi = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAutoDetect = new System.Windows.Forms.RadioButton();
            this.rbTcp = new System.Windows.Forms.RadioButton();
            this.rbUdp = new System.Windows.Forms.RadioButton();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.cmdClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpBasic.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tpAdvanced.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(900, 632);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(284, 53);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.cmdClear);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.chkShowAdvancedOptions);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdDetails);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdClose);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1336, 1023);
            this.splitContainer1.SplitterDistance = 735;
            this.splitContainer1.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1204, 33);
            this.label17.TabIndex = 15;
            this.label17.Text = "WARNING - Make sure all other astronomy and communications programs are closed";
            // 
            // chkShowAdvancedOptions
            // 
            this.chkShowAdvancedOptions.AutoSize = true;
            this.chkShowAdvancedOptions.Location = new System.Drawing.Point(415, 645);
            this.chkShowAdvancedOptions.Name = "chkShowAdvancedOptions";
            this.chkShowAdvancedOptions.Size = new System.Drawing.Size(279, 29);
            this.chkShowAdvancedOptions.TabIndex = 14;
            this.chkShowAdvancedOptions.Text = "Show Advanced Options";
            this.chkShowAdvancedOptions.UseVisualStyleBackColor = true;
            this.chkShowAdvancedOptions.CheckedChanged += new System.EventHandler(this.chkShowAdvancedOptions_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::iExosTest1_1.Properties.Resources.ASCOM_logo1;
            this.pictureBox3.Location = new System.Drawing.Point(1125, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 203);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::iExosTest1_1.Properties.Resources.ES_Logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(396, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(604, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iExosTest1_1.Properties.Resources.PMC8_hires;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmdDetails
            // 
            this.cmdDetails.Location = new System.Drawing.Point(20, 632);
            this.cmdDetails.Name = "cmdDetails";
            this.cmdDetails.Size = new System.Drawing.Size(130, 52);
            this.cmdDetails.TabIndex = 9;
            this.cmdDetails.Text = "Details >>>";
            this.cmdDetails.UseVisualStyleBackColor = true;
            this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpBasic);
            this.tabControl1.Controls.Add(this.tpAdvanced);
            this.tabControl1.Location = new System.Drawing.Point(12, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1312, 355);
            this.tabControl1.TabIndex = 8;
            // 
            // tpBasic
            // 
            this.tpBasic.BackColor = System.Drawing.Color.LightGray;
            this.tpBasic.Controls.Add(this.groupBox6);
            this.tpBasic.Controls.Add(this.groupBox5);
            this.tpBasic.Location = new System.Drawing.Point(8, 39);
            this.tpBasic.Name = "tpBasic";
            this.tpBasic.Size = new System.Drawing.Size(1296, 308);
            this.tpBasic.TabIndex = 3;
            this.tpBasic.Text = "Basic";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmdBasic2CheckCurrentConnection);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.cmdBasic2ViaUdp);
            this.groupBox6.Controls.Add(this.cmdBasic2ViaTCP);
            this.groupBox6.Controls.Add(this.cmdBasic2ViaAscom);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(537, 44);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(745, 261);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "How Would You Like To Connect";
            // 
            // cmdBasic2CheckCurrentConnection
            // 
            this.cmdBasic2CheckCurrentConnection.Location = new System.Drawing.Point(558, 220);
            this.cmdBasic2CheckCurrentConnection.Name = "cmdBasic2CheckCurrentConnection";
            this.cmdBasic2CheckCurrentConnection.Size = new System.Drawing.Size(155, 37);
            this.cmdBasic2CheckCurrentConnection.TabIndex = 7;
            this.cmdBasic2CheckCurrentConnection.Text = "Do It";
            this.cmdBasic2CheckCurrentConnection.UseVisualStyleBackColor = true;
            this.cmdBasic2CheckCurrentConnection.Click += new System.EventHandler(this.cmdBasic2CheckCurrentConnection_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 216);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(359, 31);
            this.label19.TabIndex = 6;
            this.label19.Text = "Check Current Connection";
            // 
            // cmdBasic2ViaUdp
            // 
            this.cmdBasic2ViaUdp.Location = new System.Drawing.Point(546, 164);
            this.cmdBasic2ViaUdp.Name = "cmdBasic2ViaUdp";
            this.cmdBasic2ViaUdp.Size = new System.Drawing.Size(167, 50);
            this.cmdBasic2ViaUdp.TabIndex = 5;
            this.cmdBasic2ViaUdp.Text = "Do It";
            this.cmdBasic2ViaUdp.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaUdp.Click += new System.EventHandler(this.cmdBasic2ViaUdp_Click);
            // 
            // cmdBasic2ViaTCP
            // 
            this.cmdBasic2ViaTCP.Location = new System.Drawing.Point(546, 102);
            this.cmdBasic2ViaTCP.Name = "cmdBasic2ViaTCP";
            this.cmdBasic2ViaTCP.Size = new System.Drawing.Size(167, 48);
            this.cmdBasic2ViaTCP.TabIndex = 4;
            this.cmdBasic2ViaTCP.Text = "Do It";
            this.cmdBasic2ViaTCP.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaTCP.Click += new System.EventHandler(this.cmdBasic2ViaTCP_Click);
            // 
            // cmdBasic2ViaAscom
            // 
            this.cmdBasic2ViaAscom.Location = new System.Drawing.Point(546, 37);
            this.cmdBasic2ViaAscom.Name = "cmdBasic2ViaAscom";
            this.cmdBasic2ViaAscom.Size = new System.Drawing.Size(167, 50);
            this.cmdBasic2ViaAscom.TabIndex = 3;
            this.cmdBasic2ViaAscom.Text = "Do It";
            this.cmdBasic2ViaAscom.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaAscom.Click += new System.EventHandler(this.cmdBasic2ViaAscom_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 31);
            this.label16.TabIndex = 2;
            this.label16.Text = "Via ExploreStars (UDP)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(374, 31);
            this.label15.TabIndex = 1;
            this.label15.Text = "Via Wireless ASCOM (TCP)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Via ASCOM (Serial)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbBasic2SerialPort);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtBasic2IpPort);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.cmbBasic2MountType);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtBasic2IpAddress);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(40, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 262);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // cmbBasic2SerialPort
            // 
            this.cmbBasic2SerialPort.FormattingEnabled = true;
            this.cmbBasic2SerialPort.Location = new System.Drawing.Point(223, 223);
            this.cmbBasic2SerialPort.Name = "cmbBasic2SerialPort";
            this.cmbBasic2SerialPort.Size = new System.Drawing.Size(195, 39);
            this.cmbBasic2SerialPort.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 31);
            this.label18.TabIndex = 6;
            this.label18.Text = "Serial Port";
            // 
            // txtBasic2IpPort
            // 
            this.txtBasic2IpPort.Location = new System.Drawing.Point(223, 178);
            this.txtBasic2IpPort.Name = "txtBasic2IpPort";
            this.txtBasic2IpPort.Size = new System.Drawing.Size(195, 38);
            this.txtBasic2IpPort.TabIndex = 5;
            this.txtBasic2IpPort.Text = "54372";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 31);
            this.label13.TabIndex = 4;
            this.label13.Text = "IP Port";
            // 
            // cmbBasic2MountType
            // 
            this.cmbBasic2MountType.FormattingEnabled = true;
            this.cmbBasic2MountType.Items.AddRange(new object[] {
            "iExos100",
            "G11",
            "Exos-2"});
            this.cmbBasic2MountType.Location = new System.Drawing.Point(223, 52);
            this.cmbBasic2MountType.Name = "cmbBasic2MountType";
            this.cmbBasic2MountType.Size = new System.Drawing.Size(195, 39);
            this.cmbBasic2MountType.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mount Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "IP Address";
            // 
            // txtBasic2IpAddress
            // 
            this.txtBasic2IpAddress.Location = new System.Drawing.Point(223, 105);
            this.txtBasic2IpAddress.Name = "txtBasic2IpAddress";
            this.txtBasic2IpAddress.Size = new System.Drawing.Size(195, 38);
            this.txtBasic2IpAddress.TabIndex = 0;
            this.txtBasic2IpAddress.Text = "192.168.47.1";
            // 
            // tpAdvanced
            // 
            this.tpAdvanced.BackColor = System.Drawing.Color.LightGray;
            this.tpAdvanced.Controls.Add(this.groupBox1);
            this.tpAdvanced.Controls.Add(this.groupBox4);
            this.tpAdvanced.Controls.Add(this.groupBox2);
            this.tpAdvanced.Location = new System.Drawing.Point(8, 39);
            this.tpAdvanced.Name = "tpAdvanced";
            this.tpAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvanced.Size = new System.Drawing.Size(1296, 308);
            this.tpAdvanced.TabIndex = 1;
            this.tpAdvanced.Text = "Advanced";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdAdvancedEsgp0);
            this.groupBox4.Controls.Add(this.cmdAdvancedESY);
            this.groupBox4.Controls.Add(this.cmdAdvancedEsx);
            this.groupBox4.Controls.Add(this.cmdSendCustomCommand);
            this.groupBox4.Controls.Add(this.txtCommandToSend);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(560, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 167);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Command";
            // 
            // cmdAdvancedEsgp0
            // 
            this.cmdAdvancedEsgp0.Location = new System.Drawing.Point(469, 95);
            this.cmdAdvancedEsgp0.Name = "cmdAdvancedEsgp0";
            this.cmdAdvancedEsgp0.Size = new System.Drawing.Size(135, 57);
            this.cmdAdvancedEsgp0.TabIndex = 5;
            this.cmdAdvancedEsgp0.Text = "ESGp0!";
            this.cmdAdvancedEsgp0.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsgp0.Click += new System.EventHandler(this.cmdAdvancedEsgp0_Click);
            // 
            // cmdAdvancedESY
            // 
            this.cmdAdvancedESY.Location = new System.Drawing.Point(251, 95);
            this.cmdAdvancedESY.Name = "cmdAdvancedESY";
            this.cmdAdvancedESY.Size = new System.Drawing.Size(169, 57);
            this.cmdAdvancedESY.TabIndex = 4;
            this.cmdAdvancedESY.Text = "ESY!";
            this.cmdAdvancedESY.UseVisualStyleBackColor = true;
            this.cmdAdvancedESY.Click += new System.EventHandler(this.cmdAdvancedESY_Click);
            // 
            // cmdAdvancedEsx
            // 
            this.cmdAdvancedEsx.Location = new System.Drawing.Point(25, 95);
            this.cmdAdvancedEsx.Name = "cmdAdvancedEsx";
            this.cmdAdvancedEsx.Size = new System.Drawing.Size(163, 57);
            this.cmdAdvancedEsx.TabIndex = 3;
            this.cmdAdvancedEsx.Text = "ESX!";
            this.cmdAdvancedEsx.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsx.Click += new System.EventHandler(this.cmdAdvancedEsx_Click);
            // 
            // cmdSendCustomCommand
            // 
            this.cmdSendCustomCommand.Location = new System.Drawing.Point(491, 37);
            this.cmdSendCustomCommand.Name = "cmdSendCustomCommand";
            this.cmdSendCustomCommand.Size = new System.Drawing.Size(107, 42);
            this.cmdSendCustomCommand.TabIndex = 2;
            this.cmdSendCustomCommand.Text = "Send";
            this.cmdSendCustomCommand.UseVisualStyleBackColor = true;
            this.cmdSendCustomCommand.Click += new System.EventHandler(this.cmdSendCustomCommand_Click);
            // 
            // txtCommandToSend
            // 
            this.txtCommandToSend.Location = new System.Drawing.Point(233, 44);
            this.txtCommandToSend.Name = "txtCommandToSend";
            this.txtCommandToSend.Size = new System.Drawing.Size(226, 31);
            this.txtCommandToSend.TabIndex = 1;
            this.txtCommandToSend.Text = "ESGp0!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Command To Send";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 305);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Common Commands";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Common COmmands";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsConnectionMethod,
            this.toolStripStatusLabel2,
            this.tsCurrentWiFi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1336, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Connection Method";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(254, 32);
            this.toolStripStatusLabel1.Text = "Connection Method:";
            // 
            // tsConnectionMethod
            // 
            this.tsConnectionMethod.Name = "tsConnectionMethod";
            this.tsConnectionMethod.Size = new System.Drawing.Size(178, 32);
            this.tsConnectionMethod.Text = "Not Connected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(278, 32);
            this.toolStripStatusLabel2.Text = "Current WiFi Network:";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsCurrentWiFi
            // 
            this.tsCurrentWiFi.Name = "tsCurrentWiFi";
            this.tsCurrentWiFi.Size = new System.Drawing.Size(178, 32);
            this.tsCurrentWiFi.Text = "Not Connected";
            this.tsCurrentWiFi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(1336, 284);
            this.txtOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSerial);
            this.groupBox1.Controls.Add(this.rbUdp);
            this.groupBox1.Controls.Add(this.rbTcp);
            this.groupBox1.Controls.Add(this.rbAutoDetect);
            this.groupBox1.Location = new System.Drawing.Point(570, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Method";
            // 
            // rbAutoDetect
            // 
            this.rbAutoDetect.AutoSize = true;
            this.rbAutoDetect.Location = new System.Drawing.Point(94, 30);
            this.rbAutoDetect.Name = "rbAutoDetect";
            this.rbAutoDetect.Size = new System.Drawing.Size(155, 29);
            this.rbAutoDetect.TabIndex = 0;
            this.rbAutoDetect.TabStop = true;
            this.rbAutoDetect.Text = "Auto Detect";
            this.rbAutoDetect.UseVisualStyleBackColor = true;
            // 
            // rbTcp
            // 
            this.rbTcp.AutoSize = true;
            this.rbTcp.Location = new System.Drawing.Point(94, 66);
            this.rbTcp.Name = "rbTcp";
            this.rbTcp.Size = new System.Drawing.Size(85, 29);
            this.rbTcp.TabIndex = 1;
            this.rbTcp.TabStop = true;
            this.rbTcp.Text = "TCP";
            this.rbTcp.UseVisualStyleBackColor = true;
            // 
            // rbUdp
            // 
            this.rbUdp.AutoSize = true;
            this.rbUdp.Location = new System.Drawing.Point(323, 30);
            this.rbUdp.Name = "rbUdp";
            this.rbUdp.Size = new System.Drawing.Size(87, 29);
            this.rbUdp.TabIndex = 2;
            this.rbUdp.TabStop = true;
            this.rbUdp.Text = "UDP";
            this.rbUdp.UseVisualStyleBackColor = true;
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Location = new System.Drawing.Point(323, 77);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(98, 29);
            this.rbSerial.TabIndex = 3;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(201, 632);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(139, 53);
            this.cmdClear.TabIndex = 16;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 1023);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpBasic.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpAdvanced.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkShowAdvancedOptions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsConnectionMethod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpBasic;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button cmdBasic2CheckCurrentConnection;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button cmdBasic2ViaUdp;
        private System.Windows.Forms.Button cmdBasic2ViaTCP;
        private System.Windows.Forms.Button cmdBasic2ViaAscom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbBasic2SerialPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBasic2IpPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBasic2MountType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBasic2IpAddress;
        private System.Windows.Forms.TabPage tpAdvanced;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdSendCustomCommand;
        private System.Windows.Forms.TextBox txtCommandToSend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdAdvancedEsgp0;
        private System.Windows.Forms.Button cmdAdvancedESY;
        private System.Windows.Forms.Button cmdAdvancedEsx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsCurrentWiFi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.RadioButton rbUdp;
        private System.Windows.Forms.RadioButton rbTcp;
        private System.Windows.Forms.RadioButton rbAutoDetect;
        private System.Windows.Forms.Button cmdClear;
    }
}

