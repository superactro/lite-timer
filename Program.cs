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
            CountBack();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Play();
        }

        static void CountBack()
        {
            TimeSpan date = DateTime.Now.TimeOfDay;

            MessageBox.Show("helloCount");

        }


    }
}
