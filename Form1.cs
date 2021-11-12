using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebPageCreationTool
{
    public partial class Form1 : Form
    {
        string title = "";
        string body = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            title = textBox1.Text;
            body =richTextBox1.Text;
            MakeItHTML html = new MakeItHTML(title, body);
            Export.Save(title.ToLower()+".html",html.GetHTML());
            MessageBox.Show("File has been saved as html in your documents folder");

        }
    }
}
