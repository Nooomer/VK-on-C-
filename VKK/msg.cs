
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
using System.Net;
using VkNet.Model.RequestParams;
using VkNet.Enums.SafetyEnums;
using System.Collections.ObjectModel;

namespace VKK
{
    public partial class msg : Form
    {
        public long[] ids = new long[20];
        public long s_id;
        object[] dj = new object[20];
        string[] names = new string[20];
        string[] l_name = new string[20];
        long[] id = new long[20];

        public msg()
        {
            InitializeComponent();

        }
        static string Token1 = "";

        static public void GetToken2(string Token)
        {
            Token1 = Token;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();



            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            api.Authorize(new ApiAuthParams
            {
                AccessToken = Token1
            });

            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {

                RandomId = rnd.Next(0, 999999),
                UserId = s_id,
                Message = richTextBox1.Text
            });
        }

        private void Msg_Load(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            api.Authorize(new ApiAuthParams
            {
                AccessToken = Token1
            });
            var getDialogs = api.Messages.GetConversations(new GetConversationsParams
            {
                Count = 10
            });

            //var k = api.Users.Get(new long[] { }).FirstOrDefault();

            for (int i = 0; i < 10;)
            {
                if ((getDialogs.Items[i].Conversation.Peer.Type).ToString() == "user")
                {
                    long id = getDialogs.Items[i].Conversation.Peer.Id;

                    ids[i] = id;
                    var l = api.Users.Get(new long[] { id }).FirstOrDefault();
                    if (l == null)
                        return;
                    comboBox1.Items.Add(l.FirstName + " " + l.LastName);
                    i++;
                    // 1
                    //Console.WriteLine(l.FirstName);  // "Павел"
                    //Console.WriteLine(l.LastName);

                    //names[i] = name.FirstName;
                    //l_name[i] = name.LastName;
                    //id[i] = name.Id;

                }
                else
                {

                }
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 1:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 2:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 3:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 4:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 5:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 6:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 7:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 8:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 9:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;
                case 10:
                    while (ids[i] == 0)
                    {
                        i++;
                    }
                    s_id = ids[i];
                    i = 0;
                    break;


            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Auth main = new Auth();
            main.Show();
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            api.Authorize(new ApiAuthParams
            {
                AccessToken = Token1
            });
            var p = api.Users.Get(new long[] { }).FirstOrDefault();
            if (p == null)
                return;

            // var setActivity = api.Messages.SetActivity(p.Id.ToString(), MessageActivityType.Typing, s_id,null);

            var uploadServer = api.Photo.GetMessagesUploadServer(s_id);
            openFileDialog1.ShowDialog();
            // Загрузить файл.
            var wc = new WebClient();
            var responseFile = Encoding.ASCII.GetString(wc.UploadFile(uploadServer.UploadUrl, openFileDialog1.FileName));
            // Сохранить загруженный файл
            var photos = api.Photo.SaveMessagesPhoto(responseFile);
            Random rnd = new Random();

            //string message = "You not write text. You want do this?";
            //string caption = "Write text";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result;

            // Displays the MessageBox.



            //if (richTextBox1.Text=="")
            //{  
            //    result = MessageBox.Show(message, caption, buttons);
            //    if(result == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        while (richTextBox1.Text == "")
            //        {
            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {

                RandomId = rnd.Next(0, 999999),
                UserId = s_id,
                Attachments = photos,
                Message = richTextBox1.Text
            });
            //    }
            //}
            //else
            //{
            //    api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            //    {

            //        RandomId = rnd.Next(0, 999999),
            //        UserId = s_id,
            //        Attachments = photos,
            //       // Message = richTextBox1.Text
            //    });
            //}
        }



        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
