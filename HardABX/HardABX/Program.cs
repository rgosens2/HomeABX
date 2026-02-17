using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HardABX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
        /*// Data Form1 and Form2 need to access both
        public static class DataContainer
        {
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

            static public String file1 = "";
            static public String file2 = "";
        }*/

    }
}
