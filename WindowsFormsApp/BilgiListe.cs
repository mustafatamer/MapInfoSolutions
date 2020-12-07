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
      
    }
}
