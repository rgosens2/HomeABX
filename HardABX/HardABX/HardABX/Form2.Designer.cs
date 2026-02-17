namespace HardABX
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonXisA = new System.Windows.Forms.Button();
            this.buttonXisB = new System.Windows.Forms.Button();
            this.buttonEndTest = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.checkBoxPlayA = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayB = new System.Windows.Forms.CheckBox();
            this.checkBoxPlayX = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXisA
            // 
            this.buttonXisA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXisA.Location = new System.Drawing.Point(73, 240);
            this.buttonXisA.Name = "buttonXisA";
            this.buttonXisA.Size = new System.Drawing.Size(191, 51);
            this.buttonXisA.TabIndex = 3;
            this.buttonXisA.Text = "X is A";
            this.buttonXisA.UseVisualStyleBackColor = true;
            this.buttonXisA.Click += new System.EventHandler(this.buttonXisA_Click);
            // 
            // buttonXisB
            // 
            this.buttonXisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXisB.Location = new System.Drawing.Point(274, 240);
            this.buttonXisB.Name = "buttonXisB";
            this.buttonXisB.Size = new System.Drawing.Size(191, 51);
            this.buttonXisB.TabIndex = 4;
            this.buttonXisB.Text = "X is B";
            this.buttonXisB.UseVisualStyleBackColor = true;
            this.buttonXisB.Click += new System.EventHandler(this.buttonXisB_Click);
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.Location = new System.Drawing.Point(232, 315);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(75, 23);
            this.buttonEndTest.TabIndex = 5;
            this.buttonEndTest.Text = "End Test";
            this.buttonEndTest.UseVisualStyleBackColor = true;
            this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(61, 82);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(392, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPlayX);
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Controls.Add(this.checkBoxPlayB);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkBoxPlayA);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 168);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(61, 98);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(392, 45);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // checkBoxPlayA
            // 
            this.checkBoxPlayA.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlayA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.checkBoxPlayA.Location = new System.Drawing.Point(61, 21);
            this.checkBoxPlayA.Name = "checkBoxPlayA";
            this.checkBoxPlayA.Size = new System.Drawing.Size(117, 51);
            this.checkBoxPlayA.TabIndex = 12;
            this.checkBoxPlayA.Text = "Play A";
            this.checkBoxPlayA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPlayA.UseVisualStyleBackColor = true;
            this.checkBoxPlayA.CheckedChanged += new System.EventHandler(this.checkBoxPlayA_CheckedChanged);
            // 
            // checkBoxPlayB
            // 
            this.checkBoxPlayB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.checkBoxPlayB.Location = new System.Drawing.Point(336, 21);
            this.checkBoxPlayB.Name = "checkBoxPlayB";
            this.checkBoxPlayB.Size = new System.Drawing.Size(117, 51);
            this.checkBoxPlayB.TabIndex = 13;
            this.checkBoxPlayB.Text = "Play B";
            this.checkBoxPlayB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPlayB.UseVisualStyleBackColor = true;
            this.checkBoxPlayB.CheckedChanged += new System.EventHandler(this.checkBoxPlayB_CheckedChanged);
            // 
            // checkBoxPlayX
            // 
            this.checkBoxPlayX.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.checkBoxPlayX.Location = new System.Drawing.Point(199, 21);
            this.checkBoxPlayX.Name = "checkBoxPlayX";
            this.checkBoxPlayX.Size = new System.Drawing.Size(117, 51);
            this.checkBoxPlayX.TabIndex = 14;
            this.checkBoxPlayX.Text = "Play X";
            this.checkBoxPlayX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPlayX.UseVisualStyleBackColor = true;
            this.checkBoxPlayX.CheckedChanged += new System.EventHandler(this.checkBoxPlayX_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Test number 1 of 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 356);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEndTest);
            this.Controls.Add(this.buttonXisB);
            this.Controls.Add(this.buttonXisA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "HardABX Test";
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXisA;
        private System.Windows.Forms.Button buttonXisB;
        private System.Windows.Forms.Button buttonEndTest;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.CheckBox checkBoxPlayA;
        private System.Windows.Forms.CheckBox checkBoxPlayB;
        private System.Windows.Forms.CheckBox checkBoxPlayX;
        private System.Windows.Forms.Label label1;
    }
}