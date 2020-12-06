using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.CustomTools
{
    public class CustomListItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public CustomListItem()
        {
            this.Text = string.Empty;
        }
        public CustomListItem(string text , object value)
        {
            Text = text;
            Value = value;

        }
        public override string ToString()
        {
            return Text;
        }
    }
}
