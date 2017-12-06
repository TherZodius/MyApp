using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
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
        async static void update()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://therzodiusinc.000webhostapp.com/Releases/"))
            {
                await mgr.Result.UpdateApp();
            }
        }

    }
}
