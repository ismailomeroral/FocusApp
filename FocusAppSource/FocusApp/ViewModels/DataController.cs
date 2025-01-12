using FocusApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FocusApp.ViewModels
{
    internal class DataController
    {
     
        public static string RetrieveTextFromDataBase(string path)
        {
            return File.ReadAllText(path, Encoding.UTF8).Trim();
        }
        public static List<string> ListByPattern(string text, string pattern)
        {
            List<string> list = Regex.Matches(text, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline)
        .Cast<Match>()
        .Select(m => m.Groups[1].Value)
        .ToList();
            return list;
        }
        public static string FindByPattern(string text, string pattern)
        {
            return Regex.Match(text, pattern).Groups[1].Value;

        }
        public static void SaveChanges( string saveBody, string path)
        {
            File.WriteAllText(path, saveBody);
        }
    }
}
