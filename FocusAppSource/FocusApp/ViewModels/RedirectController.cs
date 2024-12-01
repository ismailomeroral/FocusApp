using FocusApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusApp.ViewModels
{
    static internal class RedirectController
    {
        static string defaultHostContext = "# Copyright (c) 1993-2009 Microsoft Corp.\r\n#\r\n# " +
              "This is a sample HOSTS file used by Microsoft TCP/IP for Windows.\r\n#\r\n# " +
              "This file contains the mappings of IP addresses to host names. Each\r\n#" +
              " entry should be kept on an individual line. The IP address should\r\n#" +
              " be placed in the first column followed by the corresponding host name.\r\n#" +
              " The IP address and the host name should be separated by at least one\r\n#" +
              " space.\r\n#\r\n# Additionally, comments (such as these) may be inserted on individual\r\n# " +
              "lines or following the machine name denoted by a '#' symbol.\r\n#\r\n# For example:\r\n#\r\n#  " +
              "    102.54.94.97     rhino.acme.com         " +
              " # source server\r\n#     " +
              "  38.25.63.10     x.acme.com            " +
              "  # x client host\r\n\r\n# localhost name resolution is handled within DNS itself." +
              "\r\n#\t127.0.0.1   " +
              "    localhost\r\n#\t::1    " +
              "         localhost\r\n";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_processes">List of transactions to be restricted</param>
        static public void StartRestrictiveProcess(List<string> _processes)
        {
            WriteWebProcess(_processes);

        }
        static public void FinishRestrictiveProcess()
        {
            ClearProcess();
        }

        static private void WriteWebProcess(List<string> addresses)
        {
            if (File.Exists(DirInfo.hostPath))
            {
                string text = "";
                foreach (string item in addresses)
                    text += DirInfo.hosturl + " " + item + "\n";

                File.WriteAllText(DirInfo.hostPath,text);
            }

        }
        static private void ClearProcess()
        {
            if (File.Exists(DirInfo.hostPath))
                File.WriteAllText(DirInfo.hostPath, defaultHostContext);
        }

    }
}
