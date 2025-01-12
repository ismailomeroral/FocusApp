using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FocusApp.ViewModels.Style_Models
{
    internal class SingleDataBase
    {
        string Path;
        private static List<string> patternList = new List<string>
        {
            @"<type>(.*?)</type>",
            @"<hour>(.*?)</hour>",
            @"<minute>(.*?)</minute>",
            @"<second>(.*?)</second>",
            @"<working>(.*?)</working>",
        };
        public SingleDataBase(string path)
        {
            Path = path;
        }
        public void Update((int hour, int minute, int second) _time, string _type, bool _working)
        {

            string text = $"<type>{_type}</type>\n<hour>{_time.hour}</hour>\n<minute>{_time.minute}</minute>\n<second>{_time.second}</second>\n<working>{_working}</working>";
            DataController.SaveChanges(text, Path);

        }
        public ((int hour, int minute, int second) time, string type, bool working) Select()
        {
            string dbText = DataController.RetrieveTextFromDataBase(Path);

            string type = DataController.FindByPattern(dbText, patternList[0]);
            int hour = int.Parse(DataController.FindByPattern(dbText, patternList[1]));
            int minute = int.Parse(DataController.FindByPattern(dbText, patternList[2]));
            int second = int.Parse(DataController.FindByPattern(dbText, patternList[3]));
            bool working = bool.Parse(DataController.FindByPattern(dbText, patternList[4]));

            return ((hour, minute, second), type, working);
        }

    }
}
