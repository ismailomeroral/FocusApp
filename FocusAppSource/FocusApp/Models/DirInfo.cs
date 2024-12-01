using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusApp.Models
{
    static class DirInfo
    {
        static public string dbPath { get; } = "..\\..\\EntityModels\\WebIPDB.idb"; 
        static public string hostPath { get; } = @"C:\Windows\System32\drivers\etc\hosts";
        static public string hosturl { get; } = "127.0.0.1";
    }
}
