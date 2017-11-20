using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ruWow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader configWTF = new StreamReader(@"WTF\config.WTF");
                string text = configWTF.ReadToEnd();
                configWTF.Close();
                if (text.Contains("SET textLocale \"ruRU\""))
                {
                    label1.Text = "RU NOW";
                    return;
                }
                if (text.Contains("SET textLocale \"enUS\""))
                {
                    label1.Text = "EU NOW";
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                label1.Text = "Не там";
                label1.ForeColor = System.Drawing.Color.Red;
            }
            catch (System.IO.FileNotFoundException)
            {
                label1.Text = "Не там";
                label1.ForeColor = System.Drawing.Color.Red;
            }



        }


        private void swap_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader configWTF = new StreamReader(@"WTF\config.WTF");
                string text = configWTF.ReadToEnd();
                configWTF.Close();
                if (text.Contains("SET textLocale \"ruRU\""))
                {
                    text = text.Replace("SET textLocale \"ruRU\"", "SET textLocale \"enUS\"");
                    StreamWriter configWTFW = new StreamWriter(@"WTF\config.WTF");
                    configWTFW.Write(text);
                    configWTFW.Close();
                    label1.Text = "EU NOW";
                    label1.ForeColor = System.Drawing.Color.Green;
                    return;
                }
                if (text.Contains("SET textLocale \"enUS\""))
                {
                    text = text.Replace("SET textLocale \"enUS\"", "SET textLocale \"ruRU\"");
                    StreamWriter configWTFW = new StreamWriter(@"WTF\config.WTF");
                    configWTFW.Write(text);
                    label1.Text = "RU NOW";
                    label1.ForeColor = System.Drawing.Color.Green;
                    configWTFW.Close();
                    return;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {

            }
            catch (System.IO.FileNotFoundException)
            {

            }
        }

        private void euL_Click(object sender, EventArgs e)
        {
            StreamReader configWTF = new StreamReader(@"WTF\config.WTF");
            string text = configWTF.ReadToEnd();
            configWTF.Close();
            text = text.Replace("SET textLocale \"ruRU\"", "SET textLocale \"enUS\"");
            StreamWriter configWTFW = new StreamWriter(@"WTF\config.WTF");
            configWTFW.Write(text);
            configWTFW.Close();
            try
            {
                Process.Start("Wow-64.exe");
                Application.Exit();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                label1.Text = "Не там";
                label1.ForeColor = System.Drawing.Color.Red;
            }



        }

        private void ruL_Click(object sender, EventArgs e)
        {
            StreamReader configWTF = new StreamReader(@"WTF\config.WTF");
            string text = configWTF.ReadToEnd();
            configWTF.Close();
            text = text.Replace("SET textLocale \"enUS\"", "SET textLocale \"ruRU\"");
            StreamWriter configWTFW = new StreamWriter(@"WTF\config.WTF");
            configWTFW.Write(text);
            configWTFW.Close();
            try
            {
                Process.Start("Wow-64.exe");
                Application.Exit();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                label1.Text = "Не там";
                label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}
