using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowsFormsApp.CustomTools
{
    public class CustomToolButtons
    {
        public System.Windows.Forms.Form _mainForm { get; set; }
        public Dictionary<string, int> _dic = new Dictionary<string, int>();

        private static CustomToolButtons instance;

        public static CustomToolButtons Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                else
                {
                    instance = new CustomToolButtons();
                    return instance;
                }
            }

            set
            {
                instance = value;
            }
        }
        public void LoadCustomTools(System.Windows.Forms.Form mainForm)
        {
            this._mainForm = mainForm;
            LoadCustomToolButton(ButtonName.GetInfo, GetInfo, null, DrawingModeDef.DM_CUSTOM_POINT, (int)IconDef.MI_CURSOR_HELP);
        }
        public void LoadCustomToolButton(ButtonName buttonName, Action<object> methodName, object commandParam, DrawingModeDef drawingModeDef, int mapCursorId, bool bModifierKey = false)
        {
            _dic.Add(buttonName.ToString(),
                Program.miApplication.RegisterCustomTool(new Button(),
                new DelegateCommand(methodName),
                null,
                (int)drawingModeDef,
                mapCursorId.ToString(),
                bModifierKey));

        }
        public void GetInfo(object param)
        {
            try
            {
                List<CustomListItem> tiklanilanNoktadakiVeriler = new List<CustomListItem>();
                string x = Program.miApplication.EvalMapBasicCommand("commandinfo(1)").Replace(",", ".");
                string y = Program.miApplication.EvalMapBasicCommand("commandinfo(2)").Replace(",", ".");
                int tiklanilanNoktadakiKayitSayisi = Convert.ToInt32(Program.miApplication.EvalMapBasicCommand("SearchPoint(frontwindow()," + x + "," + y + ")"));

                if (tiklanilanNoktadakiKayitSayisi > 0)
                {

                    for (int i = 1; i <= tiklanilanNoktadakiKayitSayisi; i++)
                    {

                        string tabloAdi = Program.miApplication.EvalMapBasicCommand("SearchInfo(" + i.ToString() + ",1)");
                        string rowId = Program.miApplication.EvalMapBasicCommand("SearchInfo(" + i.ToString() + ",2)");
                        Program.miApplication.RunMapBasicCommand("Fetch rec " + rowId + " From " + tabloAdi);
                        if (!tabloAdi.StartsWith("Sel_"))
                        {
                            switch (tabloAdi)
                            {
                                case "SBK_OGHAT":
                                    tiklanilanNoktadakiVeriler.Add(new CustomListItem()
                                    {
                                        Text = tabloAdi + " (" + Program.miApplication.EvalMapBasicCommand(tabloAdi + ".TIPI") + ")",
                                        Value = tabloAdi + "#" + rowId
                                    });
                                    break;
                                default:

                                    break;
                            }
                        }
                    }
                }
                if (tiklanilanNoktadakiVeriler.Count <= 0)
                {
                    System.Windows.Forms.MessageBox.Show(" Tıklanılan Noktada Birşey Bulamadık.");
                }
                else if (tiklanilanNoktadakiVeriler.Count == 1)
                {
                    Program._form.ShowInfo(tiklanilanNoktadakiVeriler[0].Value.ToString());
                }
                else
                {
                    BilgiListe listeForm = new BilgiListe();
                    listeForm.Owner = Program._form;
                    listeForm.listBoxVeriler.Items.Clear();
                    for (int i = 0; i < tiklanilanNoktadakiVeriler.Count; i++)
                    {
                        listeForm.listBoxVeriler.Items.Add(tiklanilanNoktadakiVeriler[i]);
                    }
                    System.Windows.Forms.DialogResult res = listeForm.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        Program._form.ShowInfo(listeForm.SeciliKayit);
                    }
                }
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("Beklenmeyen Bir Hata Oluştu");
            }

        }
    }
}
