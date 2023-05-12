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
    public partial class Form5 : Form
    {
        public static int[] availableResources = new int[Form1.numberofresources];
        public Form5()
        {
            InitializeComponent();
            //Max Need
            this.dataGridView1.ColumnCount = Form1.numberofresources;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int r = 0; r < Form1.numberofprocesses; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < Form1.numberofresources; c++)
                {
                    row.Cells[c].Value = Form2.maxneed[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }
            // Allocation
            this.dataGridView2.ColumnCount = Form1.numberofresources;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int r = 0; r < Form1.numberofprocesses; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView2);

                for (int c = 0; c < Form1.numberofresources; c++)
                {
                    row.Cells[c].Value = Form3.allocated[r, c];
                }

                this.dataGridView2.Rows.Add(row);
            }
            
            //Total Resources
            this.dataGridView3.ColumnCount = Form1.numberofresources;
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int r = Form1.numberofprocesses; (r-1) < Form1.numberofprocesses; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView3);

                for (int c = 0; c < Form1.numberofresources; c++)
                {
                    row.Cells[c].Value = Form4.totalresources[c];
                }

                this.dataGridView3.Rows.Add(row);
            }

            //Availble Resources
            
            for (int j = 0; j < Form1.numberofresources; j++)
            {
                int sum = 0;
                for (int i = 0; i < Form1.numberofprocesses; i++)
                {
                    sum += Form3.allocated[i, j];
                }
                availableResources[j] = Form4.totalresources[j] - sum;
            }
           
            this.dataGridView4.ColumnCount = Form1.numberofresources;
            dataGridView4.ColumnHeadersVisible = false;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int r = Form1.numberofprocesses; (r - 1) < Form1.numberofprocesses; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView4);

                for (int c = 0; c < Form1.numberofresources; c++)
                {
                    row.Cells[c].Value = availableResources[c];
                }

                this.dataGridView4.Rows.Add(row);
            }




        }

        private void check_clicked(object sender, EventArgs e)
        {
            //to check situation of each process
            bool[] processfinished = new bool[Form1.numberofprocesses];

            //Alogrithm
            bool safe = true;
            while (safe)
            {
                safe = false;

                for (int i = 0; i < Form1.numberofprocesses; i++)
                {
                    if (!processfinished[i])
                    {
                        bool canFinish = true;
                        for (int j = 0; j < Form1.numberofresources; j++)
                        {
                            if (Form2.maxneed[i, j] - Form3.allocated[i, j] > availableResources[j])
                            {
                                canFinish = false;
                                char myChar = (char)('A' + j);
                                string message = myChar.ToString();
                                MessageBox.Show("Resource of" + myChar + " isn t sufficient so the system is in unsafe mode");
                                break;
                            }
                        }

                        if (canFinish)
                        {
                            for (int j = 0; j < Form1.numberofresources; j++)
                            {
                                availableResources[j] += Form3.allocated[i, j];
                            }
                            processfinished[i] = true;
                            safe = true;
                        }
                    }
                }
            }

            // Check if all processes have finished
            bool all_processes_Finished = true;
            for (int i = 0; i < Form1.numberofprocesses; i++)
            {
                if (!processfinished[i])
                {
                    all_processes_Finished = false;
                    MessageBox.Show("Process "+ (i+1).ToString() + "isn't finished so the system is in insafe state");
                    break;
                }
            }

            // If all processes have finished, the system is in a safe state
            if (all_processes_Finished)
            {
                MessageBox.Show("System is in safe state");
            }
           
        }
    }
}
