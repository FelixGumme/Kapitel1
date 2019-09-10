using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovning1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            FontStyle stil = FontStyle.Regular;
            int textStorlek = int.Parse(tbxStorlek.Text);

            if (cbxFet.Checked)
            {
                stil = stil | FontStyle.Bold;
            }

            if (cbxKursiv.Checked)
            {
                stil = stil | FontStyle.Italic;
            }

            if (cbxUnder.Checked)
            {
                stil = stil | FontStyle.Underline;
            }

            if(textStorlek == 0)
            {
                MessageBox.Show("Du kan inte ha storleken 0 på texten", "Error");
            }
            else if(textStorlek < 0)
            {
                MessageBox.Show("Du kan inte ha en storlek som är mindre än 0 på texten", "Error");
            }
            else
            {
                Font font = new Font(tbxTecken.Text, int.Parse(tbxStorlek.Text), stil);
                tbxText.Font = font;
            }
        }
    }
}
