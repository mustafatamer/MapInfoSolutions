using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class BilgiListe : Form
    {
        public string SeciliKayit { get; set; }
        public BilgiListe()
        {
            InitializeComponent();
        }

        private void listBoxVeriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVeriler.SelectedIndex >= 0)
                {
                    CustomTools.CustomListItem secili = (CustomTools.CustomListItem)listBoxVeriler.Items[listBoxVeriler.SelectedIndex];
                    if (secili != null )
                    {
                        this.SeciliKayit = secili.Value.ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ShowInfo(string key)
        {
            if (key.Split('#').Length == 2)
            {
                string tabloAdi = key.Split('#')[0];
                string rowId = key.Split('#')[1];
                switch (key)
                {
                    case "SBK_OGHAT":
                        System.Windows.Forms.MessageBox.Show("SBK_OGHAT");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
