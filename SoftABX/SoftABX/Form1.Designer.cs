namespace SoftABX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.buttonSetFile1 = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfTests = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPercentageCorrect = new System.Windows.Forms.TextBox();
            this.textBoxNumberCorrect = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfTests = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSetFile2 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showChoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftABXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfTests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File 1:";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(51, 27);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(369, 20);
            this.textBoxFile1.TabIndex = 1;
            // 
            // buttonSetFile1
            // 
            this.buttonSetFile1.Location = new System.Drawing.Point(439, 25);
            this.buttonSetFile1.Name = "buttonSetFile1";
            this.buttonSetFile1.Size = new System.Drawing.Size(75, 23);
            this.buttonSetFile1.TabIndex = 2;
            this.buttonSetFile1.Text = "Set...";
            this.buttonSetFile1.UseVisualStyleBackColor = true;
            this.buttonSetFile1.Click += new System.EventHandler(this.buttonSetFile1_Click);
            // 
            // numericUpDownNumberOfTests
            // 
            this.numericUpDownNumberOfTests.Location = new System.Drawing.Point(312, 97);
            this.numericUpDownNumberOfTests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfTests.Name = "numericUpDownNumberOfTests";
            this.numericUpDownNumberOfTests.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownNumberOfTests.TabIndex = 4;
            this.numericUpDownNumberOfTests.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumberOfTests.ValueChanged += new System.EventHandler(this.numericUpDownNumberOfTests_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of tests per run:";
            // 
            // buttonStartRun
            // 
            this.buttonStartRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartRun.Location = new System.Drawing.Point(155, 182);
            this.buttonStartRun.Name = "buttonStartRun";
            this.buttonStartRun.Size = new System.Drawing.Size(253, 77);
            this.buttonStartRun.TabIndex = 4;
            this.buttonStartRun.Text = "Start Run";
            this.buttonStartRun.UseVisualStyleBackColor = true;
            this.buttonStartRun.Click += new System.EventHandler(this.buttonStartRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPercentageCorrect);
            this.groupBox1.Controls.Add(this.textBoxNumberCorrect);
            this.groupBox1.Controls.Add(this.textBoxNumberOfTests);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Run";
            // 
            // textBoxPercentageCorrect
            // 
            this.textBoxPercentageCorrect.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPercentageCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPercentageCorrect.Location = new System.Drawing.Point(349, 50);
            this.textBoxPercentageCorrect.Name = "textBoxPercentageCorrect";
            this.textBoxPercentageCorrect.ReadOnly = true;
            this.textBoxPercentageCorrect.Size = new System.Drawing.Size(100, 38);
            this.textBoxPercentageCorrect.TabIndex = 5;
            this.textBoxPercentageCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumberCorrect
            // 
            this.textBoxNumberCorrect.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNumberCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberCorrect.Location = new System.Drawing.Point(221, 50);
            this.textBoxNumberCorrect.Name = "textBoxNumberCorrect";
            this.textBoxNumberCorrect.ReadOnly = true;
            this.textBoxNumberCorrect.Size = new System.Drawing.Size(100, 38);
            this.textBoxNumberCorrect.TabIndex = 4;
            this.textBoxNumberCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumberOfTests
            // 
            this.textBoxNumberOfTests.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNumberOfTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfTests.Location = new System.Drawing.Point(91, 50);
            this.textBoxNumberOfTests.Name = "textBoxNumberOfTests";
            this.textBoxNumberOfTests.ReadOnly = true;
            this.textBoxNumberOfTests.Size = new System.Drawing.Size(100, 38);
            this.textBoxNumberOfTests.TabIndex = 3;
            this.textBoxNumberOfTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Percentage Correct:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number Correct:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of Tests:";
            // 
            // textBoxReport
            // 
            this.textBoxReport.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxReport.Location = new System.Drawing.Point(13, 423);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ReadOnly = true;
            this.textBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReport.Size = new System.Drawing.Size(539, 190);
            this.textBoxReport.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFile2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonSetFile2);
            this.groupBox2.Controls.Add(this.numericUpDownNumberOfTests);
            this.groupBox2.Controls.Add(this.textBoxFile1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonSetFile1);
            this.groupBox2.Location = new System.Drawing.Point(13, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(51, 61);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(369, 20);
            this.textBoxFile2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "File 2:";
            // 
            // buttonSetFile2
            // 
            this.buttonSetFile2.Location = new System.Drawing.Point(439, 59);
            this.buttonSetFile2.Name = "buttonSetFile2";
            this.buttonSetFile2.Size = new System.Drawing.Size(75, 23);
            this.buttonSetFile2.TabIndex = 7;
            this.buttonSetFile2.Text = "Set...";
            this.buttonSetFile2.UseVisualStyleBackColor = true;
            this.buttonSetFile2.Click += new System.EventHandler(this.buttonSetFile2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(130, 265);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(302, 45);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "wav files (*.wav)|*.wav|mp3 files (*.mp3)|*.mp3|wma files (*.wma)|*.wma|All files" +
                " (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeFilesToolStripMenuItem,
            this.showChoicesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // randomizeFilesToolStripMenuItem
            // 
            this.randomizeFilesToolStripMenuItem.Name = "randomizeFilesToolStripMenuItem";
            this.randomizeFilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.randomizeFilesToolStripMenuItem.Text = "&Randomize Files";
            this.randomizeFilesToolStripMenuItem.Click += new System.EventHandler(this.randomizeFilesToolStripMenuItem_Click);
            // 
            // showChoicesToolStripMenuItem
            // 
            this.showChoicesToolStripMenuItem.Checked = true;
            this.showChoicesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showChoicesToolStripMenuItem.Name = "showChoicesToolStripMenuItem";
            this.showChoicesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.showChoicesToolStripMenuItem.Text = "&Show Choices";
            this.showChoicesToolStripMenuItem.Click += new System.EventHandler(this.showChoicesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSoftABXToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutSoftABXToolStripMenuItem1
            // 
            this.aboutSoftABXToolStripMenuItem1.Name = "aboutSoftABXToolStripMenuItem1";
            this.aboutSoftABXToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.aboutSoftABXToolStripMenuItem1.Text = "&About SoftABX";
            this.aboutSoftABXToolStripMenuItem1.Click += new System.EventHandler(this.aboutSoftABXToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 625);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStartRun);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SoftABX";
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfTests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.Button buttonSetFile1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPercentageCorrect;
        private System.Windows.Forms.TextBox textBoxNumberCorrect;
        private System.Windows.Forms.TextBox textBoxNumberOfTests;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSetFile2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.NumericUpDown numericUpDownNumberOfTests;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftABXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomizeFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showChoicesToolStripMenuItem;
    }
}

