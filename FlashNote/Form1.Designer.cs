namespace FlashNote
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
            CreateFileBTN = new Button();
            dateTimePicker1 = new DateTimePicker();
            NameFileTXT = new TextBox();
            textBox2 = new TextBox();
            LocalFileTXT = new TextBox();
            SuspendLayout();
            // 
            // CreateFileBTN
            // 
            CreateFileBTN.Location = new Point(119, 165);
            CreateFileBTN.Name = "CreateFileBTN";
            CreateFileBTN.Size = new Size(122, 23);
            CreateFileBTN.TabIndex = 0;
            CreateFileBTN.Text = "Criar";
            CreateFileBTN.UseVisualStyleBackColor = true;
            CreateFileBTN.Click += CreateFileBTN_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // NameFileTXT
            // 
            NameFileTXT.Location = new Point(86, 59);
            NameFileTXT.Name = "NameFileTXT";
            NameFileTXT.Size = new Size(200, 23);
            NameFileTXT.TabIndex = 2;
            NameFileTXT.Text = "Nome Do Arquivo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // LocalFileTXT
            // 
            LocalFileTXT.Location = new Point(86, 88);
            LocalFileTXT.Name = "LocalFileTXT";
            LocalFileTXT.Size = new Size(200, 23);
            LocalFileTXT.TabIndex = 3;
            LocalFileTXT.Text = "Local do arquivo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 252);
            Controls.Add(LocalFileTXT);
            Controls.Add(NameFileTXT);
            Controls.Add(dateTimePicker1);
            Controls.Add(CreateFileBTN);
            Name = "Form1";
            Text = "FlashNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateFileBTN;
        private DateTimePicker dateTimePicker1;
        private TextBox NameFileTXT;
        private TextBox textBox2;
        private TextBox LocalFileTXT;
    }
}
