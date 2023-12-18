
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
            this.panelProduct_KSJ = new System.Windows.Forms.Panel();
            this.buttonProducts_KSJ = new System.Windows.Forms.Button();
            this.buttonAbout_KSJ = new System.Windows.Forms.Button();
            this.buttonHelp_KSJ = new System.Windows.Forms.Button();
            this.textBoxModel_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxMaker_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxColour_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxProcessor_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxPCS_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxHD_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxMemory_KSJ = new System.Windows.Forms.TextBox();
            this.textBoxDate_KSJ = new System.Windows.Forms.TextBox();
            this.labelModel_KSJ = new System.Windows.Forms.Label();
            this.labelMaker_KSJ = new System.Windows.Forms.Label();
            this.labelColour_KSJ = new System.Windows.Forms.Label();
            this.labelProcessor_KSJ = new System.Windows.Forms.Label();
            this.labelPCS_KSJ = new System.Windows.Forms.Label();
            this.labelMemory_KSJ = new System.Windows.Forms.Label();
            this.labelHD_KSJ = new System.Windows.Forms.Label();
            this.labelDate_KSJ = new System.Windows.Forms.Label();
            this.dataGridViewTable_KSJ = new System.Windows.Forms.DataGridView();
            this.panelMenu_KSJ.SuspendLayout();
            this.panelProduct_KSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1574, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelMenu_KSJ
            // 
            this.panelMenu_KSJ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMenu_KSJ.Controls.Add(this.buttonHelp_KSJ);
            this.panelMenu_KSJ.Controls.Add(this.buttonAbout_KSJ);
            this.panelMenu_KSJ.Controls.Add(this.buttonProducts_KSJ);
            this.panelMenu_KSJ.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_KSJ.Location = new System.Drawing.Point(0, 100);
            this.panelMenu_KSJ.Name = "panelMenu_KSJ";
            this.panelMenu_KSJ.Size = new System.Drawing.Size(200, 819);
            this.panelMenu_KSJ.TabIndex = 1;
            // 
            // panelProduct_KSJ
            // 
            this.panelProduct_KSJ.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelProduct_KSJ.Controls.Add(this.dataGridViewTable_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelDate_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelHD_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelMemory_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelPCS_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelProcessor_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelColour_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelMaker_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.labelModel_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxDate_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxProcessor_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxMemory_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxHD_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxMaker_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxPCS_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxColour_KSJ);
            this.panelProduct_KSJ.Controls.Add(this.textBoxModel_KSJ);
            this.panelProduct_KSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct_KSJ.Location = new System.Drawing.Point(200, 100);
            this.panelProduct_KSJ.Name = "panelProduct_KSJ";
            this.panelProduct_KSJ.Size = new System.Drawing.Size(1374, 819);
            this.panelProduct_KSJ.TabIndex = 2;
            this.panelProduct_KSJ.Visible = false;
            // 
            // buttonProducts_KSJ
            // 
            this.buttonProducts_KSJ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProducts_KSJ.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonProducts_KSJ.FlatAppearance.BorderSize = 0;
            this.buttonProducts_KSJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts_KSJ.Location = new System.Drawing.Point(33, 57);
            this.buttonProducts_KSJ.Name = "buttonProducts_KSJ";
            this.buttonProducts_KSJ.Size = new System.Drawing.Size(105, 72);
            this.buttonProducts_KSJ.TabIndex = 0;
            this.buttonProducts_KSJ.Text = "Товары";
            this.buttonProducts_KSJ.UseVisualStyleBackColor = false;
            this.buttonProducts_KSJ.Click += new System.EventHandler(this.buttonProducts_KSJ_Click);
            // 
            // buttonAbout_KSJ
            // 
            this.buttonAbout_KSJ.Location = new System.Drawing.Point(33, 167);
            this.buttonAbout_KSJ.Name = "buttonAbout_KSJ";
            this.buttonAbout_KSJ.Size = new System.Drawing.Size(105, 72);
            this.buttonAbout_KSJ.TabIndex = 1;
            this.buttonAbout_KSJ.Text = "О нас";
            this.buttonAbout_KSJ.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_KSJ
            // 
            this.buttonHelp_KSJ.Location = new System.Drawing.Point(33, 295);
            this.buttonHelp_KSJ.Name = "buttonHelp_KSJ";
            this.buttonHelp_KSJ.Size = new System.Drawing.Size(105, 72);
            this.buttonHelp_KSJ.TabIndex = 2;
            this.buttonHelp_KSJ.Text = "Помощь";
            this.buttonHelp_KSJ.UseVisualStyleBackColor = true;
            // 
            // textBoxModel_KSJ
            // 
            this.textBoxModel_KSJ.Location = new System.Drawing.Point(91, 97);
            this.textBoxModel_KSJ.Name = "textBoxModel_KSJ";
            this.textBoxModel_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxModel_KSJ.TabIndex = 0;
            // 
            // textBoxMaker_KSJ
            // 
            this.textBoxMaker_KSJ.Location = new System.Drawing.Point(91, 188);
            this.textBoxMaker_KSJ.Name = "textBoxMaker_KSJ";
            this.textBoxMaker_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxMaker_KSJ.TabIndex = 0;
            // 
            // textBoxColour_KSJ
            // 
            this.textBoxColour_KSJ.Location = new System.Drawing.Point(91, 265);
            this.textBoxColour_KSJ.Name = "textBoxColour_KSJ";
            this.textBoxColour_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxColour_KSJ.TabIndex = 0;
            // 
            // textBoxProcessor_KSJ
            // 
            this.textBoxProcessor_KSJ.Location = new System.Drawing.Point(91, 336);
            this.textBoxProcessor_KSJ.Name = "textBoxProcessor_KSJ";
            this.textBoxProcessor_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxProcessor_KSJ.TabIndex = 0;
            // 
            // textBoxPCS_KSJ
            // 
            this.textBoxPCS_KSJ.Location = new System.Drawing.Point(91, 409);
            this.textBoxPCS_KSJ.Name = "textBoxPCS_KSJ";
            this.textBoxPCS_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxPCS_KSJ.TabIndex = 0;
            // 
            // textBoxHD_KSJ
            // 
            this.textBoxHD_KSJ.Location = new System.Drawing.Point(91, 564);
            this.textBoxHD_KSJ.Name = "textBoxHD_KSJ";
            this.textBoxHD_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxHD_KSJ.TabIndex = 0;
            // 
            // textBoxMemory_KSJ
            // 
            this.textBoxMemory_KSJ.Location = new System.Drawing.Point(91, 488);
            this.textBoxMemory_KSJ.Name = "textBoxMemory_KSJ";
            this.textBoxMemory_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxMemory_KSJ.TabIndex = 0;
            // 
            // textBoxDate_KSJ
            // 
            this.textBoxDate_KSJ.Location = new System.Drawing.Point(91, 640);
            this.textBoxDate_KSJ.Name = "textBoxDate_KSJ";
            this.textBoxDate_KSJ.Size = new System.Drawing.Size(100, 31);
            this.textBoxDate_KSJ.TabIndex = 0;
            // 
            // labelModel_KSJ
            // 
            this.labelModel_KSJ.AutoSize = true;
            this.labelModel_KSJ.Location = new System.Drawing.Point(91, 66);
            this.labelModel_KSJ.Name = "labelModel_KSJ";
            this.labelModel_KSJ.Size = new System.Drawing.Size(89, 25);
            this.labelModel_KSJ.TabIndex = 1;
            this.labelModel_KSJ.Text = "Модель";
            // 
            // labelMaker_KSJ
            // 
            this.labelMaker_KSJ.AutoSize = true;
            this.labelMaker_KSJ.Location = new System.Drawing.Point(91, 160);
            this.labelMaker_KSJ.Name = "labelMaker_KSJ";
            this.labelMaker_KSJ.Size = new System.Drawing.Size(154, 25);
            this.labelMaker_KSJ.TabIndex = 1;
            this.labelMaker_KSJ.Text = "Изготовитель ";
            // 
            // labelColour_KSJ
            // 
            this.labelColour_KSJ.AutoSize = true;
            this.labelColour_KSJ.Location = new System.Drawing.Point(91, 237);
            this.labelColour_KSJ.Name = "labelColour_KSJ";
            this.labelColour_KSJ.Size = new System.Drawing.Size(61, 25);
            this.labelColour_KSJ.TabIndex = 1;
            this.labelColour_KSJ.Text = "Цвет";
            // 
            // labelProcessor_KSJ
            // 
            this.labelProcessor_KSJ.AutoSize = true;
            this.labelProcessor_KSJ.Location = new System.Drawing.Point(91, 308);
            this.labelProcessor_KSJ.Name = "labelProcessor_KSJ";
            this.labelProcessor_KSJ.Size = new System.Drawing.Size(121, 25);
            this.labelProcessor_KSJ.TabIndex = 1;
            this.labelProcessor_KSJ.Text = "Процессор";
            // 
            // labelPCS_KSJ
            // 
            this.labelPCS_KSJ.AutoSize = true;
            this.labelPCS_KSJ.Location = new System.Drawing.Point(91, 381);
            this.labelPCS_KSJ.Name = "labelPCS_KSJ";
            this.labelPCS_KSJ.Size = new System.Drawing.Size(188, 25);
            this.labelPCS_KSJ.TabIndex = 1;
            this.labelPCS_KSJ.Text = "Тактовая частота";
            // 
            // labelMemory_KSJ
            // 
            this.labelMemory_KSJ.AutoSize = true;
            this.labelMemory_KSJ.Location = new System.Drawing.Point(91, 460);
            this.labelMemory_KSJ.Name = "labelMemory_KSJ";
            this.labelMemory_KSJ.Size = new System.Drawing.Size(221, 25);
            this.labelMemory_KSJ.TabIndex = 1;
            this.labelMemory_KSJ.Text = "Оперативная память";
            // 
            // labelHD_KSJ
            // 
            this.labelHD_KSJ.AutoSize = true;
            this.labelHD_KSJ.Location = new System.Drawing.Point(91, 536);
            this.labelHD_KSJ.Name = "labelHD_KSJ";
            this.labelHD_KSJ.Size = new System.Drawing.Size(241, 25);
            this.labelHD_KSJ.TabIndex = 1;
            this.labelHD_KSJ.Text = "Объём жёсткого диска";
            // 
            // labelDate_KSJ
            // 
            this.labelDate_KSJ.AutoSize = true;
            this.labelDate_KSJ.Location = new System.Drawing.Point(91, 612);
            this.labelDate_KSJ.Name = "labelDate_KSJ";
            this.labelDate_KSJ.Size = new System.Drawing.Size(151, 25);
            this.labelDate_KSJ.TabIndex = 1;
            this.labelDate_KSJ.Text = "Дата выпуска";
            // 
            // dataGridViewTable_KSJ
            // 
            this.dataGridViewTable_KSJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KSJ.Location = new System.Drawing.Point(425, 131);
            this.dataGridViewTable_KSJ.Name = "dataGridViewTable_KSJ";
            this.dataGridViewTable_KSJ.RowHeadersWidth = 82;
            this.dataGridViewTable_KSJ.RowTemplate.Height = 33;
            this.dataGridViewTable_KSJ.Size = new System.Drawing.Size(849, 647);
            this.dataGridViewTable_KSJ.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 919);
            this.Controls.Add(this.panelProduct_KSJ);
            this.Controls.Add(this.panelMenu_KSJ);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 990);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu_KSJ.ResumeLayout(false);
            this.panelProduct_KSJ.ResumeLayout(false);
            this.panelProduct_KSJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KSJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu_KSJ;
        private System.Windows.Forms.Button buttonProducts_KSJ;
        private System.Windows.Forms.Panel panelProduct_KSJ;
        private System.Windows.Forms.Button buttonHelp_KSJ;
        private System.Windows.Forms.Button buttonAbout_KSJ;
        private System.Windows.Forms.Label labelDate_KSJ;
        private System.Windows.Forms.Label labelHD_KSJ;
        private System.Windows.Forms.Label labelMemory_KSJ;
        private System.Windows.Forms.Label labelPCS_KSJ;
        private System.Windows.Forms.Label labelProcessor_KSJ;
        private System.Windows.Forms.Label labelColour_KSJ;
        private System.Windows.Forms.Label labelMaker_KSJ;
        private System.Windows.Forms.Label labelModel_KSJ;
        private System.Windows.Forms.TextBox textBoxDate_KSJ;
        private System.Windows.Forms.TextBox textBoxProcessor_KSJ;
        private System.Windows.Forms.TextBox textBoxMemory_KSJ;
        private System.Windows.Forms.TextBox textBoxHD_KSJ;
        private System.Windows.Forms.TextBox textBoxMaker_KSJ;
        private System.Windows.Forms.TextBox textBoxPCS_KSJ;
        private System.Windows.Forms.TextBox textBoxColour_KSJ;
        private System.Windows.Forms.TextBox textBoxModel_KSJ;
        private System.Windows.Forms.DataGridView dataGridViewTable_KSJ;
    }
}

