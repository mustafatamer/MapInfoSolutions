using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

using MapInfo.Application;
using MapInfo.Commands;
using MapInfo.Types;

namespace WindowsFormsApp
{
    public partial class Form1 : Form, IIntegratedMappingApplication
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetActiveWindow(IWindowInfo win, bool internalUse = true)
        {
           // throw new NotImplementedException();
        }

        public void SetNextActiveWindow()
        {
           // throw new NotImplementedException();
        }

        public void WindowCreated(IWindowInfo window, IEnumerable<KeyValuePair<string, string>> properties)
        {
            var wi = window as MapInfo.Types.WindowInfo;
            if (wi == null)
                return;
            var ctrl = new ElementHost
            {
                Child = wi.UserControl,
                Dock = DockStyle.Fill
            };
            if (wi.IsDocumentWindow)
            {
                panelMap.Tag = wi.WindowId;
                panelMap.Controls.Add(ctrl);
            }
        }

        public void PreviewWindowClosed(IWindowInfo window)
        {
           // throw new NotImplementedException();
        }

        public void WindowClosed(IWindowInfo window)
        {
           // throw new NotImplementedException();
        }

        public void WindowShowing(IWindowInfo window, bool bShow)
        {
           // throw new NotImplementedException();
        }

        public void ShowNotification(string message, System.Windows.Point location, int timeToShow = 2500)
        {
            //throw new NotImplementedException();
        }

        public void SetApplicationTitle(string title)
        {
           // throw new NotImplementedException();
        }

        public void SetApplicationIcon(Uri icon)
        {
           // throw new NotImplementedException();
        }

        public void SetWindowProperty(IWindowInfo win, WindowProps property, string value)
        {
           // throw new NotImplementedException();
        }

        public TReturnType GetWindowProperty<TReturnType>(IWindowInfo win, WindowProps property)
        {
            return default(TReturnType);
        }

        public Rect GetApplicationClientRect()
        {
            return default(Rect);
        }

        public IWindowInfo FrontDocumentWindow { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IWindowInfo ActiveWindow => default(IWindowInfo); // throw new NotImplementedException();

        public bool IsApplicationClosing => default(bool); //throw new NotImplementedException();

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.miApplication = MapInfoCore.Initialize(Handle, this);
            string WorkSpacePath = System.Windows.Forms.Application.StartupPath + @"\MI_DATA\DefaultMI.WOR";
            Program.miApplication.RunMapBasicCommand("Run application \"" + WorkSpacePath + "\"");
        }

        public void ExecuteCommand(MapInfoCommand cmd , object sender)
        {
            if (cmd.CanExecute(sender , null))
            {
                cmd.Execute(sender, null);
            }
        }
  

        private void TabloAc_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.OpenTable, sender);
        }

        private void buttonTumTablolariKapat_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseAll, sender);
        }

        private void buttonTabloKapat_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseTable, sender);
        }

        private void WorkspaceAc_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.OpenWorkspace, sender);
        }
    }
}
