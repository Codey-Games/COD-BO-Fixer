using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;
using IWshRuntimeLibrary;
using System.IO;

namespace COD_BO_Fixer
{
    public partial class Form1 : Form
    {
        bool correctFile;
        bool patchedFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Call of Duty: Black Ops - Fixer";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            // check if its the correct file type (if its blackops.exe, if the path is over 4 characters long, idk, if the second character is :, if the third character is \)
            if (text.EndsWith("BlackOps.exe") && text.Length > 4 && char.IsLetter(text[0]) && text[1] == ':' && text[2] == '\\')
            {
                correctFile = true;
                checkBox1.Checked = true;
            }
            else
            {
                correctFile = false;
                checkBox1.Checked = false;
            }




            // check if the file is patched
            string folderPath = System.IO.Path.GetDirectoryName(textBox1.Text) ?? ""; // if its not a null value ?? if it is a null value
            if (!string.IsNullOrEmpty(folderPath)) // check if the path is not null or empty
            {
                string filePath = System.IO.Path.Combine(folderPath, "bgt5launcher.exe");
                bool isFileExists = System.IO.File.Exists(filePath);

                if (isFileExists && correctFile == true)
                {
                    patchedFile = true;
                    checkBox2.Checked = true;
                }
                else
                {
                    patchedFile = false;
                    checkBox2.Checked = false;
                }
            }
            else
            {
                patchedFile = false;
                checkBox2.Checked = false;
            }





            if (correctFile == true)
            {
                if (patchedFile == true)
                {
                    button5.Enabled = true;
                    button4.Enabled = true;
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                else
                {
                    button5.Enabled = false;
                    button4.Enabled = false;
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
            }
            else
            {
                button5.Enabled = false;
                button4.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }


        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.Title = "Select an Executable File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove Patch

            string folderPath = System.IO.Path.GetDirectoryName(textBox1.Text) ?? ""; // if its not a null value ?? if it is a null value
            if (!string.IsNullOrEmpty(folderPath)) // check if the path is not null or empty
            {

                string newFolderPath = System.IO.Path.Combine(folderPath, "OriginalFiles");

                if (System.IO.Directory.Exists(newFolderPath)) // Check if the folder doesn't exist
                {

                    string filePath = System.IO.Path.Combine(newFolderPath, "steam_api.dll");
                    bool isFileExists = System.IO.File.Exists(filePath);

                    if (isFileExists)
                    {
                        System.IO.File.Delete(System.IO.Path.Combine(folderPath, "steam_api.dll"));

                        // Move the file to the backup folder
                        System.IO.File.Move(filePath, System.IO.Path.Combine(folderPath, "steam_api.dll"));

                        // Delete the folder
                        System.IO.Directory.Delete(newFolderPath);

                    }
                    else
                    {
                        MessageBox.Show("Original Steam Integration cannot be found! Press OK to skip.");
                    }

                }
                else
                {
                    MessageBox.Show("Some original files cannot be found! Press OK to skip.");
                }



                string sourceFolderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");



                string[] files = System.IO.Directory.GetFiles(sourceFolderPath);

                // Copy each file to the destination folder
                foreach (string patchFile in files)
                {
                    string destinationFilePath = System.IO.Path.Combine(folderPath, System.IO.Path.GetFileName(patchFile));

                    // Delete the file
                    if (System.IO.Path.GetFileName(patchFile) != "steam_api.dll")
                    {
                        System.IO.File.Delete(destinationFilePath);
                    }
                }

                MessageBox.Show("Patch removed successfully!");

                button2.Enabled = false;
                button1.Enabled = true;
                checkBox2.Checked = false;
                button5.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Apply Patch

            string folderPath = System.IO.Path.GetDirectoryName(textBox1.Text) ?? ""; // if its not a null value ?? if it is a null value
            if (!string.IsNullOrEmpty(folderPath)) // check if the path is not null or empty
            {

                string newFolderPath = System.IO.Path.Combine(folderPath, "OriginalFiles");

                if (!System.IO.Directory.Exists(newFolderPath)) // Check if the folder doesn't exist
                {
                    System.IO.Directory.CreateDirectory(newFolderPath); // Create the folder
                }


                string filePath = System.IO.Path.Combine(folderPath, "steam_api.dll");
                bool isFileExists = System.IO.File.Exists(filePath);

                if (isFileExists)
                {
                    System.IO.File.Move(filePath, System.IO.Path.Combine(newFolderPath, "steam_api.dll"));
                }



                string sourceFolderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");



                string[] files = System.IO.Directory.GetFiles(sourceFolderPath);

                // Copy each file to the destination folder
                foreach (string patchFile in files)
                {
                    string fileName = System.IO.Path.GetFileName(patchFile);
                    string destinationFilePath = System.IO.Path.Combine(folderPath, fileName);

                    // Copy the file
                    System.IO.File.Copy(patchFile, destinationFilePath);
                }

                MessageBox.Show("Patch applied successfully!");

                button2.Enabled = true;
                button1.Enabled = false;
                checkBox2.Checked = true;
                button5.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // create shortcuts
            string folderPath = System.IO.Path.GetDirectoryName(textBox1.Text) ?? ""; // if its not a null value ?? if it is a null value
            if (!string.IsNullOrEmpty(folderPath)) // check if the path is not null or empty
            {

                string filePath = System.IO.Path.Combine(folderPath, "bgt5launcher.exe");

                // get start menu path
                string startMenuProgramsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");
                string startMenuProgramsTargetPath = System.IO.Path.Combine(startMenuProgramsPath, "Start Server.lnk");

                // get desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopTargetPath = System.IO.Path.Combine(desktopPath, "Start Server.lnk");

                //make desktop shortcut
                WshShell shellDesktop = new WshShell();
                IWshShortcut shortcutDesktop = (IWshShortcut)shellDesktop.CreateShortcut(desktopTargetPath);
                shortcutDesktop.TargetPath = filePath;
                shortcutDesktop.WorkingDirectory = folderPath;
                shortcutDesktop.Save();

                // make start menu shortcut
                WshShell shellStartMenu = new WshShell();
                IWshShortcut shortcutStartMenu = (IWshShortcut)shellStartMenu.CreateShortcut(startMenuProgramsTargetPath);
                shortcutStartMenu.TargetPath = filePath;
                shortcutStartMenu.WorkingDirectory = folderPath;
                shortcutStartMenu.Save();

                MessageBox.Show("Shortcuts created successfully!");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // remove shortcuts
            string folderPath = System.IO.Path.GetDirectoryName(textBox1.Text) ?? ""; // if its not a null value ?? if it is a null value
            if (!string.IsNullOrEmpty(folderPath)) // check if the path is not null or empty
            {

                // get start menu path
                string startMenuProgramsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");
                string startMenuProgramsTargetPath = System.IO.Path.Combine(startMenuProgramsPath, "Start Server.lnk");
                if (System.IO.File.Exists(startMenuProgramsTargetPath))
                {
                    System.IO.File.Delete(startMenuProgramsTargetPath);
                }
                else
                {
                    MessageBox.Show("Start Menu Shortcut could not be found! Press OK to skip.");
                }

                // get desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string desktopTargetPath = System.IO.Path.Combine(desktopPath, "Start Server.lnk");
                if (System.IO.File.Exists(desktopTargetPath))
                {
                    System.IO.File.Delete(desktopTargetPath);
                }
                else
                {
                    MessageBox.Show("Desktop Shortcut could not be found! Press OK to skip.");
                }

                MessageBox.Show("Shortcuts removed successfully!");

            }
        }
    }
}