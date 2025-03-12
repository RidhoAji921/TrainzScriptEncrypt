using System.Diagnostics;

namespace TrainzEncrypt
{
    public partial class Form1 : Form
    {
        String TrainzPath;
        String GSPath;

        public Form1()
        {
            InitializeComponent();
            getPath();
        }

        public void getPath()
        {
            String savedPath;
            try
            {
                savedPath = File.ReadAllText(".\\path.txt");
            }
            catch
            {
                savedPath = "";
            }
            if (savedPath != "")
            {
                TrainzPath = savedPath;
            }
            TxtBox_PathFolderTrainz.Text = TrainzPath;
        }

        void createFile(string TrainzPath)
        {
            File.WriteAllText(".\\path.txt", TrainzPath);
        }

        void SetCommand(string path)
        {
            File.WriteAllText(path, "\"" + TrainzPath + "\" encrypt \"" + GSPath + "\"");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.InitialDirectory = "C:\\";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath + "\\bin\\TrainzUtil";
                TxtBox_PathFolderTrainz.Text = folderPath;
                TrainzPath= folderPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "game script (*.gs)|*.gs";
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string GSfolderPath = openFileDialog1.FileName;
                TxtBox_PathFileGS.Text = GSfolderPath;
                GSPath = GSfolderPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createFile(TrainzPath);
            string relativePath = Directory.GetCurrentDirectory();
            relativePath = relativePath + "\\encrypt.bat";
            SetCommand(relativePath);
            Process proc = null;
            string batDir = string.Format(@"");
            //"C:\My Folder\dari PC\script\encrypt.bat"
            proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.WorkingDirectory = batDir;
            proc.StartInfo.FileName = relativePath;
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();
            //MessageBox.Show("Bat file executed !!");
        }
    }
}