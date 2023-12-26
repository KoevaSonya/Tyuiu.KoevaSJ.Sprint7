
namespace Tyuiu.KoevaSJ.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxText_KSJ = new System.Windows.Forms.GroupBox();
            this.textBoxTextAbout_KSJ = new System.Windows.Forms.TextBox();
            this.groupBoxText_KSJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 31.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(547, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(619, 111);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "О приложении\r\n\r\n\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxText_KSJ
            // 
            this.groupBoxText_KSJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxText_KSJ.Controls.Add(this.textBoxTextAbout_KSJ);
            this.groupBoxText_KSJ.Location = new System.Drawing.Point(27, 169);
            this.groupBoxText_KSJ.Name = "groupBoxText_KSJ";
            this.groupBoxText_KSJ.Size = new System.Drawing.Size(1615, 796);
            this.groupBoxText_KSJ.TabIndex = 1;
            this.groupBoxText_KSJ.TabStop = false;
            // 
            // textBoxTextAbout_KSJ
            // 
            this.textBoxTextAbout_KSJ.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxTextAbout_KSJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTextAbout_KSJ.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTextAbout_KSJ.Location = new System.Drawing.Point(37, 63);
            this.textBoxTextAbout_KSJ.Multiline = true;
            this.textBoxTextAbout_KSJ.Name = "textBoxTextAbout_KSJ";
            this.textBoxTextAbout_KSJ.Size = new System.Drawing.Size(1545, 689);
            this.textBoxTextAbout_KSJ.TabIndex = 0;
            this.textBoxTextAbout_KSJ.Text = resources.GetString("textBoxTextAbout_KSJ.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 977);
            this.Controls.Add(this.groupBoxText_KSJ);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.groupBoxText_KSJ.ResumeLayout(false);
            this.groupBoxText_KSJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxText_KSJ;
        private System.Windows.Forms.TextBox textBoxTextAbout_KSJ;
    }
}