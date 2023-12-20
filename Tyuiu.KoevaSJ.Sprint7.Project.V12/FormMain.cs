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
        public FormMain()
        {
            InitializeComponent();


        }
         
        private void buttonProducts_KSJ_Click(object sender, EventArgs e)
        {
            panelProduct_KSJ.Visible = true;
        }

        private void panelProduct_KSJ_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
