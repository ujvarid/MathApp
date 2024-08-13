using System;
using System.Windows.Forms;

namespace MathApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var splash = new Intro())
            {
                splash.Show();
                Application.DoEvents(); 
                System.Threading.Thread.Sleep(2000); 
                splash.Close();
            }

            // Start the main application
            Application.Run(new Menu());
        }
    }
}
