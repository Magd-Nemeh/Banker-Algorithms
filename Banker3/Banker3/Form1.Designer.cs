
namespace Banker3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nb_resource = new System.Windows.Forms.TextBox();
            this.nb_process = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Resources:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Processes:";
            // 
            // nb_resource
            // 
            this.nb_resource.Location = new System.Drawing.Point(206, 41);
            this.nb_resource.Name = "nb_resource";
            this.nb_resource.Size = new System.Drawing.Size(100, 26);
            this.nb_resource.TabIndex = 2;
            // 
            // nb_process
            // 
            this.nb_process.Location = new System.Drawing.Point(206, 88);
            this.nb_process.Name = "nb_process";
            this.nb_process.Size = new System.Drawing.Size(100, 26);
            this.nb_process.TabIndex = 3;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(122, 152);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(135, 53);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.nb_process);
            this.Controls.Add(this.nb_resource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resources and Processes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nb_resource;
        private System.Windows.Forms.TextBox nb_process;
        private System.Windows.Forms.Button next_button;
    }
}

