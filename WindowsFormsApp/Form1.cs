﻿using System;
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

using EDABIS2.MapInfoHelper;

using MapInfo.Application;
using MapInfo.Commands;
using MapInfo.Types;

using WindowsFormsApp.CustomTools;

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
            window.Close();
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

            MapInfoCore.StartUp(new string[1]
         {
                "-automation"
         });

         
            Program.miApplication = MapInfoCore.Initialize(Handle, this);
            MapInfoClass.Instance = new MapInfoClass(Program.miApplication);
            if (MapInfoClass.Instance.miApp == null)
            {
                throw new ApplicationException();
            }
            string WorkSpacePath = System.Windows.Forms.Application.StartupPath + @"\MI_DATA\DefaultMI.WOR";
            Program.miApplication.RunMapBasicCommand("Run application \"" + WorkSpacePath + "\"");
            CustomToolButtons.Instance.LoadCustomTools(this);
        }

        public void ExecuteCommand(MapInfoCommand cmd, object sender)
        {
            if (cmd.CanExecute(sender, null))
            {
                cmd.Execute(sender, null);
            }
        }


        private void TabloAc_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.OpenTable, sender);
        }

        private void TumTablolariKapat_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseAll, sender);
        }

        private void TabloKapat_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseTable, sender);
        }

        private void WorkspaceAc_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.OpenWorkspace, sender);
        }

        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.Select, sender);
        }

        private void tsbtnPan_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.Recenter, sender);
        }

        private void tsbtnZoomOut_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.ZoomOut, sender);
        }

        private void tsbtnZoomIn_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.ZoomIn, sender);
        }

        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetInfo(sender);
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

        public void ShowNotification(string message, System.Windows.Point location, int timeToShow = 2500, bool addToList = false)
        {
            throw new NotImplementedException();
        }

        public string[] GetStatusFieldText(int field = -1)
        {
            throw new NotImplementedException();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TestEdabis testEdabis = new TestEdabis();
        }
    }
}
