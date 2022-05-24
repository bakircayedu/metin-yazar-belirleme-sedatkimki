namespace textapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void TextImportBtn_Click(object sender, EventArgs e)
        {
            if (TextImport())
            {
                // dosyanýn dizinini textboxta gösterir
                FilePathTxtBox.Text = Globals.FilePath;
                TransferStackBtn.Enabled = true;
            }
        }

        private bool TextImport()
        {
            //https://docs.microsoft.com/tr-tr/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0
            
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Globals.FilePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    Globals.FileStream = openFileDialog.OpenFile();

                    return true;

                }
                return false;
            }
        }
        private void ReadFile(string filePath)
        {
            // global deðiþken olarak okuduðumuz stream'i okuyup metni bellek'e yükleme
            using (StreamReader reader = new StreamReader(Globals.FileStream))
            {
                int place = 0;
                while (!reader.EndOfStream )
                {
                    Sentence sentence = new Sentence(reader.ReadLine(), place);
                    Globals.text.FilePath = filePath;
                    Globals.text.AddSentence(sentence);
                    place++;
                }
            }
        }

        private void TransferStackBtn_Click(object sender, EventArgs e)
        {
            ReadFile(Globals.FilePath);
            MessageBox.Show("Metin baþarýyla stack'e okundu");
            this.Hide();
            var textInfo = new TextInfo();
            textInfo.Closed += (s, args) => this.Close();
            textInfo.Show();

        }
    }

    
}