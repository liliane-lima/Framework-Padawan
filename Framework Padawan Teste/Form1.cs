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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Cursor = new Cursor(Properties.Resources.Lightsaber_Green_icon_34496.Handle);
            
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 Publi = new Form2();
            Publi.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 Albums = new Form3();
            Albums.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 Todos = new Form4();
            Todos.ShowDialog();
        }

        
    }
}
