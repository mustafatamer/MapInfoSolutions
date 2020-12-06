
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tpDosya = new System.Windows.Forms.TabPage();
            this.tsDosya = new System.Windows.Forms.ToolStrip();
            this.btnWorkspaceAc = new System.Windows.Forms.ToolStripButton();
            this.btnTabloAc = new System.Windows.Forms.ToolStripButton();
            this.btnTabloKapat = new System.Windows.Forms.ToolStripButton();
            this.btnTumTablolariKapat = new System.Windows.Forms.ToolStripButton();
            this.tpHaritaAraclari = new System.Windows.Forms.TabPage();
            this.tsHaritaAraclari = new System.Windows.Forms.ToolStrip();
            this.tsbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPan = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tpDosya.SuspendLayout();
            this.tsDosya.SuspendLayout();
            this.tpHaritaAraclari.SuspendLayout();
            this.tsHaritaAraclari.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tabControlMenu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(794, 80);
            this.panelTop.TabIndex = 0;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tpDosya);
            this.tabControlMenu.Controls.Add(this.tpHaritaAraclari);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(794, 80);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tpDosya
            // 
            this.tpDosya.Controls.Add(this.tsDosya);
            this.tpDosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDosya.Location = new System.Drawing.Point(4, 22);
            this.tpDosya.Name = "tpDosya";
            this.tpDosya.Padding = new System.Windows.Forms.Padding(3);
            this.tpDosya.Size = new System.Drawing.Size(786, 54);
            this.tpDosya.TabIndex = 1;
            this.tpDosya.Text = "Dosya";
            this.tpDosya.UseVisualStyleBackColor = true;
            // 
            // tsDosya
            // 
            this.tsDosya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsDosya.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWorkspaceAc,
            this.btnTabloAc,
            this.btnTabloKapat,
            this.btnTumTablolariKapat});
            this.tsDosya.Location = new System.Drawing.Point(3, 3);
            this.tsDosya.Name = "tsDosya";
            this.tsDosya.Size = new System.Drawing.Size(780, 48);
            this.tsDosya.TabIndex = 0;
            this.tsDosya.Text = "Dosya";
            // 
            // btnWorkspaceAc
            // 
            this.btnWorkspaceAc.AutoSize = false;
            this.btnWorkspaceAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWorkspaceAc.BackgroundImage")));
            this.btnWorkspaceAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWorkspaceAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.btnWorkspaceAc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkspaceAc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnWorkspaceAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkspaceAc.Name = "btnWorkspaceAc";
            this.btnWorkspaceAc.Size = new System.Drawing.Size(47, 47);
            this.btnWorkspaceAc.Text = "Workspace Aç";
            this.btnWorkspaceAc.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnWorkspaceAc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnWorkspaceAc.Click += new System.EventHandler(this.WorkspaceAc_Click);
            // 
            // btnTabloAc
            // 
            this.btnTabloAc.AutoSize = false;
            this.btnTabloAc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTabloAc.BackgroundImage")));
            this.btnTabloAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTabloAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTabloAc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabloAc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTabloAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTabloAc.Name = "btnTabloAc";
            this.btnTabloAc.Size = new System.Drawing.Size(47, 47);
            this.btnTabloAc.Text = "Tablo Aç";
            this.btnTabloAc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabloAc.Click += new System.EventHandler(this.TabloAc_Click);
            // 
            // btnTabloKapat
            // 
            this.btnTabloKapat.AutoSize = false;
            this.btnTabloKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTabloKapat.BackgroundImage")));
            this.btnTabloKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTabloKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTabloKapat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabloKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTabloKapat.Name = "btnTabloKapat";
            this.btnTabloKapat.Size = new System.Drawing.Size(47, 47);
            this.btnTabloKapat.Text = "Tablo Kapat";
            this.btnTabloKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabloKapat.Click += new System.EventHandler(this.TabloKapat_Click);
            // 
            // btnTumTablolariKapat
            // 
            this.btnTumTablolariKapat.AutoSize = false;
            this.btnTumTablolariKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTumTablolariKapat.BackgroundImage")));
            this.btnTumTablolariKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTumTablolariKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTumTablolariKapat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumTablolariKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTumTablolariKapat.Name = "btnTumTablolariKapat";
            this.btnTumTablolariKapat.Size = new System.Drawing.Size(47, 47);
            this.btnTumTablolariKapat.Text = "Tüm Tabloları Kapat";
            this.btnTumTablolariKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTumTablolariKapat.Click += new System.EventHandler(this.TumTablolariKapat_Click);
            // 
            // tpHaritaAraclari
            // 
            this.tpHaritaAraclari.Controls.Add(this.tsHaritaAraclari);
            this.tpHaritaAraclari.Location = new System.Drawing.Point(4, 22);
            this.tpHaritaAraclari.Name = "tpHaritaAraclari";
            this.tpHaritaAraclari.Padding = new System.Windows.Forms.Padding(3);
            this.tpHaritaAraclari.Size = new System.Drawing.Size(786, 54);
            this.tpHaritaAraclari.TabIndex = 2;
            this.tpHaritaAraclari.Text = "Harita Araçları";
            this.tpHaritaAraclari.UseVisualStyleBackColor = true;
            // 
            // tsHaritaAraclari
            // 
            this.tsHaritaAraclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsHaritaAraclari.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSelect,
            this.tsbtnPan,
            this.tsbtnZoomOut,
            this.tsbtnZoomIn,
            this.tsbtnInfo});
            this.tsHaritaAraclari.Location = new System.Drawing.Point(3, 3);
            this.tsHaritaAraclari.Name = "tsHaritaAraclari";
            this.tsHaritaAraclari.Size = new System.Drawing.Size(780, 48);
            this.tsHaritaAraclari.TabIndex = 0;
            this.tsHaritaAraclari.Text = "Harita Araçları";
            // 
            // tsbtnSelect
            // 
            this.tsbtnSelect.AutoSize = false;
            this.tsbtnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnSelect.BackgroundImage")));
            this.tsbtnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSelect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelect.Name = "tsbtnSelect";
            this.tsbtnSelect.Size = new System.Drawing.Size(47, 47);
            this.tsbtnSelect.Text = "toolStripButton1";
            this.tsbtnSelect.Click += new System.EventHandler(this.tsbtnSelect_Click);
            // 
            // tsbtnPan
            // 
            this.tsbtnPan.AutoSize = false;
            this.tsbtnPan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnPan.BackgroundImage")));
            this.tsbtnPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPan.Name = "tsbtnPan";
            this.tsbtnPan.Size = new System.Drawing.Size(47, 47);
            this.tsbtnPan.Text = "toolStripButton2";
            this.tsbtnPan.Click += new System.EventHandler(this.tsbtnPan_Click);
            // 
            // tsbtnZoomOut
            // 
            this.tsbtnZoomOut.AutoSize = false;
            this.tsbtnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomOut.BackgroundImage")));
            this.tsbtnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnZoomOut.Name = "tsbtnZoomOut";
            this.tsbtnZoomOut.Size = new System.Drawing.Size(47, 47);
            this.tsbtnZoomOut.Text = "Uzaklaş";
            this.tsbtnZoomOut.Click += new System.EventHandler(this.tsbtnZoomOut_Click);
            // 
            // tsbtnZoomIn
            // 
            this.tsbtnZoomIn.AutoSize = false;
            this.tsbtnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomIn.BackgroundImage")));
            this.tsbtnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnZoomIn.Name = "tsbtnZoomIn";
            this.tsbtnZoomIn.Size = new System.Drawing.Size(47, 47);
            this.tsbtnZoomIn.Text = "Yakınlaş";
            this.tsbtnZoomIn.Click += new System.EventHandler(this.tsbtnZoomIn_Click);
            // 
            // tsbtnInfo
            // 
            this.tsbtnInfo.AutoSize = false;
            this.tsbtnInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnInfo.BackgroundImage")));
            this.tsbtnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tsbtnInfo.Name = "tsbtnInfo";
            this.tsbtnInfo.Size = new System.Drawing.Size(47, 47);
            this.tsbtnInfo.Text = "Bilgi Al";
            this.tsbtnInfo.Click += new System.EventHandler(this.tsbtnInfo_Click);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(3, 89);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(794, 318);
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
            this.tabControlMenu.ResumeLayout(false);
            this.tpDosya.ResumeLayout(false);
            this.tpDosya.PerformLayout();
            this.tsDosya.ResumeLayout(false);
            this.tsDosya.PerformLayout();
            this.tpHaritaAraclari.ResumeLayout(false);
            this.tpHaritaAraclari.PerformLayout();
            this.tsHaritaAraclari.ResumeLayout(false);
            this.tsHaritaAraclari.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tpDosya;
        private System.Windows.Forms.ToolStrip tsDosya;
        private System.Windows.Forms.ToolStripButton btnWorkspaceAc;
        private System.Windows.Forms.ToolStripButton btnTabloAc;
        private System.Windows.Forms.ToolStripButton btnTabloKapat;
        private System.Windows.Forms.ToolStripButton btnTumTablolariKapat;
        private System.Windows.Forms.TabPage tpHaritaAraclari;
        private System.Windows.Forms.ToolStrip tsHaritaAraclari;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.ToolStripButton tsbtnPan;
        private System.Windows.Forms.ToolStripButton tsbtnZoomOut;
        private System.Windows.Forms.ToolStripButton tsbtnZoomIn;
        private System.Windows.Forms.ToolStripButton tsbtnInfo;
    }
}

