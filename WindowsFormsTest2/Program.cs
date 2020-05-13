using System;
using System.Windows.Forms;

namespace WindowsFormsTest2
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            Application.Run(new Form1());
        }
    }
}