using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursova_kripti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            richTextBox1.Text = richTextBox1.Text.ToUpper();
            richTextBox2.Text = richTextBox2.Text.ToUpper();

            string[] rich = new string[richTextBox1.Text.Length];
            for (int j = 0; j < richTextBox1.Text.Length; j++)
            {
                rich[j] = richTextBox1.Text[j].ToString();
            }
            richTextBox1.Clear();
            for (int j = 0; j < rich.Length; j++)
            {
                string[] a = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
                bool srav = (a.Contains(rich[j]));
                if (srav == false) { rich[j] = ""; }
                richTextBox1.Text = richTextBox1.Text + rich[j];
            }

            if (richTextBox1.Text.Length == richTextBox2.Text.Length)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {

                    int t = alpha.IndexOf(richTextBox1.Text[i]);
                    richTextBox3.Text = richTextBox3.Text + t.ToString()+" ";
                    int tt = alpha.IndexOf(richTextBox2.Text[i]);
                    richTextBox7.Text = richTextBox7.Text + tt.ToString()+" ";

                    int rez = (alpha.IndexOf(richTextBox1.Text[i]) - alpha.IndexOf(richTextBox2.Text[i]));
                    if (rez < 0)
                    {
                        rez = 26 + rez;
                    }
                    else
                    {
                        rez = rez % 26;
                    }

                    richTextBox6.Text = richTextBox6.Text + (rez).ToString()+" ";
                    richTextBox4.Text = richTextBox4.Text + alpha[(rez)]+"";

                }
            }
            //--------------------------------------------------------------------
            else
            {
                int rezz = (richTextBox1.Text.Length - richTextBox2.Text.Length);
                string purv = "";
                string vtor = "";
                string obshto = "";
                string tret = "";


                if (rezz <= richTextBox2.Text.Length)
                {


                    for (int i = 0; i < richTextBox2.Text.Length; i++)
                    {
                        int t = alpha.IndexOf(richTextBox2.Text[i]);

                        purv = purv + alpha[t];
                    }

             

                    for (int m = 0; m < rezz; m++)
                    {
                        int z = alpha.IndexOf(richTextBox2.Text[m]);

                        vtor = vtor + alpha[z];
                    }

                    obshto= purv + vtor;
                    for (int n = 0; n < richTextBox1.Text.Length; n++)
                    {
                        int t = alpha.IndexOf(richTextBox1.Text[n]);
                        richTextBox3.Text = richTextBox3.Text + t.ToString() + " ";
                        int tt = alpha.IndexOf(obshto[n]);
                        richTextBox7.Text = richTextBox7.Text + tt.ToString() + " ";
                        int krai = (alpha.IndexOf(richTextBox1.Text[n]) - alpha.IndexOf(obshto[n])) % 26;
                        if (krai < 0)
                        {
                            krai = 26 + krai;
                        }
                        else
                        {
                            krai = krai % 26;
                        }
                        richTextBox6.Text = richTextBox6.Text + (krai).ToString() + " ";
                        richTextBox4.Text = richTextBox4.Text + alpha[krai];

                    }
                }
            
    //----------------------------------------------------------------------------
                else
                {
                   
                    int mo = (rezz - richTextBox2.Text.Length);
                    
                    for (int i = 0; i < richTextBox2.Text.Length; i++)
                    {
                        int t = alpha.IndexOf(richTextBox2.Text[i]);

                        purv = purv + alpha[t];
                    }


                    for (int m = 0; m < richTextBox2.Text.Length; m++)
                    {
                        int z = alpha.IndexOf(richTextBox2.Text[m]);

                        vtor = vtor + alpha[z];
                    }
                    
                     for (int v = 0; v < mo; v++)
                    {
                        int j = alpha.IndexOf(richTextBox2.Text[v]);
                        tret = tret + alpha[j];
                    }

                   obshto = purv + vtor+tret;
                    for (int n = 0; n < richTextBox1.Text.Length; n++)
                    {
                        int t = alpha.IndexOf(richTextBox1.Text[n]);
                        richTextBox3.Text = richTextBox3.Text + t.ToString() + " ";
                        int tt = alpha.IndexOf(obshto[n]);
                        richTextBox7.Text = richTextBox7.Text + tt.ToString() + " ";

                        int krai = (alpha.IndexOf(richTextBox1.Text[n]) - alpha.IndexOf(obshto[n])) % 26;
                        if (krai < 0)
                        {
                            krai = 26 + krai;
                        }
                        else
                        {
                            krai = krai % 26;
                        }
                        richTextBox6.Text = richTextBox6.Text + (krai).ToString() + " ";
                        richTextBox4.Text = richTextBox4.Text + alpha[krai];
                    }
                }                             
              }
           }   // Шифър Виженер
       
          

        private void button2_Click(object sender, EventArgs e)
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            richTextBox4.Text = richTextBox4.Text.ToUpper();
            richTextBox10.Text = richTextBox10.Text.ToUpper();
            
            String[,] a = new String[richTextBox11.Text.Length, richTextBox10.Text.Length];
            String[,] b = new String[richTextBox11.Text.Length, richTextBox10.Text.Length];
            String[,] c = new String[richTextBox11.Text.Length, richTextBox10.Text.Length];


            String br = "";
            String obsh="";
            int h = 0;
            int z = 0;

            for (int i = 0; i < richTextBox11.Text.Length; i++)
            {
                for (int j = 0; j < richTextBox10.Text.Length; j++)
                {
                    if (richTextBox4.Text.Length < (richTextBox10.Text.Length * richTextBox11.Text.Length))
                    {
                        int raz = (richTextBox10.Text.Length * richTextBox11.Text.Length) - richTextBox4.Text.Length;
                        for (int k = 0; k < raz; k++)
                        {
                            br = br + "X";
                        }
                        obsh = richTextBox4.Text + br;
                        //a[i, j] = alpha.IndexOf(obsh[z]);
                        a[i, j] = obsh[z].ToString();
                        z++;
                        richTextBox9.Text = richTextBox9.Text + a[i, j] + "|";


                    }
                    else
                    {
                        //a[i, j] = alpha.IndexOf(richTextBox1.Text[h]);
                        a[i, j] = richTextBox4.Text[h].ToString();
                        h++;
                        richTextBox9.Text = richTextBox9.Text + a[i, j] + "|";
                    }
                }

                richTextBox9.Text = richTextBox9.Text + Environment.NewLine;
            }
//--------------------------------------------------------------------------
 for (int i = 0; i < richTextBox11.Text.Length; i++)
 {
     for (int j = 0; j < richTextBox10.Text.Length; j++)
     {
              
         b[i, j] = a[i, j];
           
     }
 }
//------------------------------------------------------------


 for (int v = 0; v < richTextBox11.Text.Length; v++)
 {
     for (int l = 0; l < richTextBox10.Text.Length; l++)         //za smqna na redove za key2
     {
         int zozo = int.Parse((richTextBox11.Text[v]).ToString());
         b[v, l] = a[(zozo - 1), l];
     }
 }





 for (int i = 0; i < richTextBox11.Text.Length; i++)    //za pokazvane na B
 {
     for (int j = 0; j < richTextBox10.Text.Length; j++)
     {
         richTextBox5.Text = richTextBox5.Text + b[i, j] + "|";
     }
     richTextBox5.Text = richTextBox5.Text + Environment.NewLine;
 }
     string[] str=new string[richTextBox10.Text.Length];
     string[] strr = new string[richTextBox10.Text.Length];
     string key = "";
     string keyy = "";
     for (int kk = 0; kk < richTextBox10.Text.Length;kk++)
        {
            str[kk] = richTextBox10.Text[kk].ToString();
        }
  
 Array.Sort(str);                        //sortirane po azbu4en red
 foreach (string ele in str)   
     key = key + ele;                     //key-sudurja podredenite bukvi

    for (int f = 0; f < key.Length; f++)
			{
                keyy =keyy+ key.IndexOf(richTextBox10.Text[f]).ToString();
			}

    for (int i = 0; i < richTextBox11.Text.Length; i++)
    {
        for (int j = 0; j < richTextBox10.Text.Length; j++)
        {

            c[i, j] = b[i, j];

        }
    }

    for (int j = 0; j < richTextBox10.Text.Length; j++)
    {
         for (int i = 0; i < richTextBox11.Text.Length; i++)
        {
            int zozo = int.Parse((keyy[j]).ToString());
            c[i, j] = b[i,(zozo)];

        }
    }

    for (int i = 0; i < richTextBox11.Text.Length; i++)    //za pokazvane na B
    {
        for (int j = 0; j < richTextBox10.Text.Length; j++)
        {
            richTextBox12.Text = richTextBox12.Text + c[i, j] + "|";
            richTextBox8.Text = richTextBox8.Text + c[i, j];
        }
        richTextBox12.Text = richTextBox12.Text + Environment.NewLine;
    }


                }   //Поредово транспозиционен шифър

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog. 
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                richTextBox1.LoadFile(openFile1.FileName);
            }
        }   //Въвеждане на дума от файл
                
            }
        }
    


               
            
           
        

    

