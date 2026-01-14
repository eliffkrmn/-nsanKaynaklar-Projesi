using System;
using System.Windows.Forms;
using proje.UI; 

namespace proje
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new GirisFormu());
        }
    }
}