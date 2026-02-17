using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HardABX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 2;
        }

        Form2 f2 = null;

        // Testdata stuff
        public class Test
        {
            public int A = 0;
            public int B = 0;
            public int X = 0;
            public string Choice = "?";
        }

        static public Test[] arrTests = new Test[100];

        static public int testNumber = 0;
        static public int numberOfTests = 10;
        static public int correctTests = 0;

        static public bool staticRelayPlacement = true;
        static public bool showChoices = true;

        static public String file1 = "";
        static public String file2 = "";

        int count = 0;


        // Velleman VM8090 stuff
        //int msk = 0x01;

        //int count = 1;

        bool bConnected = false;

        enum Relays
        {
            Relay1 = 0x01,
            Relay2 = 0x02,
            Relay3 = 0x04,
            Relay4 = 0x08,
            Relay5 = 0x10,
            Relay6 = 0x20,
            Relay7 = 0x40,
            Relay8 = 0x80
        }

        

        private void buttonStartRun_Click(object sender, EventArgs e)
        {
            if (bConnected)
            {
                // Hide this dialog
                this.Hide();

                // Create/Show Test dialog
                if (f2 == null)
                {
                    f2 = new Form2(this);
                }
                // NOTE: Using Show solves the "WMP control going black" bug
                //f2.ShowDialog();
                f2.Show();
            }
            else
            {
                MessageBox.Show(this, "Not connected. Please connect to relay board before running a test.", "HardABX Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
            }
        }

        private void buttonSetFile1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.Filter = "wav files (*.wav)|*.wav|mp3 files (*.mp3)|*.mp3|wma files (*.wma)|*.wma|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 3;
            //openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Set name in text box
                            textBoxFile1.Text = openFileDialog1.FileName;
                            file1 = openFileDialog1.FileName;

                            // Insert code to read the stream here.
                            // TEST:
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            //player.SoundLocation = openFileDialog1.FileName;
                            //player.Play();

                            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                            //wplayer.URL = openFileDialog1.FileName;
                            //wplayer.controls.play();

                            //axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                            //axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void buttonSetFile2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Set name in text box
                            textBoxFile2.Text = openFileDialog1.FileName;
                            file2 = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                return;

            // Skip first time
            if (count < 1)
            {
                count++;
                return;
            }

            // Restore if necessary
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Focus();


            // Get access to Form2 stuff
            // NONO: cannot access form2 stuff like this: arrTests gets totally recreated???
            // It takes the previous Choices on the second run
            //Form2 form2 = (Form2)Application.OpenForms["Form2"];


            /* Format:
            ABX Test Completed: 2012-05-13 21:37:37 +0200

            Number of tests performed: 10
            Number of correct answers: 3
            Percentage correct:  30%

            File 1 = /Users/RG/Music/iTunes/iTunes Media/Music/Derek Han; Paul Freeman_ Philharmonia Orchestra/Mozart_ Complete Works, VoL. 2 - Concertos [Disc 2]/13-05 Mozart_ Piano Concerto #3 In D, K 40 - 2. Andante.wav
            File 2 = /Users/RG/Music/iTunes/iTunes Media/Music/Derek Han; Paul Freeman_ Philharmonia Orchestra/Mozart_ Complete Works, VoL. 2 - Concertos [Disc 2]/13-05 Mozart_ Piano Concerto #3 In D, K 40 - 2. Andante 14.mp3
            File placement was static.

             n	[A]	[X]	[B]	Choice	Score
             1	[1]	[1]	[2]	  A		 1/1
             2	[1]	[2]	[2]	  A		 1/2
             3	[1]	[2]	[2]	  A		 1/3
             4	[1]	[2]	[2]	  A		 1/4
             5	[1]	[2]	[2]	  A		 1/5
             6	[1]	[1]	[2]	  A		 2/6
             7	[1]	[2]	[2]	  A		 2/7
             8	[1]	[1]	[2]	  A		 3/8
             9	[1]	[2]	[2]	  A		 3/9
            10	[1]	[2]	[2]	  A		 3/10

            --------------------------------------------------------------
            
            */

            // + Environment.NewLine


            // Check test results
            string testResults = "";

            for (int i = 0; i < testNumber; i++)
            {
                // Check if answer is correct
                if ((arrTests[i].X == arrTests[i].A && arrTests[i].Choice == "A") ||
                    (arrTests[i].X == arrTests[i].B && arrTests[i].Choice == "B"))
                {
                    correctTests++;
                }

                testResults += (i + 1) + "\t[" + arrTests[i].A + "]\t[" + arrTests[i].X + "]\t[" + arrTests[i].B + "]\t   " + arrTests[i].Choice + "\t " + correctTests + "/" + (i + 1) + "\r\n";
            }

            // Fill textboxes
            textBoxNumberOfTests.Text = testNumber.ToString();
            textBoxNumberCorrect.Text = correctTests.ToString();

            // Calculate percentage correct
            int percentCorrect = 0;
            if (testNumber != 0)
            {
                percentCorrect = (int)(((float)correctTests / testNumber) * 100);
            }
            textBoxPercentageCorrect.Text = percentCorrect.ToString() + "%";


            // Fill report
            string testReport = "";

            testReport += "ABX Test Completed: " + DateTime.Now.ToString() + "\r\n";
            testReport += "\r\n";
            testReport += "Number of tests performed: " + testNumber + "\r\n";
            testReport += "Number of correct answers: " + correctTests + "\r\n"; ;
            testReport += "Percentage correct: " + percentCorrect + "%" + "\r\n"; ;
            testReport += "\r\n";
            testReport += "File = " + file1 + "\r\n";
            //testReport += "File 2 = " + file2 + "\r\n";

            if (staticRelayPlacement == true)
            {
                testReport += "Relay placement was static." + "\r\n";
            }
            else
            {
                testReport += "Relay placement was random." + "\r\n";
            }

            if (showChoices == true)
            {
                testReport += "\r\n";
                testReport += "#\t[A]\t[X]\t[B]\tChoice\t Score" + "\r\n";

                testReport += testResults;
            }

            testReport += "\r\n";
            testReport += "--------------------------------------------------------------" + "\r\n";
            testReport += "\r\n";

            // Add test report
            //textBoxReport.Text += testReport;
            // Scrolls down but form must have focus
            //textBoxReport.AppendText(testReport);
            // Let's prepend
            textBoxReport.Text = testReport + textBoxReport.Text;

            // Scroll down
            //textBoxReport.SelectionStart = textBoxReport.Text.Length;
            //textBoxReport.SelectionStart = textBoxReport.Text.Length;
            //textBoxReport.ScrollToCaret();
            //textBoxReport.Refresh();

 

        }

        private void numericUpDownNumberOfTests_ValueChanged(object sender, EventArgs e)
        {
            numberOfTests = (int)numericUpDownNumberOfTests.Value;
        }


        //---------------------------------------------------------------------
        #region About menu item in system menu
        // About menu item in system menu
        // P/Invoke constants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;

        // P/Invoke declarations
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);


        // ID for the About item on the system menu
        private int SYSMENU_ABOUT_ID = 0x1;
    

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Get a handle to a copy of this form's system (window) menu
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);

            // Add a separator
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);

            // Add the About menu item
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About…");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Test if the About item was selected from the system menu
            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                //MessageBox.Show("Custom About Dialog");
                AboutBox1 aboutBox1 = new AboutBox1();
                aboutBox1.ShowDialog();
            }
        }
        #endregion
        //---------------------------------------------------------------------
        


        private void randomizeRelaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticRelayPlacement = !staticRelayPlacement;
            if (staticRelayPlacement)
            {
                randomizeRelaysToolStripMenuItem.Checked = false;
            }
            else 
            {
                randomizeRelaysToolStripMenuItem.Checked = true;
            }
        }

        private void showChoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChoices = !showChoices;
            if (showChoices)
            {
                showChoicesToolStripMenuItem.Checked = true;
            }
            else
            {
                showChoicesToolStripMenuItem.Checked = false;
            }
        }

        private void onlineManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://hardabx.blogspot.com");
        }

        private void aboutHardABXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                // Click button
                buttonStartRun.PerformClick();
            }
        }


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            k8090Board1.Port = comboBox1.Text;
            

            if (!bConnected)
            {
                bConnected = k8090Board1.Connect();

                if (bConnected)
                {
                    // TEST:
                    // NOTE: We can also connect to COM1 and COM2 even when the relay board is on COM3
                    // TODO: Catch connection to COM1 and COM3 as error
                    buttonConnect.Text = "Disconnect";
                    comboBox1.Enabled = false;                   
                }
                else
                {
                    MessageBox.Show(this, "Failed to connect.", "HardABX Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    k8090Board1.Disconnect();

                    bConnected = false;
                    buttonConnect.Text = "Connect";
                    comboBox1.Enabled = true;
                }
                catch (Exception ex)
                {
                    bConnected = true;

                    MessageBox.Show(this, "Failed to disconnect:\n\n" + ex.Message, "HardABX Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }    

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (bConnected)
                {
                    k8090Board1.Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to disconnect:\n\n" + ex.Message, "HardABX Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void k8090Board1_CommandReceived(object o, Velleman.Kits.CommandEventArgs args)
        {

        }

        private void textBoxFile1_TextChanged(object sender, EventArgs e)
        {
            file1 = textBoxFile1.Text;
        }

        private void textBoxFile2_TextChanged(object sender, EventArgs e)
        {
            file2 = textBoxFile2.Text;
        }

     
    }
}
