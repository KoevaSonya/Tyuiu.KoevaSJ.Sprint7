using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KoevaSJ.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        public FormMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object button)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop_KSJ.Controls.Add(childForm);
            this.panelDesktop_KSJ.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonProducts_KSJ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProduct(), sender);
        }

        private void panelProduct_KSJ_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAbout_KSJ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAbout(), sender);
        }

        private void buttonHelp_KSJ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHelp(), sender);
        }

        private void buttonMain_KSJ_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBack(), sender);
        }
    }
}
