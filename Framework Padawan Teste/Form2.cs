using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Framework_Padawan_Teste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ObterPublicacao();
            this.Cursor = new Cursor(Properties.Resources.Lightsaber_Green_icon_34496.Handle);
        }
        public async void ObterPublicacao()
        {

            var client = new HttpClient();

            var result = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            string content = await result.Content.ReadAsStringAsync();

            var todos = JsonConvert.DeserializeObject<List<Posts>>(content);
            listView1.View = View.Details;
            listView1.Columns.Add("Id",50, HorizontalAlignment.Left);  //Tamanho da linha
            listView1.Columns.Add("Title", 500, HorizontalAlignment.Left);
            listView1.Columns.Add("UserId", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Body", 1000, HorizontalAlignment.Left);
           
            for (int i =0; i <= 99; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { todos[i].id.ToString(), todos[i].title, todos[i].userId.ToString(), todos[i].body})); //aparece a liste
                Console.WriteLine(i);
            }

            listView1.GridLines = true;
            //listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None; 
           
         


            Console.WriteLine(result.StatusCode);
        }

        class Posts
        {
            public int userId;
            public int id;
            public string title;
            public string body;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
