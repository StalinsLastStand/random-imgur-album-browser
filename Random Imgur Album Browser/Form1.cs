using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Random_Imgur_Album_Browser
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

        private void btn_Next_Click(object sender, EventArgs e)
        {
           findRandomURL();
        }


        private async Task findRandomURL()
        {
            lbl_CurrentID.Text = "";
            lbl_CurrentID.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            bool found = false;

            while (!found)
            {
               string id = await generateRandomString();
               lbl_CurrentID.Text = string.Format("Trying ID: {0}", id);

               if (await checkIfValid(id))
               {
                    string url = string.Format("http://imgur.com/a/{0}/", id);

                    webBrowser.Navigate(url);
                    txt_URL.Text = url;
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    lbl_CurrentID.Text = null;

                    found = true;


               }
               else
               {
                   progressBar1.Value += 1;
               }                               
            }
        }

        private async Task<string> generateRandomString()
        {
            Random rnd = new Random();
            string output = "";

            while (output.Length != 5)
            {
                int r = rnd.Next(1, 4);

                switch (r)
                {
                    case 1:
                        //Upper letter
                        char u = (char)rnd.Next(65, 91);
                        output += u;
                        break;
                    case 2:
                        //Lowercase Letter
                        char l = (char)rnd.Next(97, 123);
                        output += l;
                        break;
                    case 3:
                        //Number
                        output += rnd.Next(1, 10).ToString();
                        break;
                }
            }

            return output;
        }

        private async Task<Boolean> checkIfValid(string id)
        {
            WebClient wc = new WebClient();
            Uri u = new Uri(string.Format("https://imgur.com/a/{0}/", id));

            try
            {
                string html = await wc.DownloadStringTaskAsync(u);
                if (html.Contains("This album is empty"))
                {
                    return false;
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }


    }
}
