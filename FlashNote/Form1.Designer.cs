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
            TimeEndDateTime = new DateTimePicker();
            NameFileTXT = new TextBox();
            textBox2 = new TextBox();
            LocalFileTXT = new TextBox();
            EditFileBTN = new Button();
            SuspendLayout();
            // 
            // CreateFileBTN
            // 
            CreateFileBTN.Location = new Point(131, 109);
            CreateFileBTN.Name = "CreateFileBTN";
            CreateFileBTN.Size = new Size(135, 23);
            CreateFileBTN.TabIndex = 0;
            CreateFileBTN.Text = "Criar";
            CreateFileBTN.UseVisualStyleBackColor = true;
            CreateFileBTN.Click += CreateFileBTN_Click;
            // 
            // TimeEndDateTime
            // 
            TimeEndDateTime.Location = new Point(25, 109);
            TimeEndDateTime.Name = "TimeEndDateTime";
            TimeEndDateTime.Size = new Size(100, 23);
            TimeEndDateTime.TabIndex = 1;
            TimeEndDateTime.Value = new DateTime(2024, 1, 13, 13, 5, 1, 0);
            // 
            // NameFileTXT
            // 
            NameFileTXT.Location = new Point(25, 51);
            NameFileTXT.Name = "NameFileTXT";
            NameFileTXT.Size = new Size(137, 23);
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
            LocalFileTXT.Location = new Point(25, 80);
            LocalFileTXT.Name = "LocalFileTXT";
            LocalFileTXT.Size = new Size(241, 23);
            LocalFileTXT.TabIndex = 3;
            LocalFileTXT.Text = "Local do arquivo";
            // 
            // EditFileBTN
            // 
            EditFileBTN.Location = new Point(168, 51);
            EditFileBTN.Name = "EditFileBTN";
            EditFileBTN.Size = new Size(98, 23);
            EditFileBTN.TabIndex = 4;
            EditFileBTN.Text = "Editar Arquivo";
            EditFileBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 198);
            Controls.Add(EditFileBTN);
            Controls.Add(LocalFileTXT);
            Controls.Add(NameFileTXT);
            Controls.Add(TimeEndDateTime);
            Controls.Add(CreateFileBTN);
            Name = "Form1";
            Text = "FlashNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateFileBTN;
        private DateTimePicker TimeEndDateTime;
        private TextBox NameFileTXT;
        private TextBox textBox2;
        private TextBox LocalFileTXT;
        private Button EditFileBTN;
    }
}
