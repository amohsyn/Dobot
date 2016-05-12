namespace Dobot
{
    partial class frmVisualDetection
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
            ReleaseData();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualDetection));
            this.ibx1 = new Emgu.CV.UI.ImageBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrealY = new System.Windows.Forms.Label();
            this.lblrealX = new System.Windows.Forms.Label();
            this.btnGrab = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsendY = new System.Windows.Forms.Label();
            this.lblsendX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTracking = new System.Windows.Forms.Button();
            this.rbtnGrabMode = new System.Windows.Forms.RadioButton();
            this.rbtnTrackMode = new System.Windows.Forms.RadioButton();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.trbSendDataDeadZone = new System.Windows.Forms.TrackBar();
            this.lblDeadZone = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblJogMaxAcc = new System.Windows.Forms.Label();
            this.trbJogMaxAcc = new System.Windows.Forms.TrackBar();
            this.lblJogMaxSpeed = new System.Windows.Forms.Label();
            this.trbJogMaxSpeed = new System.Windows.Forms.TrackBar();
            this.lblPIDKd = new System.Windows.Forms.Label();
            this.lblKd_JogSpeed = new System.Windows.Forms.Label();
            this.trbKd_JogSpeed = new System.Windows.Forms.TrackBar();
            this.lblK_JogSpeed = new System.Windows.Forms.Label();
            this.trbK_JogSpeed = new System.Windows.Forms.TrackBar();
            this.lblJogDeadzone = new System.Windows.Forms.Label();
            this.trbJogDeadzone = new System.Windows.Forms.TrackBar();
            this.imageBox11 = new Emgu.CV.UI.ImageBox();
            this.imageBox10 = new Emgu.CV.UI.ImageBox();
            this.imageBox9 = new Emgu.CV.UI.ImageBox();
            this.lblPIDKi = new System.Windows.Forms.Label();
            this.trbPIDKi = new System.Windows.Forms.TrackBar();
            this.lblPIDKp = new System.Windows.Forms.Label();
            this.trbPIDKd = new System.Windows.Forms.TrackBar();
            this.trbPIDKp = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageBox7 = new Emgu.CV.UI.ImageBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.lblHueHist = new System.Windows.Forms.Label();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imageBox8 = new Emgu.CV.UI.ImageBox();
            this.trbMinSat = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMinSat = new System.Windows.Forms.Label();
            this.tabAlgorithm = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ibx1)).BeginInit();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSendDataDeadZone)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogMaxAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbKd_JogSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbK_JogSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogDeadzone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKp)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibx1
            // 
            this.ibx1.Location = new System.Drawing.Point(9, 4);
            this.ibx1.Name = "ibx1";
            this.ibx1.Size = new System.Drawing.Size(480, 360);
            this.ibx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibx1.TabIndex = 2;
            this.ibx1.TabStop = false;
            this.ibx1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ibx1_MouseMove);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCamera.Location = new System.Drawing.Point(388, 375);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(101, 76);
            this.btnOpenCamera.TabIndex = 3;
            this.btnOpenCamera.Text = "Open";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "5";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblX.Location = new System.Drawing.Point(148, 317);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(68, 14);
            this.lblX.TabIndex = 8;
            this.lblX.Text = "Detected X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblY.Location = new System.Drawing.Point(148, 340);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(67, 14);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Detected Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(36, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "imageY↓:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(36, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "imageX→:";
            // 
            // lblrealY
            // 
            this.lblrealY.AutoSize = true;
            this.lblrealY.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblrealY.Location = new System.Drawing.Point(271, 340);
            this.lblrealY.Name = "lblrealY";
            this.lblrealY.Size = new System.Drawing.Size(49, 14);
            this.lblrealY.TabIndex = 13;
            this.lblrealY.Text = "realY→:";
            // 
            // lblrealX
            // 
            this.lblrealX.AutoSize = true;
            this.lblrealX.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblrealX.Location = new System.Drawing.Point(271, 317);
            this.lblrealX.Name = "lblrealX";
            this.lblrealX.Size = new System.Drawing.Size(49, 14);
            this.lblrealX.TabIndex = 12;
            this.lblrealX.Text = "realX↓:";
            // 
            // btnGrab
            // 
            this.btnGrab.Enabled = false;
            this.btnGrab.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnGrab.Location = new System.Drawing.Point(127, 430);
            this.btnGrab.Name = "btnGrab";
            this.btnGrab.Size = new System.Drawing.Size(98, 23);
            this.btnGrab.TabIndex = 14;
            this.btnGrab.Text = "Grab";
            this.btnGrab.UseVisualStyleBackColor = true;
            this.btnGrab.Click += new System.EventHandler(this.btnGrab_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(7, 430);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 21);
            this.txtHeight.TabIndex = 15;
            this.txtHeight.Text = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(7, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Height:";
            // 
            // lblsendY
            // 
            this.lblsendY.AutoSize = true;
            this.lblsendY.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblsendY.Location = new System.Drawing.Point(378, 340);
            this.lblsendY.Name = "lblsendY";
            this.lblsendY.Size = new System.Drawing.Size(54, 14);
            this.lblsendY.TabIndex = 18;
            this.lblsendY.Text = "sendY→:";
            // 
            // lblsendX
            // 
            this.lblsendX.AutoSize = true;
            this.lblsendX.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblsendX.Location = new System.Drawing.Point(378, 317);
            this.lblsendX.Name = "lblsendX";
            this.lblsendX.Size = new System.Drawing.Size(54, 14);
            this.lblsendX.TabIndex = 17;
            this.lblsendX.Text = "sendX↓:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F);
            this.label4.Location = new System.Drawing.Point(7, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "MedianBlur ksize";
            // 
            // btnTracking
            // 
            this.btnTracking.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnTracking.Location = new System.Drawing.Point(247, 430);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(98, 23);
            this.btnTracking.TabIndex = 20;
            this.btnTracking.Text = "Start Tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // rbtnGrabMode
            // 
            this.rbtnGrabMode.AutoSize = true;
            this.rbtnGrabMode.Font = new System.Drawing.Font("Calibri", 9F);
            this.rbtnGrabMode.Location = new System.Drawing.Point(10, 15);
            this.rbtnGrabMode.Name = "rbtnGrabMode";
            this.rbtnGrabMode.Size = new System.Drawing.Size(85, 18);
            this.rbtnGrabMode.TabIndex = 23;
            this.rbtnGrabMode.Text = "Grab Mode";
            this.rbtnGrabMode.UseVisualStyleBackColor = true;
            // 
            // rbtnTrackMode
            // 
            this.rbtnTrackMode.AutoSize = true;
            this.rbtnTrackMode.Checked = true;
            this.rbtnTrackMode.Location = new System.Drawing.Point(101, 15);
            this.rbtnTrackMode.Name = "rbtnTrackMode";
            this.rbtnTrackMode.Size = new System.Drawing.Size(86, 18);
            this.rbtnTrackMode.TabIndex = 24;
            this.rbtnTrackMode.TabStop = true;
            this.rbtnTrackMode.Text = "Track Mode";
            this.rbtnTrackMode.UseVisualStyleBackColor = true;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.rbtnGrabMode);
            this.grpMode.Controls.Add(this.rbtnTrackMode);
            this.grpMode.Enabled = false;
            this.grpMode.Font = new System.Drawing.Font("Calibri", 9F);
            this.grpMode.Location = new System.Drawing.Point(0, 452);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(193, 39);
            this.grpMode.TabIndex = 25;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode ";
            // 
            // trbSendDataDeadZone
            // 
            this.trbSendDataDeadZone.Location = new System.Drawing.Point(120, 384);
            this.trbSendDataDeadZone.Maximum = 100;
            this.trbSendDataDeadZone.Name = "trbSendDataDeadZone";
            this.trbSendDataDeadZone.Size = new System.Drawing.Size(246, 45);
            this.trbSendDataDeadZone.TabIndex = 30;
            this.trbSendDataDeadZone.Value = 80;
            this.trbSendDataDeadZone.Scroll += new System.EventHandler(this.trbSendDataDeadZone_Scroll);
            // 
            // lblDeadZone
            // 
            this.lblDeadZone.AutoSize = true;
            this.lblDeadZone.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDeadZone.Location = new System.Drawing.Point(124, 369);
            this.lblDeadZone.Name = "lblDeadZone";
            this.lblDeadZone.Size = new System.Drawing.Size(128, 14);
            this.lblDeadZone.TabIndex = 31;
            this.lblDeadZone.Text = "Send Data DeadZone: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.lblJogMaxAcc);
            this.tabPage2.Controls.Add(this.trbJogMaxAcc);
            this.tabPage2.Controls.Add(this.lblJogMaxSpeed);
            this.tabPage2.Controls.Add(this.trbJogMaxSpeed);
            this.tabPage2.Controls.Add(this.lblPIDKd);
            this.tabPage2.Controls.Add(this.lblKd_JogSpeed);
            this.tabPage2.Controls.Add(this.trbKd_JogSpeed);
            this.tabPage2.Controls.Add(this.lblK_JogSpeed);
            this.tabPage2.Controls.Add(this.trbK_JogSpeed);
            this.tabPage2.Controls.Add(this.lblJogDeadzone);
            this.tabPage2.Controls.Add(this.trbJogDeadzone);
            this.tabPage2.Controls.Add(this.imageBox11);
            this.tabPage2.Controls.Add(this.imageBox10);
            this.tabPage2.Controls.Add(this.imageBox9);
            this.tabPage2.Controls.Add(this.lblPIDKi);
            this.tabPage2.Controls.Add(this.trbPIDKi);
            this.tabPage2.Controls.Add(this.lblPIDKp);
            this.tabPage2.Controls.Add(this.trbPIDKd);
            this.tabPage2.Controls.Add(this.trbPIDKp);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(500, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PID";
            // 
            // lblJogMaxAcc
            // 
            this.lblJogMaxAcc.AutoSize = true;
            this.lblJogMaxAcc.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblJogMaxAcc.Location = new System.Drawing.Point(258, 213);
            this.lblJogMaxAcc.Name = "lblJogMaxAcc";
            this.lblJogMaxAcc.Size = new System.Drawing.Size(72, 14);
            this.lblJogMaxAcc.TabIndex = 48;
            this.lblJogMaxAcc.Text = "Jog Max Acc:";
            // 
            // trbJogMaxAcc
            // 
            this.trbJogMaxAcc.Location = new System.Drawing.Point(245, 233);
            this.trbJogMaxAcc.Maximum = 600;
            this.trbJogMaxAcc.Name = "trbJogMaxAcc";
            this.trbJogMaxAcc.Size = new System.Drawing.Size(246, 45);
            this.trbJogMaxAcc.TabIndex = 47;
            this.trbJogMaxAcc.Value = 270;
            this.trbJogMaxAcc.Scroll += new System.EventHandler(this.trbJogMaxAcc_Scroll);
            // 
            // lblJogMaxSpeed
            // 
            this.lblJogMaxSpeed.AutoSize = true;
            this.lblJogMaxSpeed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblJogMaxSpeed.Location = new System.Drawing.Point(258, 165);
            this.lblJogMaxSpeed.Name = "lblJogMaxSpeed";
            this.lblJogMaxSpeed.Size = new System.Drawing.Size(89, 14);
            this.lblJogMaxSpeed.TabIndex = 46;
            this.lblJogMaxSpeed.Text = "Jog Max Speed:";
            // 
            // trbJogMaxSpeed
            // 
            this.trbJogMaxSpeed.Location = new System.Drawing.Point(245, 182);
            this.trbJogMaxSpeed.Maximum = 600;
            this.trbJogMaxSpeed.Name = "trbJogMaxSpeed";
            this.trbJogMaxSpeed.Size = new System.Drawing.Size(246, 45);
            this.trbJogMaxSpeed.TabIndex = 45;
            this.trbJogMaxSpeed.Value = 370;
            this.trbJogMaxSpeed.Scroll += new System.EventHandler(this.trbJogMaxSpeed_Scroll);
            // 
            // lblPIDKd
            // 
            this.lblPIDKd.AutoSize = true;
            this.lblPIDKd.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPIDKd.Location = new System.Drawing.Point(16, 114);
            this.lblPIDKd.Name = "lblPIDKd";
            this.lblPIDKd.Size = new System.Drawing.Size(23, 14);
            this.lblPIDKd.TabIndex = 34;
            this.lblPIDKd.Text = "Kd:";
            // 
            // lblKd_JogSpeed
            // 
            this.lblKd_JogSpeed.AutoSize = true;
            this.lblKd_JogSpeed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblKd_JogSpeed.Location = new System.Drawing.Point(258, 111);
            this.lblKd_JogSpeed.Name = "lblKd_JogSpeed";
            this.lblKd_JogSpeed.Size = new System.Drawing.Size(77, 14);
            this.lblKd_JogSpeed.TabIndex = 44;
            this.lblKd_JogSpeed.Text = "Kd JogSpeed:";
            // 
            // trbKd_JogSpeed
            // 
            this.trbKd_JogSpeed.Location = new System.Drawing.Point(245, 131);
            this.trbKd_JogSpeed.Maximum = 10000;
            this.trbKd_JogSpeed.Name = "trbKd_JogSpeed";
            this.trbKd_JogSpeed.Size = new System.Drawing.Size(246, 45);
            this.trbKd_JogSpeed.TabIndex = 43;
            this.trbKd_JogSpeed.Value = 1826;
            this.trbKd_JogSpeed.Scroll += new System.EventHandler(this.trbKd_JogSpeed_Scroll);
            // 
            // lblK_JogSpeed
            // 
            this.lblK_JogSpeed.AutoSize = true;
            this.lblK_JogSpeed.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblK_JogSpeed.Location = new System.Drawing.Point(258, 63);
            this.lblK_JogSpeed.Name = "lblK_JogSpeed";
            this.lblK_JogSpeed.Size = new System.Drawing.Size(70, 14);
            this.lblK_JogSpeed.TabIndex = 42;
            this.lblK_JogSpeed.Text = "K JogSpeed:";
            // 
            // trbK_JogSpeed
            // 
            this.trbK_JogSpeed.Location = new System.Drawing.Point(245, 80);
            this.trbK_JogSpeed.Maximum = 10000;
            this.trbK_JogSpeed.Name = "trbK_JogSpeed";
            this.trbK_JogSpeed.Size = new System.Drawing.Size(246, 45);
            this.trbK_JogSpeed.TabIndex = 41;
            this.trbK_JogSpeed.Value = 1416;
            this.trbK_JogSpeed.Scroll += new System.EventHandler(this.trbK_JogSpeed_Scroll);
            // 
            // lblJogDeadzone
            // 
            this.lblJogDeadzone.AutoSize = true;
            this.lblJogDeadzone.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblJogDeadzone.Location = new System.Drawing.Point(258, 12);
            this.lblJogDeadzone.Name = "lblJogDeadzone";
            this.lblJogDeadzone.Size = new System.Drawing.Size(85, 14);
            this.lblJogDeadzone.TabIndex = 40;
            this.lblJogDeadzone.Text = "Jog Deadzone:";
            // 
            // trbJogDeadzone
            // 
            this.trbJogDeadzone.Location = new System.Drawing.Point(245, 29);
            this.trbJogDeadzone.Maximum = 100;
            this.trbJogDeadzone.Name = "trbJogDeadzone";
            this.trbJogDeadzone.Size = new System.Drawing.Size(246, 45);
            this.trbJogDeadzone.TabIndex = 39;
            this.trbJogDeadzone.Value = 15;
            this.trbJogDeadzone.Scroll += new System.EventHandler(this.trbJogDeadzone_Scroll);
            // 
            // imageBox11
            // 
            this.imageBox11.Location = new System.Drawing.Point(15, 302);
            this.imageBox11.Name = "imageBox11";
            this.imageBox11.Size = new System.Drawing.Size(103, 100);
            this.imageBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox11.TabIndex = 38;
            this.imageBox11.TabStop = false;
            // 
            // imageBox10
            // 
            this.imageBox10.Location = new System.Drawing.Point(124, 192);
            this.imageBox10.Name = "imageBox10";
            this.imageBox10.Size = new System.Drawing.Size(103, 100);
            this.imageBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox10.TabIndex = 37;
            this.imageBox10.TabStop = false;
            // 
            // imageBox9
            // 
            this.imageBox9.Location = new System.Drawing.Point(15, 192);
            this.imageBox9.Name = "imageBox9";
            this.imageBox9.Size = new System.Drawing.Size(103, 100);
            this.imageBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox9.TabIndex = 2;
            this.imageBox9.TabStop = false;
            // 
            // lblPIDKi
            // 
            this.lblPIDKi.AutoSize = true;
            this.lblPIDKi.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPIDKi.Location = new System.Drawing.Point(16, 63);
            this.lblPIDKi.Name = "lblPIDKi";
            this.lblPIDKi.Size = new System.Drawing.Size(20, 14);
            this.lblPIDKi.TabIndex = 36;
            this.lblPIDKi.Text = "Ki:";
            // 
            // trbPIDKi
            // 
            this.trbPIDKi.Location = new System.Drawing.Point(6, 80);
            this.trbPIDKi.Maximum = 2000;
            this.trbPIDKi.Name = "trbPIDKi";
            this.trbPIDKi.Size = new System.Drawing.Size(246, 45);
            this.trbPIDKi.TabIndex = 35;
            this.trbPIDKi.Scroll += new System.EventHandler(this.trbPIDKi_Scroll);
            // 
            // lblPIDKp
            // 
            this.lblPIDKp.AutoSize = true;
            this.lblPIDKp.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPIDKp.Location = new System.Drawing.Point(16, 12);
            this.lblPIDKp.Name = "lblPIDKp";
            this.lblPIDKp.Size = new System.Drawing.Size(23, 14);
            this.lblPIDKp.TabIndex = 33;
            this.lblPIDKp.Text = "Kp:";
            // 
            // trbPIDKd
            // 
            this.trbPIDKd.Location = new System.Drawing.Point(6, 131);
            this.trbPIDKd.Maximum = 2000;
            this.trbPIDKd.Name = "trbPIDKd";
            this.trbPIDKd.Size = new System.Drawing.Size(246, 45);
            this.trbPIDKd.TabIndex = 32;
            this.trbPIDKd.Scroll += new System.EventHandler(this.trbPIDKd_Scroll);
            // 
            // trbPIDKp
            // 
            this.trbPIDKp.Location = new System.Drawing.Point(6, 29);
            this.trbPIDKp.Maximum = 2000;
            this.trbPIDKp.Name = "trbPIDKp";
            this.trbPIDKp.Size = new System.Drawing.Size(246, 45);
            this.trbPIDKp.TabIndex = 31;
            this.trbPIDKp.Value = 1000;
            this.trbPIDKp.Scroll += new System.EventHandler(this.trbPIDKp_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.imageBox7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.trbThreshold);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.imageBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.imageBox2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.imageBox5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.imageBox6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.imageBox3);
            this.tabPage1.Controls.Add(this.lblHueHist);
            this.tabPage1.Controls.Add(this.imageBox4);
            this.tabPage1.Controls.Add(this.lblThreshold);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.imageBox8);
            this.tabPage1.Controls.Add(this.trbMinSat);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblMinSat);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(500, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meanshift";
            // 
            // imageBox7
            // 
            this.imageBox7.Location = new System.Drawing.Point(9, 193);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(240, 180);
            this.imageBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox7.TabIndex = 26;
            this.imageBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F);
            this.label13.Location = new System.Drawing.Point(6, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 14);
            this.label13.TabIndex = 36;
            this.label13.Text = "Binary Image";
            // 
            // trbThreshold
            // 
            this.trbThreshold.Location = new System.Drawing.Point(6, 390);
            this.trbThreshold.Maximum = 255;
            this.trbThreshold.Name = "trbThreshold";
            this.trbThreshold.Size = new System.Drawing.Size(246, 45);
            this.trbThreshold.TabIndex = 4;
            this.trbThreshold.TickFrequency = 5;
            this.trbThreshold.Value = 42;
            this.trbThreshold.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F);
            this.label12.Location = new System.Drawing.Point(252, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 14);
            this.label12.TabIndex = 35;
            this.label12.Text = "Saturation Image";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 390);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(246, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 42;
            this.trackBar1.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Binary Image";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(9, 23);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(300, 150);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F);
            this.label11.Location = new System.Drawing.Point(342, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 14);
            this.label11.TabIndex = 33;
            this.label11.Text = "Feature roundBlock Hue";
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(345, 23);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(150, 150);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 21;
            this.imageBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F);
            this.label7.Location = new System.Drawing.Point(252, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 14);
            this.label7.TabIndex = 35;
            this.label7.Text = "Saturation Image";
            // 
            // imageBox5
            // 
            this.imageBox5.Location = new System.Drawing.Point(9, 23);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(300, 150);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox5.TabIndex = 2;
            this.imageBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9F);
            this.label10.Location = new System.Drawing.Point(9, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 14);
            this.label10.TabIndex = 32;
            this.label10.Text = "Hue Histogram";
            // 
            // imageBox6
            // 
            this.imageBox6.Location = new System.Drawing.Point(345, 23);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(150, 150);
            this.imageBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox6.TabIndex = 21;
            this.imageBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F);
            this.label5.Location = new System.Drawing.Point(342, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 14);
            this.label5.TabIndex = 33;
            this.label5.Text = "Feature roundBlock Hue";
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(9, 193);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(240, 180);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 26;
            this.imageBox3.TabStop = false;
            // 
            // lblHueHist
            // 
            this.lblHueHist.AutoSize = true;
            this.lblHueHist.BackColor = System.Drawing.Color.Transparent;
            this.lblHueHist.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblHueHist.Location = new System.Drawing.Point(9, 6);
            this.lblHueHist.Name = "lblHueHist";
            this.lblHueHist.Size = new System.Drawing.Size(88, 14);
            this.lblHueHist.TabIndex = 32;
            this.lblHueHist.Text = "Hue Histogram";
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(255, 193);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(240, 180);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox4.TabIndex = 27;
            this.imageBox4.TabStop = false;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblThreshold.Location = new System.Drawing.Point(9, 376);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(68, 14);
            this.lblThreshold.TabIndex = 5;
            this.lblThreshold.Text = "Threshold: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F);
            this.label9.Location = new System.Drawing.Point(250, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 14);
            this.label9.TabIndex = 29;
            this.label9.Text = "Minimum Saturation: ";
            // 
            // imageBox8
            // 
            this.imageBox8.Location = new System.Drawing.Point(255, 193);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(240, 180);
            this.imageBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox8.TabIndex = 27;
            this.imageBox8.TabStop = false;
            // 
            // trbMinSat
            // 
            this.trbMinSat.Location = new System.Drawing.Point(246, 390);
            this.trbMinSat.Maximum = 100;
            this.trbMinSat.Name = "trbMinSat";
            this.trbMinSat.Size = new System.Drawing.Size(246, 45);
            this.trbMinSat.TabIndex = 28;
            this.trbMinSat.TickFrequency = 5;
            this.trbMinSat.Scroll += new System.EventHandler(this.lblMinSat_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(246, 390);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(246, 45);
            this.trackBar2.TabIndex = 28;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.lblMinSat_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F);
            this.label8.Location = new System.Drawing.Point(9, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Threshold: ";
            // 
            // lblMinSat
            // 
            this.lblMinSat.AutoSize = true;
            this.lblMinSat.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblMinSat.Location = new System.Drawing.Point(250, 375);
            this.lblMinSat.Name = "lblMinSat";
            this.lblMinSat.Size = new System.Drawing.Size(124, 14);
            this.lblMinSat.TabIndex = 29;
            this.lblMinSat.Text = "Minimum Saturation: ";
            // 
            // tabAlgorithm
            // 
            this.tabAlgorithm.Controls.Add(this.tabPage2);
            this.tabAlgorithm.Controls.Add(this.tabPage1);
            this.tabAlgorithm.Font = new System.Drawing.Font("Calibri", 9F);
            this.tabAlgorithm.Location = new System.Drawing.Point(491, 4);
            this.tabAlgorithm.Name = "tabAlgorithm";
            this.tabAlgorithm.SelectedIndex = 0;
            this.tabAlgorithm.Size = new System.Drawing.Size(508, 471);
            this.tabAlgorithm.TabIndex = 37;
            // 
            // frmVisualDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 487);
            this.Controls.Add(this.tabAlgorithm);
            this.Controls.Add(this.lblDeadZone);
            this.Controls.Add(this.trbSendDataDeadZone);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsendY);
            this.Controls.Add(this.lblsendX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnGrab);
            this.Controls.Add(this.lblrealY);
            this.Controls.Add(this.lblrealX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.ibx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisualDetection";
            this.Text = "Dobot V2.1- Visual Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVisualDetection_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ibx1)).EndInit();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSendDataDeadZone)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogMaxAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbKd_JogSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbK_JogSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbJogDeadzone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPIDKp)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMinSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabAlgorithm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibx1;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrealY;
        private System.Windows.Forms.Label lblrealX;
        private System.Windows.Forms.Button btnGrab;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsendY;
        private System.Windows.Forms.Label lblsendX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.RadioButton rbtnGrabMode;
        private System.Windows.Forms.RadioButton rbtnTrackMode;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.TrackBar trbSendDataDeadZone;
        private System.Windows.Forms.Label lblDeadZone;
        private System.Windows.Forms.TabControl tabAlgorithm;
        private System.Windows.Forms.Label lblMinSat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trbMinSat;
        private Emgu.CV.UI.ImageBox imageBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThreshold;
        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label lblHueHist;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox imageBox6;
        private System.Windows.Forms.Label label10;
        private Emgu.CV.UI.ImageBox imageBox5;
        private System.Windows.Forms.Label label7;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label11;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trbThreshold;
        private System.Windows.Forms.Label label13;
        private Emgu.CV.UI.ImageBox imageBox7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trbPIDKp;
        private System.Windows.Forms.TrackBar trbPIDKd;
        private System.Windows.Forms.Label lblPIDKp;
        private System.Windows.Forms.TrackBar trbPIDKi;
        private System.Windows.Forms.Label lblPIDKi;
        private Emgu.CV.UI.ImageBox imageBox9;
        private Emgu.CV.UI.ImageBox imageBox10;
        private Emgu.CV.UI.ImageBox imageBox11;
        private System.Windows.Forms.TrackBar trbJogDeadzone;
        private System.Windows.Forms.Label lblJogDeadzone;
        private System.Windows.Forms.TrackBar trbK_JogSpeed;
        private System.Windows.Forms.Label lblK_JogSpeed;
        private System.Windows.Forms.TrackBar trbKd_JogSpeed;
        private System.Windows.Forms.Label lblKd_JogSpeed;
        private System.Windows.Forms.Label lblPIDKd;
        private System.Windows.Forms.TrackBar trbJogMaxSpeed;
        private System.Windows.Forms.Label lblJogMaxSpeed;
        private System.Windows.Forms.TrackBar trbJogMaxAcc;
        private System.Windows.Forms.Label lblJogMaxAcc;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

