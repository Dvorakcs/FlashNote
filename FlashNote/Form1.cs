using System;

namespace FlashNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LocalFileTXT.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FlashNote");
            TimeEndDateTime.Format = DateTimePickerFormat.Time;
        }

        private void CreateFileBTN_Click(object sender, EventArgs e)
        {

            DateTime dataTermino = TimeEndDateTime.Value;
            string nomeArquivo = NameFileTXT.Text;
            string localPasta = LocalFileTXT.Text;
            TimeSpan DuracaoArquivo = dataTermino - DateTime.Now;
            string LayoutNameFile = $"{nomeArquivo}_{dataTermino.ToString("yyyyMMddHHmmss")}.FNTEMP";

            try
            {
                if(!Directory.Exists(localPasta))
                {
                    Directory.CreateDirectory(localPasta);
                }

                string caminhoCompleto = Path.Combine(localPasta, LayoutNameFile);
                string formatoPersonalizado = $"{(int)DuracaoArquivo.TotalHours}:{DuracaoArquivo.Minutes:D2}:{DuracaoArquivo.Seconds:D2}";
                if (VerificarExistenciaArquivo(nomeArquivo))
                {
                    MessageBox.Show("Arquivo contem o mesmo nome que outro", "Arquivo ja existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                };
                File.WriteAllText(caminhoCompleto, $"Seu Arquivo Temporario Durara: {formatoPersonalizado}");
                MessageBox.Show("Arquivo criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarExistenciaArquivo(string FileName)
        {
            string[] arquivos = Directory.GetFiles(LocalFileTXT.Text);
            
            bool FileExist = false;
            for (int i = 0; i < arquivos.Length; i++)
            {
                string nomeArquivo = Path.GetFileName(arquivos[i]);
                if (nomeArquivo.Split('_')[0] == FileName)
                {
                    FileExist = true;
                    break;
                }
                FileExist = false;
            }
            
            return FileExist;
            
        }
    }
}
