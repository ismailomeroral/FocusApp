using FocusApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FocusApp.ViewModels
{
    internal class DataController
    {
     
        private static List<string> patternList = new List<string>
        {
            @"<request>(.*?)</request>",
            @"<id>(.*?)</id>",
            @"<address>(.*?)</address>",
            @"<activate>(.*?)</activate>",
        };
        public static string RetrieveTextFromDataBase(string path)
        {
            return File.ReadAllText(path, Encoding.UTF8).Trim();
        }
        public static List<Request> BreakUpText(string text)
        {
            var requestList = Regex.Matches(text, patternList[0], RegexOptions.IgnoreCase | RegexOptions.Singleline);
            List<Request> list = new List<Request>();
            foreach (Match request in requestList)
            {
                string id = Regex.Match(request.Groups[1].Value, patternList[1]).Groups[1].Value;
                string address = Regex.Match(request.Groups[1].Value, patternList[2]).Groups[1].Value;
                string activate = Regex.Match(request.Groups[1].Value, patternList[3]).Groups[1].Value;
                list.Add(new Request { id = int.Parse(id), address = address, activate = bool.Parse(activate) });
            }
            return list;
        }
        public static void SaveChanges(List<Request> list, string path)
        {
            string dbSaveText = "";
            foreach (var request in list) 
            {
                string requestbody = $"<request>\n" +
                                     $"   <id>{request.id}</id>\n" +
                                     $"   <address>{request.address}</address>\n" +
                                     $"   <activate>{request.activate}</activate>\n" +
                                     $"</request>\n";
                dbSaveText += requestbody;
            }
            File.WriteAllText(path, dbSaveText);
        }
    }
}
