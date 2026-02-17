using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Velleman.Kits;

namespace TestVM8090
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bConnected = k8090Board1.Connect();

            if (!bConnected)
            {
                MessageBox.Show("Failed to connect.", "TestVM8090 Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            timer1.Interval = 100;


            /*
            //----------------------------------------------------------
            // NOTE: DoubleBuffered listview. It works, but what a hassle!
            // And now we cannot use the designer any more.
            // 
            // listViewDB
            // 
            this.listViewDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDB0,
            this.columnHeaderDB1,
            this.columnHeaderDB2,
            this.columnHeaderDB3,
            this.columnHeaderDB4});
            this.listViewDB.Location = new System.Drawing.Point(182, 30);
            this.listViewDB.Name = "listViewDB";
            this.listViewDB.Size = new System.Drawing.Size(370, 97);
            this.listViewDB.TabIndex = 13;
            this.listViewDB.UseCompatibleStateImageBehavior = false;
            this.listViewDB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDB0
            // 
            this.columnHeaderDB0.Text = "#";
            this.columnHeaderDB0.Width = 40;
            // 
            // columnHeaderDB1
            // 
            this.columnHeaderDB1.Text = "cmd";
            this.columnHeaderDB1.Width = 93;
            // 
            // columnHeaderDB2
            // 
            this.columnHeaderDB2.Text = "mask";
            // 
            // columnHeaderDB3
            // 
            this.columnHeaderDB3.Text = "param1";
            // 
            // columnHeaderDB4
            // 
            this.columnHeaderDB4.Text = "param2";

            this.Controls.Add(this.listViewDB);
            //----------------------------------------------------------
            */

        }



        int msk = 0x01;

        int count = 1;

        bool bConnected = false;

        enum Relays
        {
            Relay1 = 0x1,
            Relay2 = 0x2,
            Relay3 = 0x4,
            Relay4 = 0x8,
            Relay5 = 0x10,
            Relay6 = 0x20,
            Relay7 = 0x40,
            Relay8 = 0x80
        }

        // TEST:
        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //public static extern bool LockWindowUpdate(IntPtr hWndLock);

/*
        // NOTE: To reduce flicker during updates we must use inherit from ListView
        // to set the protected DoubleBuffered property. See:
        // http://msdn.microsoft.com/en-us/library/system.windows.forms.listview.doublebuffered.aspx
        // http://msdn.microsoft.com/en-us/library/5h0k2e6x(v=vs.80).aspx
        // But then we cannot use the designer, or we must first turn that listview into a control
        // and then import that control.
        // NOTE: Setting Form1's doublebuffered prop does not help.
        class DoubleBufferedListView : System.Windows.Forms.ListView
        { 
            public DoubleBufferedListView() : base() 
            {
                this.DoubleBuffered = true; 
            }
        }

        DoubleBufferedListView listViewDB = new DoubleBufferedListView();
        ColumnHeader columnHeaderDB0 = new ColumnHeader();
        ColumnHeader columnHeaderDB1 = new ColumnHeader();
        ColumnHeader columnHeaderDB2 = new ColumnHeader();
        ColumnHeader columnHeaderDB3 = new ColumnHeader();
        ColumnHeader columnHeaderDB4 = new ColumnHeader();
*/


        private void buttonTest_Click(object sender, EventArgs e)
        {
            //k8090Board1.Port = "COM3";
            //if (k8090Board1.Connect())
            {
                k8090Board1.ToggleRelay(0xFF);
                //k8090Board1.Disconnect();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //k8090Board1.ToggleRelay(0xFF);
            k8090Board1.SwitchRelayOff((byte)(msk >> 1));
            k8090Board1.SwitchRelayOn((byte)msk);
            //k8090Board1.ToggleRelay((byte)msk);

            msk *= 2;
            //if (msk > 0xFF)
            if (msk > 256)
            {
                msk = 0x01;
                k8090Board1.SwitchRelayOff();
            }
                
            
            //Thread.Sleep(1000);            
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
                //throw (ex);    // Rethrowing exception e
                MessageBox.Show(ex.ToString(), "TestVM8090 Error");
            }
        }

        private void buttonRelaysOff_Click(object sender, EventArgs e)
        {
            k8090Board1.SwitchRelayOff();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x01);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x02);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x04);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x08);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x10);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x20);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x40);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //k8090Board1.ToggleRelay(0x80);
        }

        

        private void checkBoxToggleRun_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void k8090Board1_CommandReceived(object o, Velleman.Kits.CommandEventArgs args)
        {
            //textBox1.AppendText(args.cmd.ToString() + "\r\n");
            
            //ListViewItem item1 = new ListViewItem("item1", 0);
            //item1.SubItems.Add("1");
            //item1.SubItems.Add("2");
            //item1.SubItems.Add("3");

            ListViewItem item1 = new ListViewItem(count++.ToString(), 0);
            item1.SubItems.Add(args.mask.ToString(args.cmd.ToString()));
            item1.SubItems.Add(args.mask.ToString("X2"));
            item1.SubItems.Add(args.param1.ToString("X2"));
            item1.SubItems.Add(args.param2.ToString("X2"));

            // Reduce flicker during listview update 
            //LockWindowUpdate(listView1.Handle);
            //this.SuspendLayout();

            //listView1.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true); 
            
            //Add the items to the ListView.
            //listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            
            listView1.Items.AddRange(new ListViewItem[] { item1 });
            listView1.EnsureVisible(listView1.Items.Count -1);

            //listViewDB.Items.AddRange(new ListViewItem[] { item1 });
            //listViewDB.EnsureVisible(listViewDB.Items.Count - 1);

            // Reduce flicker during listview update 
            //LockWindowUpdate(IntPtr.Zero);            
            //this.ResumeLayout();
            //this.PerformLayout(); 


            // Set checkbox buttons
            if (args.cmd == K8090Command.RelayStatus)
            {
                // Relay1
                if ((args.param1 & 0x01) == 0x01)
                {
                    checkBox1.Checked = true;
                    //MessageBox.Show("Relay1 On");
                }
                else
                {
                    checkBox1.Checked = false;
                }

                // Relay2
                if ((args.param1 & 0x02) == 0x02)
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }

                // Relay3
                if ((args.param1 & 0x04) == 0x04)
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox3.Checked = false;
                }

                // Relay4
                if ((args.param1 & 0x08) == 0x08)
                {
                    checkBox4.Checked = true;
                }
                else
                {
                    checkBox4.Checked = false;
                }

                // Relay5
                if ((args.param1 & 0x10) == 0x10)
                {
                    checkBox5.Checked = true;
                }
                else
                {
                    checkBox5.Checked = false;
                }

                // Relay6
                if ((args.param1 & 0x20) == 0x20)
                {
                    checkBox6.Checked = true;
                }
                else
                {
                    checkBox6.Checked = false;
                }

                // Relay7
                if ((args.param1 & 0x40) == 0x40)
                {
                    checkBox7.Checked = true;
                }
                else
                {
                    checkBox7.Checked = false;
                }

                // Relay8
                if ((args.param1 & 0x80) == 0x80)
                {
                    checkBox8.Checked = true;
                }
                else
                {
                    checkBox8.Checked = false;
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x01);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x02);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x04);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x08);
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x10);
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x20);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x40);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            k8090Board1.ToggleRelay(0x80);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1) checkBox1_Click(sender, e);
            if (e.KeyCode == Keys.D2) checkBox2_Click(sender, e);
            if (e.KeyCode == Keys.D3) checkBox3_Click(sender, e);
            if (e.KeyCode == Keys.D4) checkBox4_Click(sender, e);
            if (e.KeyCode == Keys.D5) checkBox5_Click(sender, e);
            if (e.KeyCode == Keys.D6) checkBox6_Click(sender, e);
            if (e.KeyCode == Keys.D7) checkBox7_Click(sender, e);
            if (e.KeyCode == Keys.D8) checkBox8_Click(sender, e);
        }

    }
}
