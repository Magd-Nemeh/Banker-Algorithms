using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banker3
{
    public partial class Form4 : Form
    {
        public static int[] totalresources = new int[Form1.numberofresources];
        public Form4()
        {
            InitializeComponent();
           
            for (int i = 0; i < Form1.numberofresources; i++)
             {
                    var txtBox = new TextBox();
                    txtBox.Name = "txt_" + 0 + "_" + i;
                    tableLayoutPanel1.Controls.Add(txtBox, i, 0);
             }


        }

        private void next_clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.numberofresources; i++)
            {
                
                    if (int.TryParse(tableLayoutPanel1.Controls["txt_" + 0 + "_" + i].Text, out int value))
                    {
                       totalresources[i] = value;
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numbers for the matrix data.");
                        return;
                    }
                
            }

            this.Hide();
            Form5 targetForm = new Form5();
            targetForm.ShowDialog();

        }
    }
}
