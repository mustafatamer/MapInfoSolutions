using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapInfo.Application;
using System.Runtime.InteropServices;


namespace WindowsFormsApp
{
    static class Program
    {
        public static MapInfo.Types.IMapInfoApplication miApplication { get; set; }

        public static BilgiListe _form = new BilgiListe();
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetDllDirectory(string lpPathName);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetDllDirectory(@"C:\Program Files\MapInfo\Professional");
            MapInfoCore.StartUp(null);

            Application.Run(new Form1());
        }
    }
}
