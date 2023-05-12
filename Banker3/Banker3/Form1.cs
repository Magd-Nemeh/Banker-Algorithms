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

    public partial class Form1 : Form
    {
        public static int numberofresources = 0;
        public static int numberofprocesses = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void next_clicked(object sender, EventArgs e)
        {
            numberofresources =int.Parse(nb_resource.Text);
            numberofprocesses = int.Parse(nb_process.Text);
            
            this.Hide();
            Form2 targetForm = new Form2();
            targetForm.ShowDialog();
        }
    }
}
