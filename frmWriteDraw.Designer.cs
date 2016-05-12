namespace Dobot
{
    partial class frmWriteDraw
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWriteDraw));
            this.btnDraw = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtfileName = new System.Windows.Forms.TextBox();
            this.ibxImgShow = new Emgu.CV.UI.ImageBox();
            this.trbCannyThresh = new System.Windows.Forms.TrackBar();
            this.lblCannyThresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibxImgShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCannyThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(502, 253);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(0, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtfileName
            // 
            this.txtfileName.Location = new System.Drawing.Point(81, 5);
            this.txtfileName.Name = "txtfileName";
            this.txtfileName.Size = new System.Drawing.Size(189, 21);
            this.txtfileName.TabIndex = 2;
            this.txtfileName.TextChanged += new System.EventHandler(this.txtfileName_TextChanged);
            // 
            // ibxImgShow
            // 
            this.ibxImgShow.Location = new System.Drawing.Point(0, 67);
            this.ibxImgShow.Name = "ibxImgShow";
            this.ibxImgShow.Size = new System.Drawing.Size(320, 240);
            this.ibxImgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibxImgShow.TabIndex = 2;
            this.ibxImgShow.TabStop = false;
            // 
            // trbCannyThresh
            // 
            this.trbCannyThresh.Location = new System.Drawing.Point(0, 32);
            this.trbCannyThresh.Maximum = 255;
            this.trbCannyThresh.Name = "trbCannyThresh";
            this.trbCannyThresh.Size = new System.Drawing.Size(295, 45);
            this.trbCannyThresh.TabIndex = 3;
            this.trbCannyThresh.Value = 100;
            this.trbCannyThresh.Scroll += new System.EventHandler(this.trbCannyThresh_Scroll);
            // 
            // lblCannyThresh
            // 
            this.lblCannyThresh.AutoSize = true;
            this.lblCannyThresh.Location = new System.Drawing.Point(301, 32);
            this.lblCannyThresh.Name = "lblCannyThresh";
            this.lblCannyThresh.Size = new System.Drawing.Size(41, 12);
            this.lblCannyThresh.TabIndex = 4;
            this.lblCannyThresh.Text = "label1";
            // 
            // frmWriteDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 375);
            this.Controls.Add(this.lblCannyThresh);
            this.Controls.Add(this.ibxImgShow);
            this.Controls.Add(this.trbCannyThresh);
            this.Controls.Add(this.txtfileName);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWriteDraw";
            this.Text = "Dobot - Write and Draw";
            ((System.ComponentModel.ISupportInitialize)(this.ibxImgShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCannyThresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtfileName;
        private Emgu.CV.UI.ImageBox ibxImgShow;
        private System.Windows.Forms.TrackBar trbCannyThresh;
        private System.Windows.Forms.Label lblCannyThresh;
    }
}