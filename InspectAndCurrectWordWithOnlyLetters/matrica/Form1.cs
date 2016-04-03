using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] rich=new string[richTextBox1.Text.Length];
            for (int j = 0; j < richTextBox1.Text.Length; j++)
            {
                rich[j]=richTextBox1.Text[j].ToString();
            }
            richTextBox1.Clear();
            for (int j = 0; j < rich.Length; j++)
            {
                string[] a=new string[26]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
                bool srav=(a.Contains(rich[j]));
                if (srav==false){rich[j] = "";}         
                richTextBox1.Text = richTextBox1.Text + rich[j];                
            }
            
        }
    }
}
