using System;
using System.Windows.Forms;

namespace GWS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RolePilih.FormRoleSelector());  // BUKA LOGIN DULU
        }
    }
}

