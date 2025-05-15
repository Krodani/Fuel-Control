using System;
using System.Windows.Forms;

namespace gasolina_por_vuelta
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.racedepartment.com/downloads/fuel-control.39102/");
        }

    }
}
