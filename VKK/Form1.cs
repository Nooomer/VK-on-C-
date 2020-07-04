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
using VkNet.Model.RequestParams;
using VkNet.Enums.Filters;
using VkNet.AudioBypassService.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VKK
{[Serializable]
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        
        private void AH_Click(object sender, EventArgs e)
        {

            //string log, pass;
            var services = new ServiceCollection();
            services.AddAudioBypass();
            var api = new VkApi(services);
            //BinaryFormatter formatter = new BinaryFormatter();
            //void ser()
            //{
            //    using (FileStream fs = new FileStream("Login.dat", FileMode.OpenOrCreate))
            //    {
            //        formatter.Serialize(fs, log_box.Text);
            //    }
            //    using (FileStream fs = new FileStream("Password.dat", FileMode.OpenOrCreate))
            //    {
            //        formatter.Serialize(fs, pass_box.Text);
            //    }

            //}

            //            int deser()
            //            {
            //                string []fhd = new string[2];
            //                using (FileStream fs = new FileStream("Login.dat", FileMode.OpenOrCreate))
            //                {

            //                    log = (string)formatter.Deserialize(fs);


            //                }
            //                using (FileStream fs = new FileStream("Password.dat", FileMode.OpenOrCreate))
            //                {

            //                    pass = (string)formatter.Deserialize(fs);


            //                }
            //                return 1;
            //            }
            //            if (deser()==1)
            //            {
            //                api.Authorize(new ApiAuthParams
            //                {
            //                    ApplicationId = 7168879,
            //                    Login = log,

            //                    Password = pass,
            //                    //Settings = Settings.All
            //                });
            //            }
            //            else
            //            {


            api.Authorize(new ApiAuthParams
            {
                ApplicationId = 7168879,
                Login = log_box.Text,

                Password = pass_box.Text,
                Settings = Settings.All
            });
            //            }

            Inf.GetToken(api.Token);
            msg.GetToken2(api.Token);
            wall.GetToken3(api.Token);
            var res = api.Groups.Get(new GroupsGetParams());


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Inf inf = new Inf();
            this.Hide();
            inf.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            msg msg = new msg();
            this.Hide();
            msg.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            wall wall = new wall();
            this.Hide();
            wall.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
