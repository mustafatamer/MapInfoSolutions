
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonWorkSpaceAc = new System.Windows.Forms.Button();
            this.buttonTabloAc = new System.Windows.Forms.Button();
            this.tabControlDosya = new System.Windows.Forms.TabControl();
            this.buttonTumTablolariKapat = new System.Windows.Forms.Button();
            this.buttonTabloKapat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlDosya.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tabControlDosya);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(794, 94);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelMap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(3, 103);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(794, 304);
            this.panelMap.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 413);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(794, 34);
            this.panelBottom.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonTabloKapat);
            this.tabPage1.Controls.Add(this.buttonTumTablolariKapat);
            this.tabPage1.Controls.Add(this.buttonTabloAc);
            this.tabPage1.Controls.Add(this.buttonWorkSpaceAc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 68);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dosya";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonWorkSpaceAc
            // 
            this.buttonWorkSpaceAc.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorkSpaceAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWorkSpaceAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkSpaceAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWorkSpaceAc.Image = ((System.Drawing.Image)(resources.GetObject("buttonWorkSpaceAc.Image")));
            this.buttonWorkSpaceAc.Location = new System.Drawing.Point(3, 2);
            this.buttonWorkSpaceAc.Name = "buttonWorkSpaceAc";
            this.buttonWorkSpaceAc.Size = new System.Drawing.Size(77, 65);
            this.buttonWorkSpaceAc.TabIndex = 0;
            this.buttonWorkSpaceAc.Text = "workspace aç";
            this.buttonWorkSpaceAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWorkSpaceAc.UseVisualStyleBackColor = false;
            this.buttonWorkSpaceAc.Click += new System.EventHandler(this.buttonWorkSpaceAc_Click);
            // 
            // buttonTabloAc
            // 
            this.buttonTabloAc.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabloAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTabloAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabloAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTabloAc.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabloAc.Image")));
            this.buttonTabloAc.Location = new System.Drawing.Point(80, 2);
            this.buttonTabloAc.Name = "buttonTabloAc";
            this.buttonTabloAc.Size = new System.Drawing.Size(77, 65);
            this.buttonTabloAc.TabIndex = 1;
            this.buttonTabloAc.Text = "Tablo Aç";
            this.buttonTabloAc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTabloAc.UseVisualStyleBackColor = false;
            this.buttonTabloAc.Click += new System.EventHandler(this.buttonTabloAc_Click);
            // 
            // tabControlDosya
            // 
            this.tabControlDosya.Controls.Add(this.tabPage1);
            this.tabControlDosya.Controls.Add(this.tabPage2);
            this.tabControlDosya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDosya.Location = new System.Drawing.Point(0, 0);
            this.tabControlDosya.Name = "tabControlDosya";
            this.tabControlDosya.SelectedIndex = 0;
            this.tabControlDosya.Size = new System.Drawing.Size(794, 94);
            this.tabControlDosya.TabIndex = 0;
            // 
            // buttonTumTablolariKapat
            // 
            this.buttonTumTablolariKapat.BackColor = System.Drawing.Color.Transparent;
            this.buttonTumTablolariKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTumTablolariKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTumTablolariKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTumTablolariKapat.Image = ((System.Drawing.Image)(resources.GetObject("buttonTumTablolariKapat.Image")));
            this.buttonTumTablolariKapat.Location = new System.Drawing.Point(157, 2);
            this.buttonTumTablolariKapat.Name = "buttonTumTablolariKapat";
            this.buttonTumTablolariKapat.Size = new System.Drawing.Size(77, 65);
            this.buttonTumTablolariKapat.TabIndex = 1;
            this.buttonTumTablolariKapat.Text = "Tüm Tabloları Kapat";
            this.buttonTumTablolariKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTumTablolariKapat.UseVisualStyleBackColor = false;
            this.buttonTumTablolariKapat.Click += new System.EventHandler(this.buttonTumTablolariKapat_Click);
            // 
            // buttonTabloKapat
            // 
            this.buttonTabloKapat.BackColor = System.Drawing.Color.Transparent;
            this.buttonTabloKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTabloKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabloKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTabloKapat.Image = ((System.Drawing.Image)(resources.GetObject("buttonTabloKapat.Image")));
            this.buttonTabloKapat.Location = new System.Drawing.Point(234, 2);
            this.buttonTabloKapat.Name = "buttonTabloKapat";
            this.buttonTabloKapat.Size = new System.Drawing.Size(77, 65);
            this.buttonTabloKapat.TabIndex = 1;
            this.buttonTabloKapat.Text = "Tablo Kapat";
            this.buttonTabloKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTabloKapat.UseVisualStyleBackColor = false;
            this.buttonTabloKapat.Click += new System.EventHandler(this.buttonTabloKapat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 68);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Harita Araçları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "workspace aç";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(86, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "workspace aç";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(169, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "workspace aç";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(252, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "workspace aç";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(335, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "workspace aç";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControlDosya.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControlDosya;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonTabloKapat;
        private System.Windows.Forms.Button buttonTumTablolariKapat;
        private System.Windows.Forms.Button buttonTabloAc;
        private System.Windows.Forms.Button buttonWorkSpaceAc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

