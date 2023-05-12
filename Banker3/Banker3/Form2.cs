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
    public partial class Form2 : Form
    {
        public static int[,] maxneed = new int[Form1.numberofprocesses, Form1.numberofresources];

        public Form2()
        {
            InitializeComponent();

            for (int i = 0; i < Form1.numberofprocesses; i++)
            {
                for (int j = 0; j < Form1.numberofresources; j++)
                {
                    var txtBox = new TextBox();
                    txtBox.Name = "txt_" + i + "_" + j;
                    tableLayoutPanel1.Controls.Add(txtBox, j, i);
                }
            }

          
            int x1 =10, y1 = 70;
            for (int i = 1; i <= Form1.numberofprocesses; i++)
            {
                Label label = new Label();
                label.Text = "Process" + i.ToString()+":";
                label.Location = new Point(x1, y1);
                this.Controls.Add(label);
                y1 += 30;
            }

            int labelWidth = 30; 
            int labelHeight = 20;
            int count = 3;
            for (int i = 0; i < Form1.numberofresources; i++)
            {
                Label label = new Label();
                label.Text = ((char)('A' + i)).ToString();
                label.Width = labelWidth;
                label.Height = labelHeight;
                label.Location = new Point(count * labelWidth, 50);
                count++;
                this.Controls.Add(label);
            }



        }

        private void Save_button(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.numberofprocesses; i++)
            {
                for (int j = 0; j < Form1.numberofresources; j++)
                {
                    if (int.TryParse(tableLayoutPanel1.Controls["txt_" + i + "_" + j].Text, out int value))
                    {
                        maxneed[i, j] = value;
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numbers for the matrix data.");
                        return;
                    }
                }
            }

            this.Hide();
            Form3 targetForm = new Form3();
            targetForm.ShowDialog();
        }
    }
}
