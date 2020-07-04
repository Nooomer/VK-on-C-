using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Model;
using VkNet.AudioBypassService;
using Microsoft.Extensions.DependencyInjection;
using VkNet.AudioBypassService.Extensions;
using VkNet.Model.RequestParams;

namespace VKK
{   
    public partial class wall : Form
    {
        public string w_id = " ";
        public wall()
        {
            InitializeComponent();
        }
        static string Token1 = "";
        static public void GetToken3(string Token)
        {
            Token1 = Token;
        }
        private void Button1_Click(object sender, EventArgs e)
        {


            var api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                AccessToken = Token1
            }) ;
            


            var post = api.Wall.Post(new WallPostParams
            {
                //if (w_id == " ") OwnerId = p.Id.ToString();
                OwnerId = long.Parse(w_id),
                Message = richTextBox1.Text,




            }) ;
        }

private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            w_id = textBox1.Text; 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Auth main = new Auth();
            this.Close();
            main.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }

