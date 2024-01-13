namespace FlashNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LocalFileTXT.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void CreateFileBTN_Click(object sender, EventArgs e)
        {
            
        }
    }
}
