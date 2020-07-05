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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ObterTodos();
            this.Cursor = new Cursor(Properties.Resources.Lightsaber_Green_icon_34496.Handle);
        }
        public async void ObterTodos()
        {

            var client = new HttpClient();

            var result = await client.GetAsync("https://jsonplaceholder.typicode.com/todos");
            string content = await result.Content.ReadAsStringAsync();

            var todos = JsonConvert.DeserializeObject<List<ToDo>>(content);
            listView1.View = View.Details;
            listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);  //Tamanho da linha
            listView1.Columns.Add("title", 500, HorizontalAlignment.Left);
            listView1.Columns.Add("userId", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Completed", 100, HorizontalAlignment.Left);

            for (int i = 0; i <= 199; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { todos[i].id.ToString(), todos[i].title, todos[i].userId.ToString(), todos[i].completed.ToString() })); //aparece a liste
                Console.WriteLine(i);
            }

            listView1.GridLines = true;
            //listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;



            Console.WriteLine(result.StatusCode);
        }

        class ToDo
        {
            public int userId;
            public int id;
            public string title;
            public bool completed;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
