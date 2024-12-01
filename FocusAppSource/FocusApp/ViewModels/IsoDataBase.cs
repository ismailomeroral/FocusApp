using FocusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FocusApp.ViewModels
{
    internal class IsoDataBase
    {
        private string Path;
        private string Name;
        private List<Request> DataList { get; set; }
        public IsoDataBase(string name, string path)
        {
            Path = path;
            Name = name;
            if (path != null)
                DataList = DataController.BreakUpText(DataController.RetrieveTextFromDataBase(Path));
        }
        public List<Request> ToList()
        {
            return DataList;
        }
        public void Add(string address, bool activate)
        {
            if (DataList.Where(b => b.address == address).Count() == 0)
            {
                DataList.Add(new Request { id = LastId() + 1, address = address, activate = activate });
                SaveChanges();
            }
        }
        public int LastId()
        {
            return (DataList.Count > 0 ? DataList.Last().id : 0);
        }
        public void UpdateActivate(int id, bool activate)
        {
            DataList.Where(b => b.id == id).First().activate = activate;
            SaveChanges();
        }
        public void UpdateActivate(string texts, bool activate)
        {
            DataList.Where(b => b.address == texts).First().activate = activate;
            SaveChanges();
        }
        public void Remove(Request request)
        {
            DataList.Remove(request);
            SaveChanges();
        }
        public void Remove(string address)
        {
            DataList.Remove(DataList.Where(b => b.address == address).First());
            SaveChanges();
        }
        public void Remove(int id)
        {
            DataList.Remove(DataList.Where(b => b.id == id).First());
            SaveChanges();
        }
        public bool Search(string values)
        {
            return DataList.Where(b => b.address == values).Count() > 0;
        }
        private void SaveChanges()
        {
            DataController.SaveChanges(DataList, Path);
        }
    }
}
