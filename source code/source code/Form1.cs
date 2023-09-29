using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            openFileDialog1.Title = "Select file to be upload.";
            //which type file format you want to upload in database. just add them.
            //openFileDialog1.Filter = "Select Valid Document(*.txt,*.pdf; *.doc; *.xlsx; *.html)|*.txt,*.pdf; *.docx; *.xlsx; *.html";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        txtEmailPath.Text = path;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ExportTxtFile(string Content, string FileName)
        {
            var uniqId = Guid.NewGuid().ToString("N");
            string fileName = @"..\..\ExportFiles\" + FileName + "___" + uniqId + ".txt";
            TextWriter txt = new StreamWriter(fileName);
            txt.Write(Content);
            txt.Close();
        }

        public class EmailFormat
        {
            public string Email { get; set; }
            public string Key { get; set; }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.CheckFileExists)
            {

                string line;
                List<EmailFormat> emailList = new List<EmailFormat>();

                string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                txtEmailPath.Text = path;
                string content = File.ReadAllText(openFileDialog1.FileName);
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    if (rdTypeThree.Checked == true)
                    {
                        EmailFormat ef = new EmailFormat();
                        var lineSplit = line.Split(':');
                        var emailSplit = lineSplit[1].Split('@');
                        ef.Email = Convert.ToString(line);
                        ef.Key = Convert.ToString(emailSplit[1]);
                        emailList.Add(ef);
                    }
                    else if (rdTypeTwo.Checked == true)
                    {
                        EmailFormat ef = new EmailFormat();
                        var lineSplit = line.Split(':');
                        var emailSplit = lineSplit[0].Split('@');
                        ef.Email = Convert.ToString(line);
                        ef.Key = Convert.ToString(emailSplit[1]);
                        emailList.Add(ef);
                    }
                    else if (rdTypeOne.Checked == true)
                    {
                        EmailFormat ef = new EmailFormat();
                        var emailSplit = line.Split('@');
                        ef.Email = Convert.ToString(line);
                        ef.Key = Convert.ToString(emailSplit[1]);
                        emailList.Add(ef);
                    }
                    else
                    {
                        MessageBox.Show("Please select type of export");
                        break;
                    }
                }
                var orderedEmail = emailList.OrderBy(a => a.Key).GroupBy(a => a.Key).ToList();
                foreach (var groupedBY in orderedEmail)
                {
                    string emailExportData = "";
                    foreach (var email in groupedBY)
                    {
                        emailExportData += email.Email + "\n";
                        textBox1.AppendText(email.Email);
                        textBox1.AppendText(Environment.NewLine);
                    }
                    textBox1.AppendText("--------------");
                    textBox1.AppendText(Environment.NewLine);
                    ExportTxtFile(emailExportData, groupedBY.Key);
                }
            }

        }
    }
}
