
namespace WindowsFormsApp
{
    partial class BilgiListe
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
            this.listBoxVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxVeriler
            // 
            this.listBoxVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxVeriler.FormattingEnabled = true;
            this.listBoxVeriler.Location = new System.Drawing.Point(0, 0);
            this.listBoxVeriler.Name = "listBoxVeriler";
            this.listBoxVeriler.Size = new System.Drawing.Size(325, 450);
            this.listBoxVeriler.TabIndex = 0;
            this.listBoxVeriler.SelectedIndexChanged += new System.EventHandler(this.listBoxVeriler_SelectedIndexChanged);
            // 
            // BilgiListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.listBoxVeriler);
            this.Name = "BilgiListe";
            this.Text = "BilgiListe";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxVeriler;
    }
}