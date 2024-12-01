using FocusApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTrainingApplication.Models.UserControls
{
    public partial class CheckListBox : UserControl
    {
        private List<CheckListItem> Items = new List<CheckListItem>();
        public CheckListBox()
        {
            InitializeComponent();
        }
        bool titleCheck => Title != "";
        [Category("Appearance")]
        public string Title
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }


        public CheckListItem SelectedItem { get; private set; }

        private Color itemBackColor;
        [Category("Appearance")]
        public Color ItemsBackColor { get { return itemBackColor; } set { Items.ForEach(b => b.BackColor = value); itemBackColor = value; } }
        private Color itemCheckedColor;

        [Category("Appearance")]
        public Color CheckedColor { get { return itemCheckedColor; } set { Items.ForEach(b => b.CheckedColor = value); itemCheckedColor = value; } }
        private void ControlToList()
        {
            pnlBody.Controls.Clear();
            pnlTitle.Visible = titleCheck;
            int i = 0;
            foreach (var item in Items)
            {
                item.Location = new Point(5, (i * item.Height) + 10);
                pnlBody.Controls.Add(item);
                item.Check();
                item.BackColor = itemBackColor;
                item.Size = new Size(item.Parent.Width - 10, item.Height);
                item.Click += Item_Click;
                item.MouseClick += Item_Click; ;
                item.ContextMenuStrip = contextMenuStrip1;
                i++;
            }
        }
        public void SelectItem(CheckListItem _item)
        {
            SelectedItem = _item;
        }
        public void Clear()
        {
            Items.Clear();
            ControlToList();
        }

        public void Add(string _text, bool _checked)
        {
            Items.Add(new CheckListItem { Texts = _text, Checked = _checked });
            OnListChanged("Add", Items.Last());
            ControlToList();
        }
        public void Add(string _text)
        {
            Items.Add(new CheckListItem { Texts = _text, Checked = false });
            OnListChanged("Add", Items.Last());
            ControlToList();
        }
        public void Remove(string _text)
        {
            var removedItem = Items.Where(b => b.Texts == _text).First();
            OnListChanged("Remove", removedItem);
            Items.Remove(removedItem);
            ControlToList();
        }
        public void Remove(int _index)
        {
            OnListChanged("Remove", Items[_index]);
            Items.RemoveAt(_index);
            ControlToList();
        }
        public void Remove(bool _checked)
        {
            foreach (var item in Items.Where(b => b.Checked == _checked))
            {
                OnListChanged("Remove", item);
                Items.Remove(item);
            }
            ControlToList();
        }
        public void UpdateItemCheck(string text, CheckListItem item)
        {
            OnListChanged("Update", item);
        }
        public List<string> CheckedToList()
        {
            return Items.Where(b => b.Checked).Select(b => b.Texts).ToList();
        }
        public List<string> UncheckedToList()
        {
            return Items.Where(b => !b.Checked).Select(b => b.Texts).ToList();
        }
        public List<string> ToList()
        {
            return Items.Select(b => b.Texts).ToList();
        }
        private void Item_Click(object sender, EventArgs e)
        {
            SelectedItem = Items.Where(b => b == (sender as CheckListItem)).First();
        }

        private void tSDelete_Click(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                Remove(Items.Where(b => b == SelectedItem).First().Texts);
                SelectedItem = null;
                ControlToList();
            }
        }
        protected virtual void OnListChanged(string action, CheckListItem item)
        {
            ListChanged?.Invoke(this, new ListChangedEventArgs { Action = action, Item = item });
        }


        [Category("Apperance")]
        public event ListChangedEventHandler ListChanged;
    }
    public delegate void ListChangedEventHandler(object sender, ListChangedEventArgs e);
    public class ListChangedEventArgs : EventArgs
    {
        public string Action { get; set; } // "Add", "Remove", vb.
        public object Item { get; set; }  // Eklenen/Çıkarılan öğe
    }
}
