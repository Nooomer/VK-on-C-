using System;
using System.Linq;
using System.Windows.Forms;
using VkNet;
using VkNet.Model;
namespace VKK
{
    public partial class Inf : Form
    {
        public Inf()
        {
            InitializeComponent();
        }
        static string Token1 = "";
        static public void GetToken(string Token)
        {
            Token1 = Token;
        }
       
        private void Inf_Load(object sender, EventArgs e)
        {
            var api = new VkApi();

            api.Authorize(new ApiAuthParams
            {
                AccessToken = Token1
                });
            var p = api.Users.Get(new long[] { }).FirstOrDefault();
            if (p == null)
                return;

            ag.Text = p.Id.ToString();         
           nm.Text = p.FirstName;  
           sr.Text = p.LastName;
            //Bitmap image1 = new Bitmap(p.PhotoMaxOrig.ToString());
           // webBrowser1.Url = p.Photo50;
            //string n = p.Photo50.ToString();
            //pictureBox1.ImageLocation =n;
            //pictureBox1.Refresh();



        }


        private void Nm_Click(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Auth main = new Auth();
            main.Show();
        }
    }
}
