using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace FlashNote
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            LocalFileTXT.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "FlashNote");
            TimeEndDateTime.Format = DateTimePickerFormat.Time;
            TimeEndDateTime.Text = DateAndTime.Now.ToString();
            // Configurar o timer
            timer = new();
            timer.Interval = 10000; // Intervalo em milissegundos (1 segundo)
            timer.Elapsed += VerificarPastas;
            timer.Start();
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

        private void VerificarPastas(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LocalFileTXT.Text))
            {
                string[] arquivos = Directory.GetFiles(LocalFileTXT.Text);
                for (int i = 0; i < arquivos.Length; i++)
                {
                    string nomeArquivo = Path.GetFileName(arquivos[i]);
                    string DataFinalString = nomeArquivo.Split(['_', '.'])[1];
                    DateTime dataFinalFile = DateTime.ParseExact(DataFinalString, "yyyyMMddHHmmss", null);
                    if (dataFinalFile <= DateTime.Now)
                    {
                        DeleteArquivo(nomeArquivo);
                    }

                }
            }            
        }
        public bool DeleteArquivo(string FileName)
        {
            File.Delete(Path.Combine(LocalFileTXT.Text, FileName));
            return true;
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
