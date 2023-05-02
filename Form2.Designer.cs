namespace Legitimacija_za_zaposlene
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiFotografijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajLegitimacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akcijaToolStripMenuItem
            // 
            this.akcijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaberiFotografijuToolStripMenuItem,
            this.sacuvajLegitimacijuToolStripMenuItem});
            this.akcijaToolStripMenuItem.Name = "akcijaToolStripMenuItem";
            this.akcijaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.akcijaToolStripMenuItem.Text = "Akcija";
            // 
            // odaberiFotografijuToolStripMenuItem
            // 
            this.odaberiFotografijuToolStripMenuItem.Name = "odaberiFotografijuToolStripMenuItem";
            this.odaberiFotografijuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odaberiFotografijuToolStripMenuItem.Text = "Odaberi fotografiju";
            this.odaberiFotografijuToolStripMenuItem.Click += new System.EventHandler(this.odaberiFotografijuToolStripMenuItem_Click);
            // 
            // sacuvajLegitimacijuToolStripMenuItem
            // 
            this.sacuvajLegitimacijuToolStripMenuItem.Name = "sacuvajLegitimacijuToolStripMenuItem";
            this.sacuvajLegitimacijuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sacuvajLegitimacijuToolStripMenuItem.Text = "Sacuvaj legitimaciju";
            this.sacuvajLegitimacijuToolStripMenuItem.Click += new System.EventHandler(this.sacuvajLegitimacijuToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 512);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Izgled legitimacije";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaberiFotografijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajLegitimacijuToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}