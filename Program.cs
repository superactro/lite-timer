using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace LiteTimer
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
            Application.Run(new LiteTimer());

            //SoundPlayer simpleSound = new SoundPlayer();
            //simpleSound.Play();
        }

        public static void CountBack(int num)
        {
            TimeSpan date = DateTime.Now.TimeOfDay;
            MessageBox.Show("!!");


        }
    }
}
