using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamir.SharpSsh;

namespace SSHtest
{
    class Program
    {
        static void Main(string[] args)
        {
            SshShell lol = new SshShell("10.10.99.2", "admin");
            lol.Password = "XXXX";
            lol.RedirectToConsole();
            lol.Connect();

            while (lol.ShellOpened)
            {
                System.Threading.Thread.Sleep(500);
            }
            lol.Close();
        }
    }
}
