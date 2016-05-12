namespace Dobot
{
    partial class frmDobot
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobot));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpPortSettings = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.cmPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBaudRate = new System.Windows.Forms.ComboBox();
            this.comPort = new System.Windows.Forms.Label();
            this.grpReturnPacket = new System.Windows.Forms.GroupBox();
            this.lblRetgripperAngle = new System.Windows.Forms.Label();
            this.lblRetisGrab = new System.Windows.Forms.Label();
            this.lblRetpawArmAngle = new System.Windows.Forms.Label();
            this.lblRetshortArmAngle = new System.Windows.Forms.Label();
            this.lblRetlongArmAngle = new System.Windows.Forms.Label();
            this.lblRetbaseAngle = new System.Windows.Forms.Label();
            this.lblRetrHand = new System.Windows.Forms.Label();
            this.lblRetZ = new System.Windows.Forms.Label();
            this.lblRetX = new System.Windows.Forms.Label();
            this.lblRetY = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPacketSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualDetetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAndDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlMode = new System.Windows.Forms.TabControl();
            this.tabTarget = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTargetGripper = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.grpTargetLinearMode = new System.Windows.Forms.GroupBox();
            this.txtTargetY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTargetX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtTargetZ = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.grpTargetJointMode = new System.Windows.Forms.GroupBox();
            this.txtTargetJoint1 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.txtTargetJoint3 = new System.Windows.Forms.TextBox();
            this.txtTargetJoint2 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.chkTargetisGrab = new System.Windows.Forms.CheckBox();
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.btnTargetConfigSend = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.txtTargetMovAccPercent = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txtTargetMovSpeedPercent = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtTargetServoAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtTargetPauseTime = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTargetServoSpeed = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTargetJointAcc = new System.Windows.Forms.TextBox();
            this.txtTargetJmpHeight = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtTargetJointSpeed = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtTargetLinearAcc = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtTargetLinearSpeed = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.btnTargetDataSend = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTargetRotation = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnJump = new System.Windows.Forms.RadioButton();
            this.rbtnMovl = new System.Windows.Forms.RadioButton();
            this.rbtnMovj = new System.Windows.Forms.RadioButton();
            this.chkAdvanced = new System.Windows.Forms.CheckBox();
            this.tabJog = new System.Windows.Forms.TabPage();
            this.grpJogLaser = new System.Windows.Forms.GroupBox();
            this.btnJogLaserOn = new System.Windows.Forms.Button();
            this.btnJogLaserOff = new System.Windows.Forms.Button();
            this.label99 = new System.Windows.Forms.Label();
            this.grpJogGripper = new System.Windows.Forms.GroupBox();
            this.btnJogGripperPlus = new System.Windows.Forms.Button();
            this.btnJogGripperMinus = new System.Windows.Forms.Button();
            this.label100 = new System.Windows.Forms.Label();
            this.grpJogGrab = new System.Windows.Forms.GroupBox();
            this.btnJogGrabOn = new System.Windows.Forms.Button();
            this.btnJogGrabOff = new System.Windows.Forms.Button();
            this.label101 = new System.Windows.Forms.Label();
            this.grpJogMode = new System.Windows.Forms.GroupBox();
            this.btnJogYMinus = new System.Windows.Forms.Button();
            this.btnJogXPlus = new System.Windows.Forms.Button();
            this.btnJogXMinus = new System.Windows.Forms.Button();
            this.btnJogYPlus = new System.Windows.Forms.Button();
            this.label102 = new System.Windows.Forms.Label();
            this.btnJogZPlus = new System.Windows.Forms.Button();
            this.btnJogZMinus = new System.Windows.Forms.Button();
            this.lblJogX = new System.Windows.Forms.Label();
            this.lblJogY = new System.Windows.Forms.Label();
            this.lblJogZ = new System.Windows.Forms.Label();
            this.btnJogRPlus = new System.Windows.Forms.Button();
            this.btnJogRMinus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJogConfigSend = new System.Windows.Forms.Button();
            this.txtJog_ServoAcc = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.txtJog_MaxSpeedPercent = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.txtJog_ServoSpeed = new System.Windows.Forms.TextBox();
            this.txtJog_LinearSpeed = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.txtJog_JointAcc = new System.Windows.Forms.TextBox();
            this.txtJog_LinearAcc = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.txtJog_JointSpeed = new System.Windows.Forms.TextBox();
            this.tabMouse = new System.Windows.Forms.TabPage();
            this.chkMouseisGrab = new System.Windows.Forms.CheckBox();
            this.btnMouseSend = new System.Windows.Forms.Button();
            this.label57 = new System.Windows.Forms.Label();
            this.txtMouseRotation = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.txtMousedz = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.txtMousedy = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.txtMousedx = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.tabWriteLaser = new System.Windows.Forms.TabPage();
            this.grpWLWritingOrLaser = new System.Windows.Forms.GroupBox();
            this.rbtnWLLaser = new System.Windows.Forms.RadioButton();
            this.rbtnWLWriting = new System.Windows.Forms.RadioButton();
            this.chkWLLaserOn = new System.Windows.Forms.CheckBox();
            this.btnWriteLaserSend = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.txtWriteLaserWritingAcc = new System.Windows.Forms.TextBox();
            this.labelx = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.txtWriteLaserMaxSpeed = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.txtWriteLaserFinalSpeed = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.txtWriteLaserInitSpeed = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.txtWriteLaserdz = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.txtWriteLaserdy = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtWriteLaserdx = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tabPacket = new System.Windows.Forms.TabPage();
            this.rbtnJoint = new System.Windows.Forms.RadioButton();
            this.rbtnLinear = new System.Windows.Forms.RadioButton();
            this.grpEndEffctor = new System.Windows.Forms.GroupBox();
            this.rbtnGrab = new System.Windows.Forms.RadioButton();
            this.rbtnLaser = new System.Windows.Forms.RadioButton();
            this.rbtnGripper = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOriginZ = new System.Windows.Forms.Label();
            this.lblOriginX = new System.Windows.Forms.Label();
            this.lblOriginY = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grpPortSettings.SuspendLayout();
            this.grpReturnPacket.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabCtrlMode.SuspendLayout();
            this.tabTarget.SuspendLayout();
            this.grpTargetLinearMode.SuspendLayout();
            this.grpTargetJointMode.SuspendLayout();
            this.grpAdvanced.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabJog.SuspendLayout();
            this.grpJogLaser.SuspendLayout();
            this.grpJogGripper.SuspendLayout();
            this.grpJogGrab.SuspendLayout();
            this.grpJogMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMouse.SuspendLayout();
            this.tabWriteLaser.SuspendLayout();
            this.grpWLWritingOrLaser.SuspendLayout();
            this.tabPacket.SuspendLayout();
            this.grpEndEffctor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sComm_DataReceived);
            // 
            // grpPortSettings
            // 
            this.grpPortSettings.Controls.Add(this.btClose);
            this.grpPortSettings.Controls.Add(this.btOpen);
            this.grpPortSettings.Controls.Add(this.cmPort);
            this.grpPortSettings.Controls.Add(this.label2);
            this.grpPortSettings.Controls.Add(this.cmBaudRate);
            this.grpPortSettings.Controls.Add(this.comPort);
            this.grpPortSettings.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.grpPortSettings.Location = new System.Drawing.Point(12, 40);
            this.grpPortSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPortSettings.Name = "grpPortSettings";
            this.grpPortSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPortSettings.Size = new System.Drawing.Size(182, 143);
            this.grpPortSettings.TabIndex = 0;
            this.grpPortSettings.TabStop = false;
            this.grpPortSettings.Text = "Port Settings";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Enabled = false;
            this.btClose.Font = new System.Drawing.Font("Calibri", 11F);
            this.btClose.Location = new System.Drawing.Point(93, 110);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 26);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "End";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Calibri", 11F);
            this.btOpen.Location = new System.Drawing.Point(5, 110);
            this.btOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 26);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Start";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // cmPort
            // 
            this.cmPort.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmPort.FormattingEnabled = true;
            this.cmPort.Location = new System.Drawing.Point(91, 25);
            this.cmPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmPort.Name = "cmPort";
            this.cmPort.Size = new System.Drawing.Size(79, 26);
            this.cmPort.Sorted = true;
            this.cmPort.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F);
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // cmBaudRate
            // 
            this.cmBaudRate.Font = new System.Drawing.Font("Calibri", 11F);
            this.cmBaudRate.FormattingEnabled = true;
            this.cmBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cmBaudRate.Location = new System.Drawing.Point(91, 68);
            this.cmBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.cmBaudRate.Name = "cmBaudRate";
            this.cmBaudRate.Size = new System.Drawing.Size(79, 26);
            this.cmBaudRate.TabIndex = 1;
            this.cmBaudRate.Text = "9600";
            // 
            // comPort
            // 
            this.comPort.AutoSize = true;
            this.comPort.Font = new System.Drawing.Font("Calibri", 11F);
            this.comPort.Location = new System.Drawing.Point(5, 29);
            this.comPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(34, 18);
            this.comPort.TabIndex = 1;
            this.comPort.Text = "Port";
            // 
            // grpReturnPacket
            // 
            this.grpReturnPacket.Controls.Add(this.lblRetgripperAngle);
            this.grpReturnPacket.Controls.Add(this.lblRetisGrab);
            this.grpReturnPacket.Controls.Add(this.lblRetpawArmAngle);
            this.grpReturnPacket.Controls.Add(this.lblRetshortArmAngle);
            this.grpReturnPacket.Controls.Add(this.lblRetlongArmAngle);
            this.grpReturnPacket.Controls.Add(this.lblRetbaseAngle);
            this.grpReturnPacket.Controls.Add(this.lblRetrHand);
            this.grpReturnPacket.Controls.Add(this.lblRetZ);
            this.grpReturnPacket.Controls.Add(this.lblRetX);
            this.grpReturnPacket.Controls.Add(this.lblRetY);
            this.grpReturnPacket.Controls.Add(this.label23);
            this.grpReturnPacket.Controls.Add(this.label22);
            this.grpReturnPacket.Controls.Add(this.label21);
            this.grpReturnPacket.Controls.Add(this.label18);
            this.grpReturnPacket.Controls.Add(this.label17);
            this.grpReturnPacket.Controls.Add(this.label16);
            this.grpReturnPacket.Controls.Add(this.label15);
            this.grpReturnPacket.Controls.Add(this.label14);
            this.grpReturnPacket.Controls.Add(this.label8);
            this.grpReturnPacket.Controls.Add(this.label12);
            this.grpReturnPacket.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.grpReturnPacket.Location = new System.Drawing.Point(12, 190);
            this.grpReturnPacket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReturnPacket.Name = "grpReturnPacket";
            this.grpReturnPacket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReturnPacket.Size = new System.Drawing.Size(182, 241);
            this.grpReturnPacket.TabIndex = 38;
            this.grpReturnPacket.TabStop = false;
            this.grpReturnPacket.Text = "Return Packet";
            // 
            // lblRetgripperAngle
            // 
            this.lblRetgripperAngle.AutoSize = true;
            this.lblRetgripperAngle.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetgripperAngle.Location = new System.Drawing.Point(100, 204);
            this.lblRetgripperAngle.Name = "lblRetgripperAngle";
            this.lblRetgripperAngle.Size = new System.Drawing.Size(11, 17);
            this.lblRetgripperAngle.TabIndex = 45;
            this.lblRetgripperAngle.Text = " ";
            // 
            // lblRetisGrab
            // 
            this.lblRetisGrab.AutoSize = true;
            this.lblRetisGrab.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetisGrab.Location = new System.Drawing.Point(100, 184);
            this.lblRetisGrab.Name = "lblRetisGrab";
            this.lblRetisGrab.Size = new System.Drawing.Size(11, 17);
            this.lblRetisGrab.TabIndex = 44;
            this.lblRetisGrab.Text = " ";
            // 
            // lblRetpawArmAngle
            // 
            this.lblRetpawArmAngle.AutoSize = true;
            this.lblRetpawArmAngle.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetpawArmAngle.Location = new System.Drawing.Point(100, 166);
            this.lblRetpawArmAngle.Name = "lblRetpawArmAngle";
            this.lblRetpawArmAngle.Size = new System.Drawing.Size(11, 17);
            this.lblRetpawArmAngle.TabIndex = 43;
            this.lblRetpawArmAngle.Text = " ";
            // 
            // lblRetshortArmAngle
            // 
            this.lblRetshortArmAngle.AutoSize = true;
            this.lblRetshortArmAngle.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetshortArmAngle.Location = new System.Drawing.Point(100, 147);
            this.lblRetshortArmAngle.Name = "lblRetshortArmAngle";
            this.lblRetshortArmAngle.Size = new System.Drawing.Size(11, 17);
            this.lblRetshortArmAngle.TabIndex = 42;
            this.lblRetshortArmAngle.Text = " ";
            // 
            // lblRetlongArmAngle
            // 
            this.lblRetlongArmAngle.AutoSize = true;
            this.lblRetlongArmAngle.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetlongArmAngle.Location = new System.Drawing.Point(100, 129);
            this.lblRetlongArmAngle.Name = "lblRetlongArmAngle";
            this.lblRetlongArmAngle.Size = new System.Drawing.Size(11, 17);
            this.lblRetlongArmAngle.TabIndex = 41;
            this.lblRetlongArmAngle.Text = " ";
            // 
            // lblRetbaseAngle
            // 
            this.lblRetbaseAngle.AutoSize = true;
            this.lblRetbaseAngle.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetbaseAngle.Location = new System.Drawing.Point(100, 109);
            this.lblRetbaseAngle.Name = "lblRetbaseAngle";
            this.lblRetbaseAngle.Size = new System.Drawing.Size(11, 17);
            this.lblRetbaseAngle.TabIndex = 40;
            this.lblRetbaseAngle.Text = " ";
            // 
            // lblRetrHand
            // 
            this.lblRetrHand.AutoSize = true;
            this.lblRetrHand.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetrHand.Location = new System.Drawing.Point(77, 90);
            this.lblRetrHand.Name = "lblRetrHand";
            this.lblRetrHand.Size = new System.Drawing.Size(11, 17);
            this.lblRetrHand.TabIndex = 39;
            this.lblRetrHand.Text = " ";
            // 
            // lblRetZ
            // 
            this.lblRetZ.AutoSize = true;
            this.lblRetZ.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetZ.Location = new System.Drawing.Point(51, 72);
            this.lblRetZ.Name = "lblRetZ";
            this.lblRetZ.Size = new System.Drawing.Size(11, 17);
            this.lblRetZ.TabIndex = 38;
            this.lblRetZ.Text = " ";
            // 
            // lblRetX
            // 
            this.lblRetX.AutoSize = true;
            this.lblRetX.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetX.Location = new System.Drawing.Point(51, 34);
            this.lblRetX.Name = "lblRetX";
            this.lblRetX.Size = new System.Drawing.Size(11, 17);
            this.lblRetX.TabIndex = 36;
            this.lblRetX.Text = " ";
            // 
            // lblRetY
            // 
            this.lblRetY.AutoSize = true;
            this.lblRetY.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblRetY.Location = new System.Drawing.Point(51, 53);
            this.lblRetY.Name = "lblRetY";
            this.lblRetY.Size = new System.Drawing.Size(11, 17);
            this.lblRetY.TabIndex = 37;
            this.lblRetY.Text = " ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label23.Location = new System.Drawing.Point(3, 204);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "gripperAngle:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label22.Location = new System.Drawing.Point(3, 184);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 17);
            this.label22.TabIndex = 34;
            this.label22.Text = "isGrab:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label21.Location = new System.Drawing.Point(3, 166);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 17);
            this.label21.TabIndex = 33;
            this.label21.Text = "pawArmAngle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label18.Location = new System.Drawing.Point(3, 147);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "shortArmAngle:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label17.Location = new System.Drawing.Point(3, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "longArmAngle:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label16.Location = new System.Drawing.Point(3, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "baseAngle:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label15.Location = new System.Drawing.Point(3, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Rotation:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label14.Location = new System.Drawing.Point(3, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Y:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label31.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label31.Location = new System.Drawing.Point(235, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 17);
            this.label31.TabIndex = 78;
            this.label31.Text = "Float10";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label32.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label32.Location = new System.Drawing.Point(177, 70);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 17);
            this.label32.TabIndex = 77;
            this.label32.Text = "Float9";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label27.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label27.Location = new System.Drawing.Point(119, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 17);
            this.label27.TabIndex = 76;
            this.label27.Text = "Float8";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label28.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label28.Location = new System.Drawing.Point(61, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 17);
            this.label28.TabIndex = 75;
            this.label28.Text = "Float7";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label29.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label29.Location = new System.Drawing.Point(4, 70);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 17);
            this.label29.TabIndex = 74;
            this.label29.Text = "Float6";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label30.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label30.Location = new System.Drawing.Point(235, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 17);
            this.label30.TabIndex = 73;
            this.label30.Text = "Float5";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label25.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label25.Location = new System.Drawing.Point(179, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 17);
            this.label25.TabIndex = 72;
            this.label25.Text = "Float4";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label26.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label26.Location = new System.Drawing.Point(119, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 17);
            this.label26.TabIndex = 71;
            this.label26.Text = "Float3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label24.Location = new System.Drawing.Point(61, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 17);
            this.label24.TabIndex = 70;
            this.label24.Text = "Float2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Float1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(64, 89);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 25);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(122, 89);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(56, 25);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(180, 89);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(56, 25);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(238, 89);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 25);
            this.textBox10.TabIndex = 9;
            this.textBox10.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 89);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 25);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(238, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 25);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 41);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 25);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 25);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 25);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // btnPacketSend
            // 
            this.btnPacketSend.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.btnPacketSend.Location = new System.Drawing.Point(300, 41);
            this.btnPacketSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPacketSend.Name = "btnPacketSend";
            this.btnPacketSend.Size = new System.Drawing.Size(45, 73);
            this.btnPacketSend.TabIndex = 10;
            this.btnPacketSend.Text = "OK";
            this.btnPacketSend.UseVisualStyleBackColor = true;
            this.btnPacketSend.Click += new System.EventHandler(this.btnPacketSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.btnPacketSend);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.groupBox3.Location = new System.Drawing.Point(71, 47);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(351, 122);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Packet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 25);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualDetetectionToolStripMenuItem,
            this.writeAndDrawToolStripMenuItem,
            this.pickUpToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.functionsToolStripMenuItem.Text = "&Functions";
            // 
            // visualDetetectionToolStripMenuItem
            // 
            this.visualDetetectionToolStripMenuItem.Enabled = false;
            this.visualDetetectionToolStripMenuItem.Name = "visualDetetectionToolStripMenuItem";
            this.visualDetetectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualDetetectionToolStripMenuItem.Text = "Visual Detetection";
            this.visualDetetectionToolStripMenuItem.Click += new System.EventHandler(this.visualDetetectionToolStripMenuItem_Click);
            // 
            // writeAndDrawToolStripMenuItem
            // 
            this.writeAndDrawToolStripMenuItem.Enabled = false;
            this.writeAndDrawToolStripMenuItem.Name = "writeAndDrawToolStripMenuItem";
            this.writeAndDrawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeAndDrawToolStripMenuItem.Text = "Write and Draw";
            this.writeAndDrawToolStripMenuItem.Click += new System.EventHandler(this.writeAndDrawToolStripMenuItem_Click);
            // 
            // pickUpToolStripMenuItem
            // 
            this.pickUpToolStripMenuItem.Enabled = false;
            this.pickUpToolStripMenuItem.Name = "pickUpToolStripMenuItem";
            this.pickUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pickUpToolStripMenuItem.Text = "Pick Up";
            this.pickUpToolStripMenuItem.Click += new System.EventHandler(this.pickUpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.linkToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.linkToolStripMenuItem.Text = "Dobot &Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.linkToolStripMenuItem_Click);
            // 
            // tabCtrlMode
            // 
            this.tabCtrlMode.Controls.Add(this.tabTarget);
            this.tabCtrlMode.Controls.Add(this.tabJog);
            this.tabCtrlMode.Controls.Add(this.tabMouse);
            this.tabCtrlMode.Controls.Add(this.tabWriteLaser);
            this.tabCtrlMode.Controls.Add(this.tabPacket);
            this.tabCtrlMode.Enabled = false;
            this.tabCtrlMode.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.tabCtrlMode.Location = new System.Drawing.Point(199, 44);
            this.tabCtrlMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtrlMode.Name = "tabCtrlMode";
            this.tabCtrlMode.SelectedIndex = 0;
            this.tabCtrlMode.Size = new System.Drawing.Size(505, 290);
            this.tabCtrlMode.TabIndex = 79;
            // 
            // tabTarget
            // 
            this.tabTarget.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabTarget.Controls.Add(this.label7);
            this.tabTarget.Controls.Add(this.txtTargetGripper);
            this.tabTarget.Controls.Add(this.label65);
            this.tabTarget.Controls.Add(this.grpTargetLinearMode);
            this.tabTarget.Controls.Add(this.grpTargetJointMode);
            this.tabTarget.Controls.Add(this.chkTargetisGrab);
            this.tabTarget.Controls.Add(this.grpAdvanced);
            this.tabTarget.Controls.Add(this.btnTargetDataSend);
            this.tabTarget.Controls.Add(this.label19);
            this.tabTarget.Controls.Add(this.txtTargetRotation);
            this.tabTarget.Controls.Add(this.label20);
            this.tabTarget.Controls.Add(this.groupBox4);
            this.tabTarget.Controls.Add(this.chkAdvanced);
            this.tabTarget.Location = new System.Drawing.Point(4, 26);
            this.tabTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTarget.Name = "tabTarget";
            this.tabTarget.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTarget.Size = new System.Drawing.Size(497, 260);
            this.tabTarget.TabIndex = 0;
            this.tabTarget.Text = "Target";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label7.Location = new System.Drawing.Point(395, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 119;
            this.label7.Text = "°";
            // 
            // txtTargetGripper
            // 
            this.txtTargetGripper.Enabled = false;
            this.txtTargetGripper.Location = new System.Drawing.Point(354, 41);
            this.txtTargetGripper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetGripper.Name = "txtTargetGripper";
            this.txtTargetGripper.Size = new System.Drawing.Size(36, 25);
            this.txtTargetGripper.TabIndex = 118;
            this.txtTargetGripper.Text = "0";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label65.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label65.Location = new System.Drawing.Point(294, 46);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(55, 17);
            this.label65.TabIndex = 117;
            this.label65.Text = "Gripper:";
            // 
            // grpTargetLinearMode
            // 
            this.grpTargetLinearMode.Controls.Add(this.txtTargetY);
            this.grpTargetLinearMode.Controls.Add(this.label13);
            this.grpTargetLinearMode.Controls.Add(this.txtTargetX);
            this.grpTargetLinearMode.Controls.Add(this.label11);
            this.grpTargetLinearMode.Controls.Add(this.label10);
            this.grpTargetLinearMode.Controls.Add(this.label6);
            this.grpTargetLinearMode.Controls.Add(this.label34);
            this.grpTargetLinearMode.Controls.Add(this.txtTargetZ);
            this.grpTargetLinearMode.Controls.Add(this.label33);
            this.grpTargetLinearMode.Location = new System.Drawing.Point(16, 5);
            this.grpTargetLinearMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTargetLinearMode.Name = "grpTargetLinearMode";
            this.grpTargetLinearMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTargetLinearMode.Size = new System.Drawing.Size(130, 100);
            this.grpTargetLinearMode.TabIndex = 113;
            this.grpTargetLinearMode.TabStop = false;
            this.grpTargetLinearMode.Text = "Linear Mode";
            // 
            // txtTargetY
            // 
            this.txtTargetY.Location = new System.Drawing.Point(32, 46);
            this.txtTargetY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetY.Name = "txtTargetY";
            this.txtTargetY.Size = new System.Drawing.Size(36, 25);
            this.txtTargetY.TabIndex = 87;
            this.txtTargetY.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 17);
            this.label13.TabIndex = 83;
            this.label13.Text = "X:";
            // 
            // txtTargetX
            // 
            this.txtTargetX.Location = new System.Drawing.Point(32, 20);
            this.txtTargetX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetX.Name = "txtTargetX";
            this.txtTargetX.Size = new System.Drawing.Size(36, 25);
            this.txtTargetX.TabIndex = 84;
            this.txtTargetX.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label11.Location = new System.Drawing.Point(74, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 85;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label10.Location = new System.Drawing.Point(8, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label6.Location = new System.Drawing.Point(74, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "mm";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label34.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label34.Location = new System.Drawing.Point(7, 72);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 17);
            this.label34.TabIndex = 89;
            this.label34.Text = "Z:";
            // 
            // txtTargetZ
            // 
            this.txtTargetZ.Location = new System.Drawing.Point(32, 70);
            this.txtTargetZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetZ.Name = "txtTargetZ";
            this.txtTargetZ.Size = new System.Drawing.Size(36, 25);
            this.txtTargetZ.TabIndex = 90;
            this.txtTargetZ.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label33.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label33.Location = new System.Drawing.Point(74, 72);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 17);
            this.label33.TabIndex = 91;
            this.label33.Text = "mm";
            // 
            // grpTargetJointMode
            // 
            this.grpTargetJointMode.Controls.Add(this.txtTargetJoint1);
            this.grpTargetJointMode.Controls.Add(this.label52);
            this.grpTargetJointMode.Controls.Add(this.label51);
            this.grpTargetJointMode.Controls.Add(this.label47);
            this.grpTargetJointMode.Controls.Add(this.label50);
            this.grpTargetJointMode.Controls.Add(this.txtTargetJoint3);
            this.grpTargetJointMode.Controls.Add(this.txtTargetJoint2);
            this.grpTargetJointMode.Controls.Add(this.label48);
            this.grpTargetJointMode.Controls.Add(this.label49);
            this.grpTargetJointMode.Enabled = false;
            this.grpTargetJointMode.Location = new System.Drawing.Point(157, 5);
            this.grpTargetJointMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTargetJointMode.Name = "grpTargetJointMode";
            this.grpTargetJointMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTargetJointMode.Size = new System.Drawing.Size(130, 100);
            this.grpTargetJointMode.TabIndex = 112;
            this.grpTargetJointMode.TabStop = false;
            this.grpTargetJointMode.Text = "Joint Mode";
            // 
            // txtTargetJoint1
            // 
            this.txtTargetJoint1.Location = new System.Drawing.Point(55, 20);
            this.txtTargetJoint1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJoint1.Name = "txtTargetJoint1";
            this.txtTargetJoint1.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJoint1.TabIndex = 98;
            this.txtTargetJoint1.Text = "0";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label52.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label52.Location = new System.Drawing.Point(7, 22);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 17);
            this.label52.TabIndex = 97;
            this.label52.Text = "Joint1:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label51.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label51.Location = new System.Drawing.Point(96, 22);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 17);
            this.label51.TabIndex = 99;
            this.label51.Text = "mm";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label47.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label47.Location = new System.Drawing.Point(96, 72);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(30, 17);
            this.label47.TabIndex = 105;
            this.label47.Text = "mm";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label50.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label50.Location = new System.Drawing.Point(7, 47);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(45, 17);
            this.label50.TabIndex = 100;
            this.label50.Text = "Joint2:";
            // 
            // txtTargetJoint3
            // 
            this.txtTargetJoint3.Location = new System.Drawing.Point(55, 70);
            this.txtTargetJoint3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJoint3.Name = "txtTargetJoint3";
            this.txtTargetJoint3.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJoint3.TabIndex = 104;
            this.txtTargetJoint3.Text = "0";
            // 
            // txtTargetJoint2
            // 
            this.txtTargetJoint2.Location = new System.Drawing.Point(55, 46);
            this.txtTargetJoint2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJoint2.Name = "txtTargetJoint2";
            this.txtTargetJoint2.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJoint2.TabIndex = 101;
            this.txtTargetJoint2.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label48.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label48.Location = new System.Drawing.Point(7, 72);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 17);
            this.label48.TabIndex = 103;
            this.label48.Text = "Joint3:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label49.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label49.Location = new System.Drawing.Point(96, 47);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(30, 17);
            this.label49.TabIndex = 102;
            this.label49.Text = "mm";
            // 
            // chkTargetisGrab
            // 
            this.chkTargetisGrab.AutoSize = true;
            this.chkTargetisGrab.Location = new System.Drawing.Point(314, 84);
            this.chkTargetisGrab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTargetisGrab.Name = "chkTargetisGrab";
            this.chkTargetisGrab.Size = new System.Drawing.Size(66, 21);
            this.chkTargetisGrab.TabIndex = 111;
            this.chkTargetisGrab.Text = "is Grab";
            this.chkTargetisGrab.UseVisualStyleBackColor = true;
            // 
            // grpAdvanced
            // 
            this.grpAdvanced.Controls.Add(this.btnTargetConfigSend);
            this.grpAdvanced.Controls.Add(this.label53);
            this.grpAdvanced.Controls.Add(this.txtTargetMovAccPercent);
            this.grpAdvanced.Controls.Add(this.label54);
            this.grpAdvanced.Controls.Add(this.label55);
            this.grpAdvanced.Controls.Add(this.txtTargetMovSpeedPercent);
            this.grpAdvanced.Controls.Add(this.label56);
            this.grpAdvanced.Controls.Add(this.label35);
            this.grpAdvanced.Controls.Add(this.txtTargetServoAcc);
            this.grpAdvanced.Controls.Add(this.label5);
            this.grpAdvanced.Controls.Add(this.label36);
            this.grpAdvanced.Controls.Add(this.txtTargetPauseTime);
            this.grpAdvanced.Controls.Add(this.label37);
            this.grpAdvanced.Controls.Add(this.label4);
            this.grpAdvanced.Controls.Add(this.txtTargetServoSpeed);
            this.grpAdvanced.Controls.Add(this.label38);
            this.grpAdvanced.Controls.Add(this.label39);
            this.grpAdvanced.Controls.Add(this.label3);
            this.grpAdvanced.Controls.Add(this.txtTargetJointAcc);
            this.grpAdvanced.Controls.Add(this.txtTargetJmpHeight);
            this.grpAdvanced.Controls.Add(this.label40);
            this.grpAdvanced.Controls.Add(this.label1);
            this.grpAdvanced.Controls.Add(this.label41);
            this.grpAdvanced.Controls.Add(this.txtTargetJointSpeed);
            this.grpAdvanced.Controls.Add(this.label42);
            this.grpAdvanced.Controls.Add(this.label43);
            this.grpAdvanced.Controls.Add(this.txtTargetLinearAcc);
            this.grpAdvanced.Controls.Add(this.label44);
            this.grpAdvanced.Controls.Add(this.label45);
            this.grpAdvanced.Controls.Add(this.txtTargetLinearSpeed);
            this.grpAdvanced.Controls.Add(this.label46);
            this.grpAdvanced.Enabled = false;
            this.grpAdvanced.Location = new System.Drawing.Point(96, 106);
            this.grpAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Padding = new System.Windows.Forms.Padding(2);
            this.grpAdvanced.Size = new System.Drawing.Size(396, 149);
            this.grpAdvanced.TabIndex = 95;
            this.grpAdvanced.TabStop = false;
            this.grpAdvanced.Text = "advanced";
            // 
            // btnTargetConfigSend
            // 
            this.btnTargetConfigSend.Location = new System.Drawing.Point(333, 96);
            this.btnTargetConfigSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTargetConfigSend.Name = "btnTargetConfigSend";
            this.btnTargetConfigSend.Size = new System.Drawing.Size(58, 48);
            this.btnTargetConfigSend.TabIndex = 106;
            this.btnTargetConfigSend.Text = "Send";
            this.btnTargetConfigSend.UseVisualStyleBackColor = true;
            this.btnTargetConfigSend.Click += new System.EventHandler(this.btnTargetConfigSend_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label53.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label53.Location = new System.Drawing.Point(296, 122);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(18, 17);
            this.label53.TabIndex = 120;
            this.label53.Text = "%";
            // 
            // txtTargetMovAccPercent
            // 
            this.txtTargetMovAccPercent.Location = new System.Drawing.Point(259, 121);
            this.txtTargetMovAccPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetMovAccPercent.Name = "txtTargetMovAccPercent";
            this.txtTargetMovAccPercent.Size = new System.Drawing.Size(36, 25);
            this.txtTargetMovAccPercent.TabIndex = 119;
            this.txtTargetMovAccPercent.Text = "0";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label54.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label54.Location = new System.Drawing.Point(197, 122);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(60, 17);
            this.label54.TabIndex = 118;
            this.label54.Text = "Mov Acc:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label55.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label55.Location = new System.Drawing.Point(296, 98);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(18, 17);
            this.label55.TabIndex = 117;
            this.label55.Text = "%";
            // 
            // txtTargetMovSpeedPercent
            // 
            this.txtTargetMovSpeedPercent.Location = new System.Drawing.Point(259, 96);
            this.txtTargetMovSpeedPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetMovSpeedPercent.Name = "txtTargetMovSpeedPercent";
            this.txtTargetMovSpeedPercent.Size = new System.Drawing.Size(36, 25);
            this.txtTargetMovSpeedPercent.TabIndex = 116;
            this.txtTargetMovSpeedPercent.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label56.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label56.Location = new System.Drawing.Point(182, 98);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(74, 17);
            this.label56.TabIndex = 115;
            this.label56.Text = "Mov Speed:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label35.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label35.Location = new System.Drawing.Point(140, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 17);
            this.label35.TabIndex = 114;
            this.label35.Text = "°/s²";
            // 
            // txtTargetServoAcc
            // 
            this.txtTargetServoAcc.Location = new System.Drawing.Point(103, 96);
            this.txtTargetServoAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetServoAcc.Name = "txtTargetServoAcc";
            this.txtTargetServoAcc.Size = new System.Drawing.Size(36, 25);
            this.txtTargetServoAcc.TabIndex = 113;
            this.txtTargetServoAcc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label5.Location = new System.Drawing.Point(300, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "s";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label36.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label36.Location = new System.Drawing.Point(35, 98);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(66, 17);
            this.label36.TabIndex = 112;
            this.label36.Text = "Servo Acc:";
            // 
            // txtTargetPauseTime
            // 
            this.txtTargetPauseTime.Location = new System.Drawing.Point(259, 46);
            this.txtTargetPauseTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetPauseTime.Name = "txtTargetPauseTime";
            this.txtTargetPauseTime.Size = new System.Drawing.Size(36, 25);
            this.txtTargetPauseTime.TabIndex = 79;
            this.txtTargetPauseTime.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label37.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label37.Location = new System.Drawing.Point(140, 74);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 17);
            this.label37.TabIndex = 111;
            this.label37.Text = "°/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label4.Location = new System.Drawing.Point(181, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "PauseTime:";
            // 
            // txtTargetServoSpeed
            // 
            this.txtTargetServoSpeed.Location = new System.Drawing.Point(103, 71);
            this.txtTargetServoSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetServoSpeed.Name = "txtTargetServoSpeed";
            this.txtTargetServoSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtTargetServoSpeed.TabIndex = 110;
            this.txtTargetServoSpeed.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label38.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label38.Location = new System.Drawing.Point(20, 73);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(80, 17);
            this.label38.TabIndex = 109;
            this.label38.Text = "Servo Speed:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label39.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label39.Location = new System.Drawing.Point(140, 49);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 17);
            this.label39.TabIndex = 108;
            this.label39.Text = "°/s²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label3.Location = new System.Drawing.Point(300, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "mm";
            // 
            // txtTargetJointAcc
            // 
            this.txtTargetJointAcc.Location = new System.Drawing.Point(103, 47);
            this.txtTargetJointAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJointAcc.Name = "txtTargetJointAcc";
            this.txtTargetJointAcc.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJointAcc.TabIndex = 107;
            this.txtTargetJointAcc.Text = "0";
            // 
            // txtTargetJmpHeight
            // 
            this.txtTargetJmpHeight.Location = new System.Drawing.Point(259, 22);
            this.txtTargetJmpHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJmpHeight.Name = "txtTargetJmpHeight";
            this.txtTargetJmpHeight.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJmpHeight.TabIndex = 71;
            this.txtTargetJmpHeight.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label40.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label40.Location = new System.Drawing.Point(39, 49);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(61, 17);
            this.label40.TabIndex = 106;
            this.label40.Text = "Joint Acc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label1.Location = new System.Drawing.Point(169, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "JUMP Height:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label41.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label41.Location = new System.Drawing.Point(140, 24);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(23, 17);
            this.label41.TabIndex = 105;
            this.label41.Text = "°/s";
            // 
            // txtTargetJointSpeed
            // 
            this.txtTargetJointSpeed.Location = new System.Drawing.Point(103, 22);
            this.txtTargetJointSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetJointSpeed.Name = "txtTargetJointSpeed";
            this.txtTargetJointSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtTargetJointSpeed.TabIndex = 104;
            this.txtTargetJointSpeed.Text = "0";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label42.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label42.Location = new System.Drawing.Point(24, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 17);
            this.label42.TabIndex = 103;
            this.label42.Text = "Joint Speed:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label43.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label43.Location = new System.Drawing.Point(296, 74);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(45, 17);
            this.label43.TabIndex = 102;
            this.label43.Text = "mm/s²";
            // 
            // txtTargetLinearAcc
            // 
            this.txtTargetLinearAcc.Location = new System.Drawing.Point(259, 71);
            this.txtTargetLinearAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetLinearAcc.Name = "txtTargetLinearAcc";
            this.txtTargetLinearAcc.Size = new System.Drawing.Size(36, 25);
            this.txtTargetLinearAcc.TabIndex = 101;
            this.txtTargetLinearAcc.Text = "0";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label44.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label44.Location = new System.Drawing.Point(187, 74);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(70, 17);
            this.label44.TabIndex = 100;
            this.label44.Text = "Linear Acc:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label45.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label45.Location = new System.Drawing.Point(140, 122);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 17);
            this.label45.TabIndex = 99;
            this.label45.Text = "mm/s";
            // 
            // txtTargetLinearSpeed
            // 
            this.txtTargetLinearSpeed.Location = new System.Drawing.Point(103, 121);
            this.txtTargetLinearSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetLinearSpeed.Name = "txtTargetLinearSpeed";
            this.txtTargetLinearSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtTargetLinearSpeed.TabIndex = 98;
            this.txtTargetLinearSpeed.Text = "0";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label46.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label46.Location = new System.Drawing.Point(17, 122);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(84, 17);
            this.label46.TabIndex = 97;
            this.label46.Text = "Linear Speed:";
            // 
            // btnTargetDataSend
            // 
            this.btnTargetDataSend.Location = new System.Drawing.Point(11, 110);
            this.btnTargetDataSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTargetDataSend.Name = "btnTargetDataSend";
            this.btnTargetDataSend.Size = new System.Drawing.Size(80, 29);
            this.btnTargetDataSend.TabIndex = 107;
            this.btnTargetDataSend.Text = "Send";
            this.btnTargetDataSend.UseVisualStyleBackColor = true;
            this.btnTargetDataSend.Click += new System.EventHandler(this.btnTargetDataSend_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label19.Location = new System.Drawing.Point(395, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 17);
            this.label19.TabIndex = 94;
            this.label19.Text = "°";
            // 
            // txtTargetRotation
            // 
            this.txtTargetRotation.Location = new System.Drawing.Point(354, 17);
            this.txtTargetRotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTargetRotation.Name = "txtTargetRotation";
            this.txtTargetRotation.Size = new System.Drawing.Size(36, 25);
            this.txtTargetRotation.TabIndex = 93;
            this.txtTargetRotation.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label20.Location = new System.Drawing.Point(288, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 92;
            this.label20.Text = "Rotation:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnJump);
            this.groupBox4.Controls.Add(this.rbtnMovl);
            this.groupBox4.Controls.Add(this.rbtnMovj);
            this.groupBox4.Location = new System.Drawing.Point(409, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(83, 100);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MovStyle";
            // 
            // rbtnJump
            // 
            this.rbtnJump.AutoSize = true;
            this.rbtnJump.Checked = true;
            this.rbtnJump.Location = new System.Drawing.Point(14, 24);
            this.rbtnJump.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnJump.Name = "rbtnJump";
            this.rbtnJump.Size = new System.Drawing.Size(58, 21);
            this.rbtnJump.TabIndex = 74;
            this.rbtnJump.TabStop = true;
            this.rbtnJump.Text = "JUMP";
            this.rbtnJump.UseVisualStyleBackColor = true;
            // 
            // rbtnMovl
            // 
            this.rbtnMovl.AutoSize = true;
            this.rbtnMovl.Location = new System.Drawing.Point(14, 59);
            this.rbtnMovl.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMovl.Name = "rbtnMovl";
            this.rbtnMovl.Size = new System.Drawing.Size(61, 21);
            this.rbtnMovl.TabIndex = 76;
            this.rbtnMovl.Text = "MOVL";
            this.rbtnMovl.UseVisualStyleBackColor = true;
            // 
            // rbtnMovj
            // 
            this.rbtnMovj.AutoSize = true;
            this.rbtnMovj.Location = new System.Drawing.Point(14, 41);
            this.rbtnMovj.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMovj.Name = "rbtnMovj";
            this.rbtnMovj.Size = new System.Drawing.Size(58, 21);
            this.rbtnMovj.TabIndex = 75;
            this.rbtnMovj.Text = "MOVJ";
            this.rbtnMovj.UseVisualStyleBackColor = true;
            // 
            // chkAdvanced
            // 
            this.chkAdvanced.AutoSize = true;
            this.chkAdvanced.Location = new System.Drawing.Point(10, 180);
            this.chkAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdvanced.Name = "chkAdvanced";
            this.chkAdvanced.Size = new System.Drawing.Size(81, 21);
            this.chkAdvanced.TabIndex = 96;
            this.chkAdvanced.Text = "advanced";
            this.chkAdvanced.UseVisualStyleBackColor = true;
            this.chkAdvanced.CheckedChanged += new System.EventHandler(this.chkAdvanced_CheckedChanged);
            // 
            // tabJog
            // 
            this.tabJog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabJog.Controls.Add(this.grpJogLaser);
            this.tabJog.Controls.Add(this.grpJogGripper);
            this.tabJog.Controls.Add(this.grpJogGrab);
            this.tabJog.Controls.Add(this.grpJogMode);
            this.tabJog.Controls.Add(this.groupBox1);
            this.tabJog.Location = new System.Drawing.Point(4, 26);
            this.tabJog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabJog.Name = "tabJog";
            this.tabJog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabJog.Size = new System.Drawing.Size(497, 260);
            this.tabJog.TabIndex = 1;
            this.tabJog.Text = "Jog";
            // 
            // grpJogLaser
            // 
            this.grpJogLaser.Controls.Add(this.btnJogLaserOn);
            this.grpJogLaser.Controls.Add(this.btnJogLaserOff);
            this.grpJogLaser.Controls.Add(this.label99);
            this.grpJogLaser.Location = new System.Drawing.Point(156, 181);
            this.grpJogLaser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogLaser.Name = "grpJogLaser";
            this.grpJogLaser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogLaser.Size = new System.Drawing.Size(155, 74);
            this.grpJogLaser.TabIndex = 175;
            this.grpJogLaser.TabStop = false;
            this.grpJogLaser.Text = "Laser";
            // 
            // btnJogLaserOn
            // 
            this.btnJogLaserOn.Location = new System.Drawing.Point(49, 23);
            this.btnJogLaserOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogLaserOn.Name = "btnJogLaserOn";
            this.btnJogLaserOn.Size = new System.Drawing.Size(43, 36);
            this.btnJogLaserOn.TabIndex = 6;
            this.btnJogLaserOn.Text = "ON";
            this.btnJogLaserOn.UseVisualStyleBackColor = true;
            this.btnJogLaserOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogLaserOn_MouseDown);
            this.btnJogLaserOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogLaserOn_MouseUp);
            // 
            // btnJogLaserOff
            // 
            this.btnJogLaserOff.Location = new System.Drawing.Point(98, 23);
            this.btnJogLaserOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogLaserOff.Name = "btnJogLaserOff";
            this.btnJogLaserOff.Size = new System.Drawing.Size(43, 36);
            this.btnJogLaserOff.TabIndex = 7;
            this.btnJogLaserOff.Text = "OFF";
            this.btnJogLaserOff.UseVisualStyleBackColor = true;
            this.btnJogLaserOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogLaserOff_MouseDown);
            this.btnJogLaserOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogLaserOff_MouseUp);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label99.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label99.Location = new System.Drawing.Point(6, 34);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(42, 17);
            this.label99.TabIndex = 170;
            this.label99.Text = "Laser:";
            // 
            // grpJogGripper
            // 
            this.grpJogGripper.Controls.Add(this.btnJogGripperPlus);
            this.grpJogGripper.Controls.Add(this.btnJogGripperMinus);
            this.grpJogGripper.Controls.Add(this.label100);
            this.grpJogGripper.Location = new System.Drawing.Point(156, 94);
            this.grpJogGripper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogGripper.Name = "grpJogGripper";
            this.grpJogGripper.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogGripper.Size = new System.Drawing.Size(155, 74);
            this.grpJogGripper.TabIndex = 174;
            this.grpJogGripper.TabStop = false;
            this.grpJogGripper.Text = "Gripper";
            // 
            // btnJogGripperPlus
            // 
            this.btnJogGripperPlus.Location = new System.Drawing.Point(50, 23);
            this.btnJogGripperPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogGripperPlus.Name = "btnJogGripperPlus";
            this.btnJogGripperPlus.Size = new System.Drawing.Size(43, 36);
            this.btnJogGripperPlus.TabIndex = 4;
            this.btnJogGripperPlus.Text = "+";
            this.btnJogGripperPlus.UseVisualStyleBackColor = true;
            this.btnJogGripperPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogGripperPlus_MouseDown);
            this.btnJogGripperPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogGripperPlus_MouseUp);
            // 
            // btnJogGripperMinus
            // 
            this.btnJogGripperMinus.Location = new System.Drawing.Point(99, 23);
            this.btnJogGripperMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogGripperMinus.Name = "btnJogGripperMinus";
            this.btnJogGripperMinus.Size = new System.Drawing.Size(43, 36);
            this.btnJogGripperMinus.TabIndex = 5;
            this.btnJogGripperMinus.Text = "-";
            this.btnJogGripperMinus.UseVisualStyleBackColor = true;
            this.btnJogGripperMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogGripperMinus_MouseDown);
            this.btnJogGripperMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogGripperMinus_MouseUp);
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label100.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label100.Location = new System.Drawing.Point(1, 34);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(55, 17);
            this.label100.TabIndex = 169;
            this.label100.Text = "Gripper:";
            // 
            // grpJogGrab
            // 
            this.grpJogGrab.Controls.Add(this.btnJogGrabOn);
            this.grpJogGrab.Controls.Add(this.btnJogGrabOff);
            this.grpJogGrab.Controls.Add(this.label101);
            this.grpJogGrab.Location = new System.Drawing.Point(156, 5);
            this.grpJogGrab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogGrab.Name = "grpJogGrab";
            this.grpJogGrab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogGrab.Size = new System.Drawing.Size(155, 74);
            this.grpJogGrab.TabIndex = 173;
            this.grpJogGrab.TabStop = false;
            this.grpJogGrab.Text = "Grab";
            // 
            // btnJogGrabOn
            // 
            this.btnJogGrabOn.Location = new System.Drawing.Point(50, 22);
            this.btnJogGrabOn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogGrabOn.Name = "btnJogGrabOn";
            this.btnJogGrabOn.Size = new System.Drawing.Size(43, 36);
            this.btnJogGrabOn.TabIndex = 2;
            this.btnJogGrabOn.Text = "ON";
            this.btnJogGrabOn.UseVisualStyleBackColor = true;
            this.btnJogGrabOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogGrabOn_MouseDown);
            this.btnJogGrabOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogGrabOn_MouseUp);
            // 
            // btnJogGrabOff
            // 
            this.btnJogGrabOff.Location = new System.Drawing.Point(99, 22);
            this.btnJogGrabOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogGrabOff.Name = "btnJogGrabOff";
            this.btnJogGrabOff.Size = new System.Drawing.Size(43, 36);
            this.btnJogGrabOff.TabIndex = 3;
            this.btnJogGrabOff.Text = "OFF";
            this.btnJogGrabOff.UseVisualStyleBackColor = true;
            this.btnJogGrabOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogGrabOff_MouseDown);
            this.btnJogGrabOff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogGrabOff_MouseUp);
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label101.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label101.Location = new System.Drawing.Point(4, 34);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(40, 17);
            this.label101.TabIndex = 168;
            this.label101.Text = "Grab:";
            // 
            // grpJogMode
            // 
            this.grpJogMode.Controls.Add(this.btnJogYMinus);
            this.grpJogMode.Controls.Add(this.btnJogXPlus);
            this.grpJogMode.Controls.Add(this.btnJogXMinus);
            this.grpJogMode.Controls.Add(this.btnJogYPlus);
            this.grpJogMode.Controls.Add(this.label102);
            this.grpJogMode.Controls.Add(this.btnJogZPlus);
            this.grpJogMode.Controls.Add(this.btnJogZMinus);
            this.grpJogMode.Controls.Add(this.lblJogX);
            this.grpJogMode.Controls.Add(this.lblJogY);
            this.grpJogMode.Controls.Add(this.lblJogZ);
            this.grpJogMode.Controls.Add(this.btnJogRPlus);
            this.grpJogMode.Controls.Add(this.btnJogRMinus);
            this.grpJogMode.Location = new System.Drawing.Point(6, 5);
            this.grpJogMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogMode.Name = "grpJogMode";
            this.grpJogMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpJogMode.Size = new System.Drawing.Size(144, 250);
            this.grpJogMode.TabIndex = 172;
            this.grpJogMode.TabStop = false;
            this.grpJogMode.Text = "Linear Mode";
            // 
            // btnJogYMinus
            // 
            this.btnJogYMinus.Location = new System.Drawing.Point(84, 85);
            this.btnJogYMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogYMinus.Name = "btnJogYMinus";
            this.btnJogYMinus.Size = new System.Drawing.Size(43, 36);
            this.btnJogYMinus.TabIndex = 3;
            this.btnJogYMinus.Text = "-";
            this.btnJogYMinus.UseVisualStyleBackColor = true;
            this.btnJogYMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogYMinus_MouseDown);
            this.btnJogYMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogYMinus_MouseUp);
            // 
            // btnJogXPlus
            // 
            this.btnJogXPlus.Location = new System.Drawing.Point(35, 41);
            this.btnJogXPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogXPlus.Name = "btnJogXPlus";
            this.btnJogXPlus.Size = new System.Drawing.Size(43, 36);
            this.btnJogXPlus.TabIndex = 141;
            this.btnJogXPlus.Text = "+";
            this.btnJogXPlus.UseVisualStyleBackColor = true;
            this.btnJogXPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXPlus_MouseDown);
            this.btnJogXPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXPlus_MouseUp);
            // 
            // btnJogXMinus
            // 
            this.btnJogXMinus.Location = new System.Drawing.Point(84, 41);
            this.btnJogXMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogXMinus.Name = "btnJogXMinus";
            this.btnJogXMinus.Size = new System.Drawing.Size(43, 36);
            this.btnJogXMinus.TabIndex = 1;
            this.btnJogXMinus.Text = "-";
            this.btnJogXMinus.UseVisualStyleBackColor = true;
            this.btnJogXMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogXMinus_MouseDown);
            this.btnJogXMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogXMinus_MouseUp);
            // 
            // btnJogYPlus
            // 
            this.btnJogYPlus.Location = new System.Drawing.Point(35, 85);
            this.btnJogYPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogYPlus.Name = "btnJogYPlus";
            this.btnJogYPlus.Size = new System.Drawing.Size(43, 36);
            this.btnJogYPlus.TabIndex = 143;
            this.btnJogYPlus.Text = "+";
            this.btnJogYPlus.UseVisualStyleBackColor = true;
            this.btnJogYPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogYPlus_MouseDown);
            this.btnJogYPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogYPlus_MouseUp);
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label102.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label102.Location = new System.Drawing.Point(7, 181);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(20, 17);
            this.label102.TabIndex = 167;
            this.label102.Text = "R:";
            // 
            // btnJogZPlus
            // 
            this.btnJogZPlus.Location = new System.Drawing.Point(35, 128);
            this.btnJogZPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogZPlus.Name = "btnJogZPlus";
            this.btnJogZPlus.Size = new System.Drawing.Size(43, 36);
            this.btnJogZPlus.TabIndex = 145;
            this.btnJogZPlus.Text = "+";
            this.btnJogZPlus.UseVisualStyleBackColor = true;
            this.btnJogZPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZPlus_MouseDown);
            this.btnJogZPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogZPlus_MouseUp);
            // 
            // btnJogZMinus
            // 
            this.btnJogZMinus.Location = new System.Drawing.Point(84, 128);
            this.btnJogZMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogZMinus.Name = "btnJogZMinus";
            this.btnJogZMinus.Size = new System.Drawing.Size(43, 36);
            this.btnJogZMinus.TabIndex = 5;
            this.btnJogZMinus.Text = "-";
            this.btnJogZMinus.UseVisualStyleBackColor = true;
            this.btnJogZMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogZMinus_MouseDown);
            this.btnJogZMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogZMinus_MouseUp);
            // 
            // lblJogX
            // 
            this.lblJogX.AutoSize = true;
            this.lblJogX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJogX.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblJogX.Location = new System.Drawing.Point(8, 52);
            this.lblJogX.Name = "lblJogX";
            this.lblJogX.Size = new System.Drawing.Size(19, 17);
            this.lblJogX.TabIndex = 0;
            this.lblJogX.Text = "X:";
            // 
            // lblJogY
            // 
            this.lblJogY.AutoSize = true;
            this.lblJogY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJogY.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblJogY.Location = new System.Drawing.Point(9, 95);
            this.lblJogY.Name = "lblJogY";
            this.lblJogY.Size = new System.Drawing.Size(18, 17);
            this.lblJogY.TabIndex = 2;
            this.lblJogY.Text = "Y:";
            // 
            // lblJogZ
            // 
            this.lblJogZ.AutoSize = true;
            this.lblJogZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblJogZ.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblJogZ.Location = new System.Drawing.Point(8, 137);
            this.lblJogZ.Name = "lblJogZ";
            this.lblJogZ.Size = new System.Drawing.Size(19, 17);
            this.lblJogZ.TabIndex = 4;
            this.lblJogZ.Text = "Z:";
            // 
            // btnJogRPlus
            // 
            this.btnJogRPlus.Location = new System.Drawing.Point(35, 170);
            this.btnJogRPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogRPlus.Name = "btnJogRPlus";
            this.btnJogRPlus.Size = new System.Drawing.Size(43, 36);
            this.btnJogRPlus.TabIndex = 0;
            this.btnJogRPlus.Text = "+";
            this.btnJogRPlus.UseVisualStyleBackColor = true;
            this.btnJogRPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogRPlus_MouseDown);
            this.btnJogRPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogRPlus_MouseUp);
            // 
            // btnJogRMinus
            // 
            this.btnJogRMinus.Location = new System.Drawing.Point(84, 170);
            this.btnJogRMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogRMinus.Name = "btnJogRMinus";
            this.btnJogRMinus.Size = new System.Drawing.Size(43, 36);
            this.btnJogRMinus.TabIndex = 1;
            this.btnJogRMinus.Text = "-";
            this.btnJogRMinus.UseVisualStyleBackColor = true;
            this.btnJogRMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogRMinus_MouseDown);
            this.btnJogRMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogRMinus_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJogConfigSend);
            this.groupBox1.Controls.Add(this.txtJog_ServoAcc);
            this.groupBox1.Controls.Add(this.label81);
            this.groupBox1.Controls.Add(this.label77);
            this.groupBox1.Controls.Add(this.txtJog_MaxSpeedPercent);
            this.groupBox1.Controls.Add(this.label82);
            this.groupBox1.Controls.Add(this.label80);
            this.groupBox1.Controls.Add(this.label83);
            this.groupBox1.Controls.Add(this.label92);
            this.groupBox1.Controls.Add(this.txtJog_ServoSpeed);
            this.groupBox1.Controls.Add(this.txtJog_LinearSpeed);
            this.groupBox1.Controls.Add(this.label84);
            this.groupBox1.Controls.Add(this.label91);
            this.groupBox1.Controls.Add(this.label85);
            this.groupBox1.Controls.Add(this.label90);
            this.groupBox1.Controls.Add(this.txtJog_JointAcc);
            this.groupBox1.Controls.Add(this.txtJog_LinearAcc);
            this.groupBox1.Controls.Add(this.label86);
            this.groupBox1.Controls.Add(this.label89);
            this.groupBox1.Controls.Add(this.label87);
            this.groupBox1.Controls.Add(this.label88);
            this.groupBox1.Controls.Add(this.txtJog_JointSpeed);
            this.groupBox1.Location = new System.Drawing.Point(318, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 250);
            this.groupBox1.TabIndex = 140;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jog Advanced Config";
            // 
            // btnJogConfigSend
            // 
            this.btnJogConfigSend.Location = new System.Drawing.Point(7, 216);
            this.btnJogConfigSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJogConfigSend.Name = "btnJogConfigSend";
            this.btnJogConfigSend.Size = new System.Drawing.Size(77, 26);
            this.btnJogConfigSend.TabIndex = 7;
            this.btnJogConfigSend.Text = "Send";
            this.btnJogConfigSend.UseVisualStyleBackColor = true;
            this.btnJogConfigSend.Click += new System.EventHandler(this.btnJogConfigSend_Click);
            // 
            // txtJog_ServoAcc
            // 
            this.txtJog_ServoAcc.Location = new System.Drawing.Point(90, 134);
            this.txtJog_ServoAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_ServoAcc.Name = "txtJog_ServoAcc";
            this.txtJog_ServoAcc.Size = new System.Drawing.Size(36, 25);
            this.txtJog_ServoAcc.TabIndex = 4;
            this.txtJog_ServoAcc.Text = "0";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label81.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label81.Location = new System.Drawing.Point(127, 137);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(28, 17);
            this.label81.TabIndex = 139;
            this.label81.Text = "°/s²";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(6, 24);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(74, 17);
            this.label77.TabIndex = 0;
            this.label77.Text = "Max Speed:";
            // 
            // txtJog_MaxSpeedPercent
            // 
            this.txtJog_MaxSpeedPercent.Location = new System.Drawing.Point(90, 20);
            this.txtJog_MaxSpeedPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_MaxSpeedPercent.Name = "txtJog_MaxSpeedPercent";
            this.txtJog_MaxSpeedPercent.Size = new System.Drawing.Size(36, 25);
            this.txtJog_MaxSpeedPercent.TabIndex = 0;
            this.txtJog_MaxSpeedPercent.Text = "0";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label82.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label82.Location = new System.Drawing.Point(6, 137);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(66, 17);
            this.label82.TabIndex = 137;
            this.label82.Text = "Servo Acc:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label80.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label80.Location = new System.Drawing.Point(127, 23);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(18, 17);
            this.label80.TabIndex = 121;
            this.label80.Text = "%";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label83.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label83.Location = new System.Drawing.Point(127, 109);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(23, 17);
            this.label83.TabIndex = 136;
            this.label83.Text = "°/s";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label92.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label92.Location = new System.Drawing.Point(6, 167);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(84, 17);
            this.label92.TabIndex = 122;
            this.label92.Text = "Linear Speed:";
            // 
            // txtJog_ServoSpeed
            // 
            this.txtJog_ServoSpeed.Location = new System.Drawing.Point(90, 106);
            this.txtJog_ServoSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_ServoSpeed.Name = "txtJog_ServoSpeed";
            this.txtJog_ServoSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtJog_ServoSpeed.TabIndex = 3;
            this.txtJog_ServoSpeed.Text = "0";
            // 
            // txtJog_LinearSpeed
            // 
            this.txtJog_LinearSpeed.Location = new System.Drawing.Point(90, 164);
            this.txtJog_LinearSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_LinearSpeed.Name = "txtJog_LinearSpeed";
            this.txtJog_LinearSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtJog_LinearSpeed.TabIndex = 5;
            this.txtJog_LinearSpeed.Text = "0";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label84.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label84.Location = new System.Drawing.Point(6, 109);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(80, 17);
            this.label84.TabIndex = 134;
            this.label84.Text = "Servo Speed:";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label91.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label91.Location = new System.Drawing.Point(127, 166);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(40, 17);
            this.label91.TabIndex = 124;
            this.label91.Text = "mm/s";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label85.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label85.Location = new System.Drawing.Point(127, 80);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(28, 17);
            this.label85.TabIndex = 133;
            this.label85.Text = "°/s²";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label90.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label90.Location = new System.Drawing.Point(6, 196);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(70, 17);
            this.label90.TabIndex = 125;
            this.label90.Text = "Linear Acc:";
            // 
            // txtJog_JointAcc
            // 
            this.txtJog_JointAcc.Location = new System.Drawing.Point(90, 77);
            this.txtJog_JointAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_JointAcc.Name = "txtJog_JointAcc";
            this.txtJog_JointAcc.Size = new System.Drawing.Size(36, 25);
            this.txtJog_JointAcc.TabIndex = 2;
            this.txtJog_JointAcc.Text = "0";
            // 
            // txtJog_LinearAcc
            // 
            this.txtJog_LinearAcc.Location = new System.Drawing.Point(90, 192);
            this.txtJog_LinearAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_LinearAcc.Name = "txtJog_LinearAcc";
            this.txtJog_LinearAcc.Size = new System.Drawing.Size(36, 25);
            this.txtJog_LinearAcc.TabIndex = 6;
            this.txtJog_LinearAcc.Text = "0";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label86.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label86.Location = new System.Drawing.Point(6, 82);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(61, 17);
            this.label86.TabIndex = 131;
            this.label86.Text = "Joint Acc:";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label89.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label89.Location = new System.Drawing.Point(127, 194);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(45, 17);
            this.label89.TabIndex = 127;
            this.label89.Text = "mm/s²";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label87.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label87.Location = new System.Drawing.Point(127, 50);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(23, 17);
            this.label87.TabIndex = 130;
            this.label87.Text = "°/s";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label88.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label88.Location = new System.Drawing.Point(6, 52);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(75, 17);
            this.label88.TabIndex = 128;
            this.label88.Text = "Joint Speed:";
            // 
            // txtJog_JointSpeed
            // 
            this.txtJog_JointSpeed.Location = new System.Drawing.Point(90, 49);
            this.txtJog_JointSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJog_JointSpeed.Name = "txtJog_JointSpeed";
            this.txtJog_JointSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtJog_JointSpeed.TabIndex = 1;
            this.txtJog_JointSpeed.Text = "0";
            // 
            // tabMouse
            // 
            this.tabMouse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabMouse.Controls.Add(this.chkMouseisGrab);
            this.tabMouse.Controls.Add(this.btnMouseSend);
            this.tabMouse.Controls.Add(this.label57);
            this.tabMouse.Controls.Add(this.txtMouseRotation);
            this.tabMouse.Controls.Add(this.label58);
            this.tabMouse.Controls.Add(this.label59);
            this.tabMouse.Controls.Add(this.txtMousedz);
            this.tabMouse.Controls.Add(this.label60);
            this.tabMouse.Controls.Add(this.label61);
            this.tabMouse.Controls.Add(this.txtMousedy);
            this.tabMouse.Controls.Add(this.label62);
            this.tabMouse.Controls.Add(this.label63);
            this.tabMouse.Controls.Add(this.txtMousedx);
            this.tabMouse.Controls.Add(this.label64);
            this.tabMouse.Location = new System.Drawing.Point(4, 26);
            this.tabMouse.Margin = new System.Windows.Forms.Padding(2);
            this.tabMouse.Name = "tabMouse";
            this.tabMouse.Size = new System.Drawing.Size(497, 260);
            this.tabMouse.TabIndex = 3;
            this.tabMouse.Text = "relative Move";
            // 
            // chkMouseisGrab
            // 
            this.chkMouseisGrab.AutoSize = true;
            this.chkMouseisGrab.Location = new System.Drawing.Point(226, 161);
            this.chkMouseisGrab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMouseisGrab.Name = "chkMouseisGrab";
            this.chkMouseisGrab.Size = new System.Drawing.Size(66, 21);
            this.chkMouseisGrab.TabIndex = 110;
            this.chkMouseisGrab.Text = "is Grab";
            this.chkMouseisGrab.UseVisualStyleBackColor = true;
            // 
            // btnMouseSend
            // 
            this.btnMouseSend.Location = new System.Drawing.Point(326, 109);
            this.btnMouseSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMouseSend.Name = "btnMouseSend";
            this.btnMouseSend.Size = new System.Drawing.Size(68, 73);
            this.btnMouseSend.TabIndex = 109;
            this.btnMouseSend.Text = "Send";
            this.btnMouseSend.UseVisualStyleBackColor = true;
            this.btnMouseSend.Click += new System.EventHandler(this.btnRelativeMoveSend_Click);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label57.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label57.Location = new System.Drawing.Point(279, 125);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(13, 17);
            this.label57.TabIndex = 108;
            this.label57.Text = "°";
            // 
            // txtMouseRotation
            // 
            this.txtMouseRotation.Location = new System.Drawing.Point(238, 125);
            this.txtMouseRotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMouseRotation.Name = "txtMouseRotation";
            this.txtMouseRotation.Size = new System.Drawing.Size(36, 25);
            this.txtMouseRotation.TabIndex = 107;
            this.txtMouseRotation.Text = "0";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label58.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label58.Location = new System.Drawing.Point(172, 127);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(61, 17);
            this.label58.TabIndex = 106;
            this.label58.Text = "Rotation:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label59.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label59.Location = new System.Drawing.Point(279, 92);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(30, 17);
            this.label59.TabIndex = 105;
            this.label59.Text = "mm";
            // 
            // txtMousedz
            // 
            this.txtMousedz.Location = new System.Drawing.Point(237, 92);
            this.txtMousedz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMousedz.Name = "txtMousedz";
            this.txtMousedz.Size = new System.Drawing.Size(36, 25);
            this.txtMousedz.TabIndex = 104;
            this.txtMousedz.Text = "0";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label60.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label60.Location = new System.Drawing.Point(206, 94);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(26, 17);
            this.label60.TabIndex = 103;
            this.label60.Text = "dZ:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label61.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label61.Location = new System.Drawing.Point(279, 61);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(30, 17);
            this.label61.TabIndex = 102;
            this.label61.Text = "mm";
            // 
            // txtMousedy
            // 
            this.txtMousedy.Location = new System.Drawing.Point(237, 59);
            this.txtMousedy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMousedy.Name = "txtMousedy";
            this.txtMousedy.Size = new System.Drawing.Size(36, 25);
            this.txtMousedy.TabIndex = 101;
            this.txtMousedy.Text = "0";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label62.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label62.Location = new System.Drawing.Point(207, 61);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(25, 17);
            this.label62.TabIndex = 100;
            this.label62.Text = "dY:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label63.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label63.Location = new System.Drawing.Point(279, 29);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(30, 17);
            this.label63.TabIndex = 99;
            this.label63.Text = "mm";
            // 
            // txtMousedx
            // 
            this.txtMousedx.Location = new System.Drawing.Point(237, 26);
            this.txtMousedx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMousedx.Name = "txtMousedx";
            this.txtMousedx.Size = new System.Drawing.Size(36, 25);
            this.txtMousedx.TabIndex = 98;
            this.txtMousedx.Text = "0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label64.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label64.Location = new System.Drawing.Point(205, 29);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(26, 17);
            this.label64.TabIndex = 97;
            this.label64.Text = "dX:";
            // 
            // tabWriteLaser
            // 
            this.tabWriteLaser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabWriteLaser.Controls.Add(this.grpWLWritingOrLaser);
            this.tabWriteLaser.Controls.Add(this.btnWriteLaserSend);
            this.tabWriteLaser.Controls.Add(this.label76);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserWritingAcc);
            this.tabWriteLaser.Controls.Add(this.labelx);
            this.tabWriteLaser.Controls.Add(this.label78);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserMaxSpeed);
            this.tabWriteLaser.Controls.Add(this.label79);
            this.tabWriteLaser.Controls.Add(this.label72);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserFinalSpeed);
            this.tabWriteLaser.Controls.Add(this.label73);
            this.tabWriteLaser.Controls.Add(this.label74);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserInitSpeed);
            this.tabWriteLaser.Controls.Add(this.label75);
            this.tabWriteLaser.Controls.Add(this.label66);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserdz);
            this.tabWriteLaser.Controls.Add(this.label67);
            this.tabWriteLaser.Controls.Add(this.label68);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserdy);
            this.tabWriteLaser.Controls.Add(this.label69);
            this.tabWriteLaser.Controls.Add(this.label70);
            this.tabWriteLaser.Controls.Add(this.txtWriteLaserdx);
            this.tabWriteLaser.Controls.Add(this.label71);
            this.tabWriteLaser.Location = new System.Drawing.Point(4, 26);
            this.tabWriteLaser.Margin = new System.Windows.Forms.Padding(2);
            this.tabWriteLaser.Name = "tabWriteLaser";
            this.tabWriteLaser.Size = new System.Drawing.Size(497, 260);
            this.tabWriteLaser.TabIndex = 4;
            this.tabWriteLaser.Text = "Write & Laser";
            // 
            // grpWLWritingOrLaser
            // 
            this.grpWLWritingOrLaser.Controls.Add(this.rbtnWLLaser);
            this.grpWLWritingOrLaser.Controls.Add(this.rbtnWLWriting);
            this.grpWLWritingOrLaser.Controls.Add(this.chkWLLaserOn);
            this.grpWLWritingOrLaser.Enabled = false;
            this.grpWLWritingOrLaser.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.grpWLWritingOrLaser.Location = new System.Drawing.Point(15, 7);
            this.grpWLWritingOrLaser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpWLWritingOrLaser.Name = "grpWLWritingOrLaser";
            this.grpWLWritingOrLaser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpWLWritingOrLaser.Size = new System.Drawing.Size(129, 94);
            this.grpWLWritingOrLaser.TabIndex = 129;
            this.grpWLWritingOrLaser.TabStop = false;
            this.grpWLWritingOrLaser.Text = "Writing or Laser";
            // 
            // rbtnWLLaser
            // 
            this.rbtnWLLaser.AutoSize = true;
            this.rbtnWLLaser.Location = new System.Drawing.Point(12, 44);
            this.rbtnWLLaser.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnWLLaser.Name = "rbtnWLLaser";
            this.rbtnWLLaser.Size = new System.Drawing.Size(56, 21);
            this.rbtnWLLaser.TabIndex = 107;
            this.rbtnWLLaser.Text = "Laser";
            this.rbtnWLLaser.UseVisualStyleBackColor = true;
            this.rbtnWLLaser.CheckedChanged += new System.EventHandler(this.rbtnWLLaser_CheckedChanged);
            // 
            // rbtnWLWriting
            // 
            this.rbtnWLWriting.AutoSize = true;
            this.rbtnWLWriting.Checked = true;
            this.rbtnWLWriting.Location = new System.Drawing.Point(12, 23);
            this.rbtnWLWriting.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnWLWriting.Name = "rbtnWLWriting";
            this.rbtnWLWriting.Size = new System.Drawing.Size(68, 21);
            this.rbtnWLWriting.TabIndex = 106;
            this.rbtnWLWriting.TabStop = true;
            this.rbtnWLWriting.Text = "Writing";
            this.rbtnWLWriting.UseVisualStyleBackColor = true;
            // 
            // chkWLLaserOn
            // 
            this.chkWLLaserOn.AutoSize = true;
            this.chkWLLaserOn.Enabled = false;
            this.chkWLLaserOn.Location = new System.Drawing.Point(12, 65);
            this.chkWLLaserOn.Margin = new System.Windows.Forms.Padding(2);
            this.chkWLLaserOn.Name = "chkWLLaserOn";
            this.chkWLLaserOn.Size = new System.Drawing.Size(76, 21);
            this.chkWLLaserOn.TabIndex = 115;
            this.chkWLLaserOn.Text = "Laser On";
            this.chkWLLaserOn.UseVisualStyleBackColor = true;
            this.chkWLLaserOn.CheckedChanged += new System.EventHandler(this.chkWLLaserOn_CheckedChanged);
            // 
            // btnWriteLaserSend
            // 
            this.btnWriteLaserSend.Location = new System.Drawing.Point(381, 100);
            this.btnWriteLaserSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWriteLaserSend.Name = "btnWriteLaserSend";
            this.btnWriteLaserSend.Size = new System.Drawing.Size(54, 98);
            this.btnWriteLaserSend.TabIndex = 128;
            this.btnWriteLaserSend.Text = "Send";
            this.btnWriteLaserSend.UseVisualStyleBackColor = true;
            this.btnWriteLaserSend.Click += new System.EventHandler(this.btnWriteLaserSend_Click);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label76.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label76.Location = new System.Drawing.Point(304, 178);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(45, 17);
            this.label76.TabIndex = 127;
            this.label76.Text = "mm/s²";
            // 
            // txtWriteLaserWritingAcc
            // 
            this.txtWriteLaserWritingAcc.Location = new System.Drawing.Point(266, 176);
            this.txtWriteLaserWritingAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserWritingAcc.Name = "txtWriteLaserWritingAcc";
            this.txtWriteLaserWritingAcc.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserWritingAcc.TabIndex = 126;
            this.txtWriteLaserWritingAcc.Text = "0";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelx.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.labelx.Location = new System.Drawing.Point(180, 178);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(77, 17);
            this.labelx.TabIndex = 125;
            this.labelx.Text = "Writing Acc:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label78.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label78.Location = new System.Drawing.Point(304, 154);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(40, 17);
            this.label78.TabIndex = 124;
            this.label78.Text = "mm/s";
            // 
            // txtWriteLaserMaxSpeed
            // 
            this.txtWriteLaserMaxSpeed.Location = new System.Drawing.Point(266, 149);
            this.txtWriteLaserMaxSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserMaxSpeed.Name = "txtWriteLaserMaxSpeed";
            this.txtWriteLaserMaxSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserMaxSpeed.TabIndex = 123;
            this.txtWriteLaserMaxSpeed.Text = "0";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label79.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label79.Location = new System.Drawing.Point(180, 154);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(74, 17);
            this.label79.TabIndex = 122;
            this.label79.Text = "Max Speed:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label72.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label72.Location = new System.Drawing.Point(304, 128);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(40, 17);
            this.label72.TabIndex = 121;
            this.label72.Text = "mm/s";
            // 
            // txtWriteLaserFinalSpeed
            // 
            this.txtWriteLaserFinalSpeed.Location = new System.Drawing.Point(266, 125);
            this.txtWriteLaserFinalSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserFinalSpeed.Name = "txtWriteLaserFinalSpeed";
            this.txtWriteLaserFinalSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserFinalSpeed.TabIndex = 120;
            this.txtWriteLaserFinalSpeed.Text = "0";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label73.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label73.Location = new System.Drawing.Point(180, 128);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(73, 17);
            this.label73.TabIndex = 119;
            this.label73.Text = "final Speed:";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label74.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label74.Location = new System.Drawing.Point(304, 101);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(40, 17);
            this.label74.TabIndex = 118;
            this.label74.Text = "mm/s";
            // 
            // txtWriteLaserInitSpeed
            // 
            this.txtWriteLaserInitSpeed.Location = new System.Drawing.Point(266, 100);
            this.txtWriteLaserInitSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserInitSpeed.Name = "txtWriteLaserInitSpeed";
            this.txtWriteLaserInitSpeed.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserInitSpeed.TabIndex = 117;
            this.txtWriteLaserInitSpeed.Text = "0";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label75.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label75.Location = new System.Drawing.Point(180, 101);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(67, 17);
            this.label75.TabIndex = 116;
            this.label75.Text = "init Speed:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label66.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label66.Location = new System.Drawing.Point(96, 173);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(30, 17);
            this.label66.TabIndex = 114;
            this.label66.Text = "mm";
            // 
            // txtWriteLaserdz
            // 
            this.txtWriteLaserdz.Location = new System.Drawing.Point(54, 173);
            this.txtWriteLaserdz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserdz.Name = "txtWriteLaserdz";
            this.txtWriteLaserdz.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserdz.TabIndex = 113;
            this.txtWriteLaserdz.Text = "0";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label67.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label67.Location = new System.Drawing.Point(23, 175);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(26, 17);
            this.label67.TabIndex = 112;
            this.label67.Text = "dZ:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label68.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label68.Location = new System.Drawing.Point(96, 142);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(30, 17);
            this.label68.TabIndex = 111;
            this.label68.Text = "mm";
            // 
            // txtWriteLaserdy
            // 
            this.txtWriteLaserdy.Location = new System.Drawing.Point(54, 140);
            this.txtWriteLaserdy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserdy.Name = "txtWriteLaserdy";
            this.txtWriteLaserdy.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserdy.TabIndex = 110;
            this.txtWriteLaserdy.Text = "0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label69.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label69.Location = new System.Drawing.Point(24, 142);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(25, 17);
            this.label69.TabIndex = 109;
            this.label69.Text = "dY:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label70.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label70.Location = new System.Drawing.Point(96, 110);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(30, 17);
            this.label70.TabIndex = 108;
            this.label70.Text = "mm";
            // 
            // txtWriteLaserdx
            // 
            this.txtWriteLaserdx.Location = new System.Drawing.Point(54, 107);
            this.txtWriteLaserdx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriteLaserdx.Name = "txtWriteLaserdx";
            this.txtWriteLaserdx.Size = new System.Drawing.Size(36, 25);
            this.txtWriteLaserdx.TabIndex = 107;
            this.txtWriteLaserdx.Text = "0";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label71.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.label71.Location = new System.Drawing.Point(22, 110);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(26, 17);
            this.label71.TabIndex = 106;
            this.label71.Text = "dX:";
            // 
            // tabPacket
            // 
            this.tabPacket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPacket.Controls.Add(this.groupBox3);
            this.tabPacket.Location = new System.Drawing.Point(4, 26);
            this.tabPacket.Margin = new System.Windows.Forms.Padding(2);
            this.tabPacket.Name = "tabPacket";
            this.tabPacket.Size = new System.Drawing.Size(497, 260);
            this.tabPacket.TabIndex = 2;
            this.tabPacket.Text = "Packet";
            // 
            // rbtnJoint
            // 
            this.rbtnJoint.AutoSize = true;
            this.rbtnJoint.Location = new System.Drawing.Point(14, 44);
            this.rbtnJoint.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnJoint.Name = "rbtnJoint";
            this.rbtnJoint.Size = new System.Drawing.Size(52, 21);
            this.rbtnJoint.TabIndex = 107;
            this.rbtnJoint.Text = "Joint";
            this.rbtnJoint.UseVisualStyleBackColor = true;
            this.rbtnJoint.CheckedChanged += new System.EventHandler(this.rbtnJoint_CheckedChanged);
            // 
            // rbtnLinear
            // 
            this.rbtnLinear.AutoSize = true;
            this.rbtnLinear.Checked = true;
            this.rbtnLinear.Location = new System.Drawing.Point(14, 22);
            this.rbtnLinear.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnLinear.Name = "rbtnLinear";
            this.rbtnLinear.Size = new System.Drawing.Size(61, 21);
            this.rbtnLinear.TabIndex = 106;
            this.rbtnLinear.TabStop = true;
            this.rbtnLinear.Text = "Linear";
            this.rbtnLinear.UseVisualStyleBackColor = true;
            this.rbtnLinear.CheckedChanged += new System.EventHandler(this.rbtnLinear_CheckedChanged);
            // 
            // grpEndEffctor
            // 
            this.grpEndEffctor.Controls.Add(this.rbtnGrab);
            this.grpEndEffctor.Controls.Add(this.rbtnLaser);
            this.grpEndEffctor.Controls.Add(this.rbtnGripper);
            this.grpEndEffctor.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.grpEndEffctor.Location = new System.Drawing.Point(203, 337);
            this.grpEndEffctor.Margin = new System.Windows.Forms.Padding(2);
            this.grpEndEffctor.Name = "grpEndEffctor";
            this.grpEndEffctor.Padding = new System.Windows.Forms.Padding(2);
            this.grpEndEffctor.Size = new System.Drawing.Size(116, 94);
            this.grpEndEffctor.TabIndex = 80;
            this.grpEndEffctor.TabStop = false;
            this.grpEndEffctor.Text = "end Effector";
            // 
            // rbtnGrab
            // 
            this.rbtnGrab.AutoSize = true;
            this.rbtnGrab.Checked = true;
            this.rbtnGrab.Location = new System.Drawing.Point(15, 22);
            this.rbtnGrab.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnGrab.Name = "rbtnGrab";
            this.rbtnGrab.Size = new System.Drawing.Size(54, 21);
            this.rbtnGrab.TabIndex = 74;
            this.rbtnGrab.TabStop = true;
            this.rbtnGrab.Text = "Grab";
            this.rbtnGrab.UseVisualStyleBackColor = true;
            this.rbtnGrab.CheckedChanged += new System.EventHandler(this.rbtnGrab_CheckedChanged);
            // 
            // rbtnLaser
            // 
            this.rbtnLaser.AutoSize = true;
            this.rbtnLaser.Location = new System.Drawing.Point(15, 65);
            this.rbtnLaser.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnLaser.Name = "rbtnLaser";
            this.rbtnLaser.Size = new System.Drawing.Size(56, 21);
            this.rbtnLaser.TabIndex = 76;
            this.rbtnLaser.Text = "Laser";
            this.rbtnLaser.UseVisualStyleBackColor = true;
            this.rbtnLaser.CheckedChanged += new System.EventHandler(this.rbtnLaser_CheckedChanged);
            // 
            // rbtnGripper
            // 
            this.rbtnGripper.AutoSize = true;
            this.rbtnGripper.Location = new System.Drawing.Point(15, 44);
            this.rbtnGripper.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnGripper.Name = "rbtnGripper";
            this.rbtnGripper.Size = new System.Drawing.Size(69, 21);
            this.rbtnGripper.TabIndex = 75;
            this.rbtnGripper.Text = "Gripper";
            this.rbtnGripper.UseVisualStyleBackColor = true;
            this.rbtnGripper.CheckedChanged += new System.EventHandler(this.rbtnGripper_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnJoint);
            this.groupBox2.Controls.Add(this.rbtnLinear);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.groupBox2.Location = new System.Drawing.Point(386, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(116, 94);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linear or Joint";
            // 
            // lblOriginZ
            // 
            this.lblOriginZ.AutoSize = true;
            this.lblOriginZ.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblOriginZ.Location = new System.Drawing.Point(3, 52);
            this.lblOriginZ.Name = "lblOriginZ";
            this.lblOriginZ.Size = new System.Drawing.Size(19, 17);
            this.lblOriginZ.TabIndex = 113;
            this.lblOriginZ.Text = "Z:";
            // 
            // lblOriginX
            // 
            this.lblOriginX.AutoSize = true;
            this.lblOriginX.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblOriginX.Location = new System.Drawing.Point(3, 14);
            this.lblOriginX.Name = "lblOriginX";
            this.lblOriginX.Size = new System.Drawing.Size(19, 17);
            this.lblOriginX.TabIndex = 111;
            this.lblOriginX.Text = "X:";
            // 
            // lblOriginY
            // 
            this.lblOriginY.AutoSize = true;
            this.lblOriginY.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblOriginY.Location = new System.Drawing.Point(3, 33);
            this.lblOriginY.Name = "lblOriginY";
            this.lblOriginY.Size = new System.Drawing.Size(18, 17);
            this.lblOriginY.TabIndex = 112;
            this.lblOriginY.Text = "Y:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(84, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 26);
            this.btnReset.TabIndex = 114;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblOriginX);
            this.groupBox5.Controls.Add(this.lblOriginY);
            this.groupBox5.Controls.Add(this.btnReset);
            this.groupBox5.Controls.Add(this.lblOriginZ);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.groupBox5.Location = new System.Drawing.Point(565, 337);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(141, 94);
            this.groupBox5.TabIndex = 116;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Linear or Joint";
            // 
            // frmDobot
            // 
            this.AcceptButton = this.btOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(706, 439);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEndEffctor);
            this.Controls.Add(this.tabCtrlMode);
            this.Controls.Add(this.grpReturnPacket);
            this.Controls.Add(this.grpPortSettings);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDobot";
            this.Text = "Dobot V2.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDobot_FormClosing);
            this.Load += new System.EventHandler(this.frmDobot_Load);
            this.grpPortSettings.ResumeLayout(false);
            this.grpPortSettings.PerformLayout();
            this.grpReturnPacket.ResumeLayout(false);
            this.grpReturnPacket.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrlMode.ResumeLayout(false);
            this.tabTarget.ResumeLayout(false);
            this.tabTarget.PerformLayout();
            this.grpTargetLinearMode.ResumeLayout(false);
            this.grpTargetLinearMode.PerformLayout();
            this.grpTargetJointMode.ResumeLayout(false);
            this.grpTargetJointMode.PerformLayout();
            this.grpAdvanced.ResumeLayout(false);
            this.grpAdvanced.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabJog.ResumeLayout(false);
            this.grpJogLaser.ResumeLayout(false);
            this.grpJogLaser.PerformLayout();
            this.grpJogGripper.ResumeLayout(false);
            this.grpJogGripper.PerformLayout();
            this.grpJogGrab.ResumeLayout(false);
            this.grpJogGrab.PerformLayout();
            this.grpJogMode.ResumeLayout(false);
            this.grpJogMode.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMouse.ResumeLayout(false);
            this.tabMouse.PerformLayout();
            this.tabWriteLaser.ResumeLayout(false);
            this.tabWriteLaser.PerformLayout();
            this.grpWLWritingOrLaser.ResumeLayout(false);
            this.grpWLWritingOrLaser.PerformLayout();
            this.tabPacket.ResumeLayout(false);
            this.grpEndEffctor.ResumeLayout(false);
            this.grpEndEffctor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grpPortSettings;
        private System.Windows.Forms.ComboBox cmPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBaudRate;
        private System.Windows.Forms.Label comPort;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox grpReturnPacket;
        private System.Windows.Forms.Label lblRetgripperAngle;
        private System.Windows.Forms.Label lblRetisGrab;
        private System.Windows.Forms.Label lblRetpawArmAngle;
        private System.Windows.Forms.Label lblRetshortArmAngle;
        private System.Windows.Forms.Label lblRetlongArmAngle;
        private System.Windows.Forms.Label lblRetbaseAngle;
        private System.Windows.Forms.Label lblRetrHand;
        private System.Windows.Forms.Label lblRetZ;
        private System.Windows.Forms.Label lblRetX;
        private System.Windows.Forms.Label lblRetY;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPacketSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrlMode;
        private System.Windows.Forms.TabPage tabTarget;
        private System.Windows.Forms.TabPage tabJog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetJmpHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnJump;
        private System.Windows.Forms.RadioButton rbtnMovl;
        private System.Windows.Forms.RadioButton rbtnMovj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTargetPauseTime;
        private System.Windows.Forms.TabPage tabPacket;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTargetRotation;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtTargetZ;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTargetY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTargetX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.CheckBox chkAdvanced;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtTargetServoAcc;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtTargetServoSpeed;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtTargetJointAcc;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtTargetJointSpeed;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtTargetLinearAcc;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtTargetLinearSpeed;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtTargetJoint3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtTargetJoint2;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtTargetJoint1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.RadioButton rbtnJoint;
        private System.Windows.Forms.RadioButton rbtnLinear;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtTargetMovAccPercent;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtTargetMovSpeedPercent;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TabPage tabMouse;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txtMouseRotation;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox txtMousedz;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox txtMousedy;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox txtMousedx;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabPage tabWriteLaser;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox txtWriteLaserdz;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtWriteLaserdy;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox txtWriteLaserdx;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.CheckBox chkWLLaserOn;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox txtWriteLaserWritingAcc;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox txtWriteLaserMaxSpeed;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox txtWriteLaserFinalSpeed;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox txtWriteLaserInitSpeed;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.GroupBox grpEndEffctor;
        private System.Windows.Forms.RadioButton rbtnGrab;
        private System.Windows.Forms.RadioButton rbtnLaser;
        private System.Windows.Forms.RadioButton rbtnGripper;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox txtJog_MaxSpeedPercent;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox txtJog_ServoAcc;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox txtJog_ServoSpeed;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox txtJog_JointAcc;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.TextBox txtJog_JointSpeed;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.TextBox txtJog_LinearAcc;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox txtJog_LinearSpeed;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblJogZ;
        private System.Windows.Forms.Label lblJogY;
        private System.Windows.Forms.Label lblJogX;
        private System.Windows.Forms.Button btnJogZMinus;
        private System.Windows.Forms.Button btnJogZPlus;
        private System.Windows.Forms.Button btnJogYMinus;
        private System.Windows.Forms.Button btnJogYPlus;
        private System.Windows.Forms.Button btnJogXMinus;
        private System.Windows.Forms.Button btnJogXPlus;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Button btnJogLaserOff;
        private System.Windows.Forms.Button btnJogLaserOn;
        private System.Windows.Forms.Button btnJogGripperMinus;
        private System.Windows.Forms.Button btnJogGripperPlus;
        private System.Windows.Forms.Button btnJogGrabOff;
        private System.Windows.Forms.Button btnJogGrabOn;
        private System.Windows.Forms.Button btnJogRMinus;
        private System.Windows.Forms.Button btnJogRPlus;
        private System.Windows.Forms.Button btnTargetDataSend;
        private System.Windows.Forms.Button btnTargetConfigSend;
        private System.Windows.Forms.Button btnMouseSend;
        private System.Windows.Forms.Button btnWriteLaserSend;
        private System.Windows.Forms.CheckBox chkMouseisGrab;
        private System.Windows.Forms.CheckBox chkTargetisGrab;
        private System.Windows.Forms.GroupBox grpTargetJointMode;
        private System.Windows.Forms.GroupBox grpTargetLinearMode;
        private System.Windows.Forms.GroupBox grpJogMode;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox txtTargetGripper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpWLWritingOrLaser;
        private System.Windows.Forms.RadioButton rbtnWLLaser;
        private System.Windows.Forms.RadioButton rbtnWLWriting;
        private System.Windows.Forms.Button btnJogConfigSend;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpJogLaser;
        private System.Windows.Forms.GroupBox grpJogGripper;
        private System.Windows.Forms.GroupBox grpJogGrab;
        private System.Windows.Forms.Label lblOriginZ;
        private System.Windows.Forms.Label lblOriginX;
        private System.Windows.Forms.Label lblOriginY;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeAndDrawToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem visualDetetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem;
    }
}

