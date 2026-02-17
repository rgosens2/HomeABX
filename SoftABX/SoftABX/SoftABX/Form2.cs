using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace SoftABX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }

        public Form2(Form1 fr1)
        {
            InitializeComponent();
            f1 = new Form1();
            f1 = fr1;
        }

        Form1 f1;

        // Get access to Form1 stuff
        // 1. Ugly
        //Form1 form1 = (Form1)Application.OpenForms["Form1"];
        //TextBox tb = (TextBox)form1.Controls["textBox1"];
        // 2. Use Class with all data in Program
        // 3. Use delegates and events
        // 4. Put data in Form1 and pass Form1 reference to Form2 overloaded constructor
        // NOTE: Data is accessed via typename Form1. and Methods and Properties via instance name f1.
        // NOTE: as always with shared data you have to mind concurrency


        Random rnd = new Random();


        // Play a click sound for confirmation
        // Better pre-load this stuff
        static Assembly assembly = Assembly.GetExecutingAssembly();
        SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("SoftABX.Windows Startup.wav"));
 


        private void buttonPlayA_Click(object sender, EventArgs e)
        {
            // Ah, ugly non OO
            // axWindowsMediaPlayer1.URL = form1.Controls["groupBox2"].Controls["textBoxFile1"].Text;


            switch (Form1.arrTests[Form1.testNumber].A)
            {
                case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonPlayB_Click(object sender, EventArgs e)
        {
            switch (Form1.arrTests[Form1.testNumber].B)
            {
                case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonPlayX_Click(object sender, EventArgs e)
        {
            switch (Form1.arrTests[Form1.testNumber].X)
            {
                case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
            }
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        private void buttonXisA_Click(object sender, EventArgs e)
        {
            Form1.arrTests[Form1.testNumber].Choice = "A";

            // Set text box
            Form1.testNumber++;
            label1.Text = "Test number " + (Form1.testNumber + 1) + " of " + Form1.numberOfTests;

            // Uncheck all boxes
            checkBoxPlayA.Checked = false;
            checkBoxPlayB.Checked = false;
            checkBoxPlayX.Checked = false;

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Play a click sound for confirmation
            //System.Media.SystemSounds.Asterisk.Play();
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
            //Assembly assembly;
            //Stream soundStream;
            //SoundPlayer sp;
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("SoftABX.Windows Startup.wav"));
            sp.Play();


            if (Form1.testNumber > Form1.numberOfTests - 1)
            {
                // Click End Test programmatically
                buttonEndTest_Click(sender, e);
            }
        }

        private void buttonXisB_Click(object sender, EventArgs e)
        {
            Form1.arrTests[Form1.testNumber].Choice = "B";

            // Set text box
            Form1.testNumber++;
            label1.Text = "Test number " + (Form1.testNumber + 1) + " of " + Form1.numberOfTests;

            // Uncheck all boxes
            checkBoxPlayA.Checked = false;
            checkBoxPlayB.Checked = false;
            checkBoxPlayX.Checked = false;

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Play a click sound for confirmation
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("SoftABX.Windows Startup.wav"));
            sp.Play();

            if (Form1.testNumber > Form1.numberOfTests - 1)
            {
                // Click End Test programmatically
                buttonEndTest_Click(sender, e);
            }
        }


        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            // Stop playing
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Hide this dialog
            this.Hide();
            //this.Close();

            // Show the start-up dialog            
            f1.Show();
        }


        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            // TODO:
            // Better send message from Run Test button to form2
            // And also send message from End Test button to form1
            // VisibleChanged gets called erratically

            // TODO:
            // WMP Control changes into black at second time visible
            // Need to recreate it?

            // When form becomes visible initiate a new test
           if (this.Visible == true)
           {
               // Restore if necessary
               this.WindowState = FormWindowState.Normal;
               this.BringToFront();
               this.Focus();


				// Reset
				Form1.testNumber = 0;
				Form1.correctTests = 0;

				// Not necessary: we check this in Form1
				//Form1.numberOfTests = (int)f1.numericUpDownNumberOfTests.Value;

				// Set text box
				label1.Text = "Test number " + 1 + " of " + Form1.numberOfTests;


                // With static file placement file 1 and file 2 are randomly assigned to A and B only at
                // the start of the test run
                int staticA = 0;
                int staticB = 0;

				staticA = rnd.Next(1, 3);
                switch (staticA)
                {
                    case 1: staticB = 2; break;
                    case 2: staticB = 1; break;
                }				


				// Fill test array
				for (int i = 0; i < Form1.numberOfTests; i++)
				{
					//NOTE: Cannot declare rnd here, because we it will generate the same number
					//The reason is the finite resolution of the clock used to initialize Random.
					//Subsequent initializations of Random will get the same starting position in the
					//random sequence. When reusing the same Random the next value in the random sequence
					//is always generated.
					//Random rnd = new Random();

					Form1.arrTests[i] = new Form1.Test();

					// File placement
					if (Form1.staticFilePlacement == true)
					{
                        Form1.arrTests[i].A = staticA;
                        Form1.arrTests[i].B = staticB;
					}
					else
					{
						// Random file placement
						Form1.arrTests[i].A = rnd.Next(1, 3);
						switch (Form1.arrTests[i].A)
						{
							case 1: Form1.arrTests[i].B = 2; break;
							case 2: Form1.arrTests[i].B = 1; break;
						}
					}

                    Form1.arrTests[i].X = rnd.Next(1, 3);
                    Form1.arrTests[i].Choice = "?";
				}

				// WMP
				//axWindowsMediaPlayer1.Ctlcontrols.
			}
		}


        private void checkBoxPlayA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayA.Checked)
            {
                // Uncheck the other boxes
                checkBoxPlayB.Checked = false;
                checkBoxPlayX.Checked = false;

                switch (Form1.arrTests[Form1.testNumber].A)
                {
                    case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void checkBoxPlayB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayB.Checked) 
            {
                // Uncheck the other boxes
                checkBoxPlayA.Checked = false;
                checkBoxPlayX.Checked = false;

                switch (Form1.arrTests[Form1.testNumber].B)
                {
                    case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void checkBoxPlayX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayX.Checked)
            {
                // Uncheck the other boxes
                checkBoxPlayA.Checked = false;
                checkBoxPlayB.Checked = false;

                switch (Form1.arrTests[Form1.testNumber].X)
                {
                    case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }



        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            // NOTE: Form2 Property KeyPreview needs to be true to get keys
            if (e.KeyCode == Keys.A)
            {
                //MessageBox.Show("QQQ");

                // Click button programmatically
                //checkBoxPlayA_CheckedChanged(sender, e);

                // Toggle checkbox button
                checkBoxPlayA.Checked = !checkBoxPlayA.Checked;
            }

            if (e.KeyCode == Keys.B)
            {              
                // Toggle checkbox button
                checkBoxPlayB.Checked = !checkBoxPlayB.Checked;
            }

            if (e.KeyCode == Keys.X)
            {
                // Toggle checkbox button
                checkBoxPlayX.Checked = !checkBoxPlayX.Checked;
            }

            if (e.KeyCode == Keys.Q)
            {
                // Click button
                //buttonXisA_Click(sender, e);
                buttonXisA.PerformClick();
            }

            if (e.KeyCode == Keys.P)
            {
                // Click button
                //buttonXisB_Click(sender, e);
                buttonXisB.PerformClick();
            }
        }

       


    }
}
