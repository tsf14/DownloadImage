using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.IO;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections;
using System.Web;
using Newtonsoft.Json.Linq;
namespace DownloadImage
{
    public partial class Form1 : Form
    {
        JArray ja;
        int count;
        string access_token = "  ";
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string str = @"https://www.facebook.com/dialog/oauth?client_id=1616362448642599&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token&scope=user_photos";
            fblogin.Navigate(str);



        }

        private void FacebookLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (fblogin.Url.AbsoluteUri.Contains("success_token"))
            {
                string str1 = fblogin.Url.AbsoluteUri;
                string str2 = str1.Substring(str1.IndexOf("access_token") + 13);
                string access_token = str2.Substring(0, str2.IndexOf("&"));
                MessageBox.Show("access_token= " + access_token);

                FacebookClient fbclient = new FacebookClient(access_token);
                dynamic data = fbclient.Get("/me");
                MessageBox.Show("id= " + data.id + Environment.NewLine + "name= " + data.name + Environment.NewLine + "link=" + data.link);


            }
        }

        private void get_Click(object sender, EventArgs e)
        {
            FacebookClient fbclient = new FacebookClient(access_token);
            dynamic Albumlist = fbclient.Get("/me/albums");

            int count = (int)Albumlist.data.Count;
            for (int i = 0; i < count; i++)
            {
                albumlist.Items.Add(Albumlist.data[i].id);
                albumname.Items.Add(Albumlist.data[i].name);
            }


        }

        private void logout_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient();

            var logoutUrl = fb.GetLogoutUrl(new
            {
                next = "https://www.facebook.com/connect/login_success.html",
                access_token = access_token
            });
            var webBrowser = new WebBrowser();
            webBrowser.Navigated += (o, args) =>
            {
                if (args.Url.AbsoluteUri == "https://www.facebook.com/connect/login_success.html")
                    Close();
            };

            webBrowser.Navigate(logoutUrl.AbsoluteUri);
        }

        private void download_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSv.Text = String.Format(@"{0}\Album", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Directory.CreateDirectory(txtSv.Text);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void frndlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookClient fbclient = new FacebookClient(access_token);
            foreach (var item in albumlist.SelectedItems)
            {
                
                String strrr = "/" + item.ToString() + "/photos";
                dynamic pics = fbclient.Get(strrr);
                count = (int)pics.data.Count;
                String ssss = Convert.ToString(pics.data);
                //JObject ob = JObject.Parse(ssss);
                ja = JArray.Parse(ssss);
            }

        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            int i = 0;
            try
            {
                while (ja[i]["images"][0]["source"].ToString() != null)
                {
                    wc.DownloadFile(ja[i]["images"][0]["source"].ToString(), txtSv.Text + "\\" + i.ToString() + ".jpg");
                    i++;
                }
            }
            catch (Exception esss)
            {
                MessageBox.Show("Done");
            }
            MessageBox.Show("Downloaded!");
            
        }

    } 

    }
