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
using WMPLib;
using System.Threading;

namespace HardABX
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
        SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("HardABX.Windows Startup.wav"));
 

/* 
        // NOTE: We use checkBox buttons instead because they toggle
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
*/

        private void buttonXisA_Click(object sender, EventArgs e)
        {
            Form1.arrTests[Form1.testNumber].Choice = "A";

            // Stop music
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Play confirmation sound
            // NOTE: Will only play when either A or B relays are on, of course
            // NOTE: Better not use it because we need to sleep to make the sound heard before the relays
            // are turned off.
            //SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("HardABX.Windows Startup.wav"));
            //sp.Play();
            //Thread.Sleep(500);

            // Set text box
            Form1.testNumber++;
            label1.Text = "Test number " + (Form1.testNumber + 1) + " of " + Form1.numberOfTests;

            // Uncheck all boxes
            checkBoxPlayA.Checked = false;
            checkBoxPlayB.Checked = false;
            checkBoxPlayX.Checked = false;

            //axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Play a click sound for confirmation
            // NOTE: Will not play when doing hardware ABX of course because we switch off the relays
            //System.Media.SystemSounds.Asterisk.Play();
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
            //Assembly assembly;
            //Stream soundStream;
            //SoundPlayer sp;
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("HardABX.Windows Startup.wav"));
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

            // Stop music
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            // Set text box
            Form1.testNumber++;
            label1.Text = "Test number " + (Form1.testNumber + 1) + " of " + Form1.numberOfTests;

            // Uncheck all boxes
            checkBoxPlayA.Checked = false;
            checkBoxPlayB.Checked = false;
            checkBoxPlayX.Checked = false;

            // Play a click sound for confirmation
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream("HardABX.Windows Startup.wav"));
            //sp.Play();

            if (Form1.testNumber > Form1.numberOfTests - 1)
            {
                // Click End Test programmatically
                buttonEndTest_Click(sender, e);
            }
        }


        private void buttonEndTest_Click(object sender, EventArgs e)
        {
            // Uncheck all boxes
            checkBoxPlayA.Checked = false;
            checkBoxPlayB.Checked = false;
            checkBoxPlayX.Checked = false;

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

                // Uncheck all boxes
                checkBoxPlayA.Checked = false;
                checkBoxPlayB.Checked = false;
                checkBoxPlayX.Checked = false;


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

					// Relay placement
					if (Form1.staticRelayPlacement == true)
					{
                        Form1.arrTests[i].A = staticA;
                        Form1.arrTests[i].B = staticB;
					}
					else
					{
						// Random relay placement
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
                // NOTE: When user starts a new test without a file to play we must make WMP not play
                // the old one. Alas, does not work this way: it will play the last playable URL.
                // Must do that otherwise.
                //axWindowsMediaPlayer1.close();
                //axWindowsMediaPlayer1.URL = "";
                //axWindowsMediaPlayer1.newMedia("");
                
			}
		}


        private void checkBoxPlayA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayA.Checked)
            {
                // Uncheck the other boxes
                checkBoxPlayB.Checked = false;
                checkBoxPlayX.Checked = false;

                // Switch relays off to always get that click sound
                // NOTE: We sleep 10ms to allow the relays to come off before turning
                // them on again. This is the Release time from the spec sheet.
                f1.k8090Board1.SwitchRelayOff();
                Thread.Sleep(10);

                switch (Form1.arrTests[Form1.testNumber].A)
                {
                    //case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    //case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;

                    // NOTE: When switching relays, the board checks which relays are on or off.
                    // If you switch to A and then to X, and X happens to be A, the board sees that
                    // it does not need to switch relays, so we do not hear the relays' click sound.
                    // That way the person doing the test can hear which is X.
                    // Therefore we must switch all relays off before switching to A, B or X.
                    // Then we will always hear that affirmative click sound.
                    // NOTE: Switching relays off and then immediately on is not very good for the relays.
                    // So we must sleep a while before switching on. But this gives us two click sounds
                    // and a short silence in between switching.
                    // The best solution is of course to put the board in a sound-proof case.
                    case 1:
                        f1.k8090Board1.SwitchRelayOn(0x0F); 
                        break;
                    case 2:
                        f1.k8090Board1.SwitchRelayOn(0xF0); 
                        break;
                }

                if (Form1.file1 != "" && axWindowsMediaPlayer1.playState != WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.URL = Form1.file1;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }                
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                // Relays
                f1.k8090Board1.SwitchRelayOff(0xFF);
            }
        }

        private void checkBoxPlayB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayB.Checked) 
            {
                // Uncheck the other boxes
                checkBoxPlayA.Checked = false;
                checkBoxPlayX.Checked = false;

                // Switch relays off to always get that click sound
                f1.k8090Board1.SwitchRelayOff();
                Thread.Sleep(10);

                switch (Form1.arrTests[Form1.testNumber].B)
                {
                    //case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    //case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;

                    case 1:
                        f1.k8090Board1.SwitchRelayOn(0x0F);
                        break;
                    case 2:
                        f1.k8090Board1.SwitchRelayOn(0xF0);
                        break;
                }

                if (Form1.file1 != "" && axWindowsMediaPlayer1.playState != WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.URL = Form1.file1;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                // Relays
                f1.k8090Board1.SwitchRelayOff(0xFF);
            }
        }

        private void checkBoxPlayX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayX.Checked)
            {
                // Uncheck the other boxes
                checkBoxPlayA.Checked = false;
                checkBoxPlayB.Checked = false;

                // Switch relays off to always get that click sound
                f1.k8090Board1.SwitchRelayOff();
                Thread.Sleep(10);

                switch (Form1.arrTests[Form1.testNumber].X)
                {
                    //case 1: axWindowsMediaPlayer1.URL = Form1.file1; break;
                    //case 2: axWindowsMediaPlayer1.URL = Form1.file2; break;

                    case 1:
                        f1.k8090Board1.SwitchRelayOn(0x0F);
                        break;
                    case 2:
                        f1.k8090Board1.SwitchRelayOn(0xF0);
                        break;
                }

                if (Form1.file1 != "" && axWindowsMediaPlayer1.playState != WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.URL = Form1.file1;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }

            // Stop play if all unchecked
            if (!checkBoxPlayA.Checked && !checkBoxPlayB.Checked && !checkBoxPlayX.Checked)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();

                // Relays
                f1.k8090Board1.SwitchRelayOff(0xFF);
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
