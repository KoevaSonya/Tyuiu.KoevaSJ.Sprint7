
namespace Tyuiu.KoevaSJ.Sprint7.Project.V12
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu_KSJ = new System.Windows.Forms.Panel();
            this.panelDesktop_KSJ = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.buttonAbout_KSJ = new System.Windows.Forms.Button();
            this.buttonProducts_KSJ = new System.Windows.Forms.Button();
            this.panelMenu_KSJ.SuspendLayout();
            this.panelDesktop_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1639, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelMenu_KSJ
            // 
            this.panelMenu_KSJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu_KSJ.Controls.Add(this.buttonHelp_KSJ);
            this.panelMenu_KSJ.Controls.Add(this.buttonAbout_KSJ);
            this.panelMenu_KSJ.Controls.Add(this.buttonProducts_KSJ);
            this.panelMenu_KSJ.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_KSJ.Location = new System.Drawing.Point(0, 100);
            this.panelMenu_KSJ.Name = "panelMenu_KSJ";
            this.panelMenu_KSJ.Size = new System.Drawing.Size(200, 887);
            this.panelMenu_KSJ.TabIndex = 1;
            // 
            // panelDesktop_KSJ
            // 
            this.panelDesktop_KSJ.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop_KSJ.Controls.Add(this.pictureBox1);
            this.panelDesktop_KSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop_KSJ.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop_KSJ.Name = "panelDesktop_KSJ";
            this.panelDesktop_KSJ.Size = new System.Drawing.Size(1439, 887);
            this.panelDesktop_KSJ.TabIndex = 2;
            this.panelDesktop_KSJ.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProduct_KSJ_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.KoevaSJ.Sprint7.Project.V12.Properties.Resources.snapedit_1703525492615;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1439, 887);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint7.Project.V12.Properties.Resources.cog;
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(3, 325);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(194, 72);
            this.buttonHelp_KSJ.TabIndex = 2;
            this.buttonHelp_KSJ.Text = " Помощь";
            this.buttonHelp_KSJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp_KSJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp_KSJ.UseVisualStyleBackColor = false;
            this.buttonHelp_KSJ.Click += new System.EventHandler(this.buttonHelp_KSJ_Click);
            // 
            // buttonAbout_KSJ
            // 
            this.buttonAbout_KSJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAbout_KSJ.FlatAppearance.BorderSize = 0;
            this.buttonAbout_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint7.Project.V12.Properties.Resources.bell;
            this.buttonAbout_KSJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout_KSJ.Location = new System.Drawing.Point(3, 188);
            this.buttonAbout_KSJ.Name = "buttonAbout_KSJ";
            this.buttonAbout_KSJ.Size = new System.Drawing.Size(194, 72);
            this.buttonAbout_KSJ.TabIndex = 1;
            this.buttonAbout_KSJ.Text = " О нас";
            this.buttonAbout_KSJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout_KSJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout_KSJ.UseVisualStyleBackColor = false;
            this.buttonAbout_KSJ.Click += new System.EventHandler(this.buttonAbout_KSJ_Click);
            // 
            // buttonProducts_KSJ
            // 
            this.buttonProducts_KSJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProducts_KSJ.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonProducts_KSJ.FlatAppearance.BorderSize = 0;
            this.buttonProducts_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint7.Project.V12.Properties.Resources.basket;
            this.buttonProducts_KSJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts_KSJ.Location = new System.Drawing.Point(3, 57);
            this.buttonProducts_KSJ.Name = "buttonProducts_KSJ";
            this.buttonProducts_KSJ.Size = new System.Drawing.Size(194, 72);
            this.buttonProducts_KSJ.TabIndex = 0;
            this.buttonProducts_KSJ.Text = " Товары";
            this.buttonProducts_KSJ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts_KSJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProducts_KSJ.UseVisualStyleBackColor = false;
            this.buttonProducts_KSJ.Click += new System.EventHandler(this.buttonProducts_KSJ_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 987);
            this.Controls.Add(this.panelDesktop_KSJ);
            this.Controls.Add(this.panelMenu_KSJ);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu_KSJ.ResumeLayout(false);
            this.panelDesktop_KSJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu_KSJ;
        private System.Windows.Forms.Button buttonProducts_KSJ;
        private System.Windows.Forms.Panel panelDesktop_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonAbout_KSJ;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

