using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AplicacionInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Diagnostics.Process.Start(@"instalador\setup.exe");
                //radDropDownList1.SelectedItem.
                var lista = comboBox1.DisplayMember;
               
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"Manual.chm");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
