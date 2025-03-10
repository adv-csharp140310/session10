namespace RestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonWebClient = new Button();
            buttonRestSharp = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonWebClient
            // 
            buttonWebClient.Location = new Point(12, 12);
            buttonWebClient.Name = "buttonWebClient";
            buttonWebClient.Size = new Size(75, 23);
            buttonWebClient.TabIndex = 0;
            buttonWebClient.Text = "WebClient";
            buttonWebClient.UseVisualStyleBackColor = true;
            buttonWebClient.Click += buttonWebClient_Click;
            // 
            // buttonRestSharp
            // 
            buttonRestSharp.Location = new Point(93, 12);
            buttonRestSharp.Name = "buttonRestSharp";
            buttonRestSharp.Size = new Size(118, 23);
            buttonRestSharp.TabIndex = 1;
            buttonRestSharp.Text = "RestSharp";
            buttonRestSharp.UseVisualStyleBackColor = true;
            buttonRestSharp.Click += buttonRestSharp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 352);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRestSharp);
            Controls.Add(buttonWebClient);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonWebClient;
        private Button buttonRestSharp;
        private DataGridView dataGridView1;
    }
}
