using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        int soru;
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                
            
               
                 //ceavp1
                 switch (soruno)
                {
                    case 1:
                        if(textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor= Color.Red;
                            yanlıs++;
                            label3.Text= yanlıs.ToString();
                        }
                        break;
                        //cevap2
                        case 2:
                        if(textBox1.Text == "bursa")
                        {
                            button2.BackColor=Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor= Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                        //cevap3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    //cevap4
                    case 4:
                        if (textBox1.Text == "diyerbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    //cevap5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break; 
                        //cevap6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    //cevap7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;
                    //cevap8
                    case 8:
                        if (textBox1.Text == "cuma")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlıs++;
                            label3.Text = yanlıs.ToString();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++; 
            soru++;
            this.Text=soruno.ToString();
            textBox1.Text = "";
           
           
            if (soruno == 1)
            {
                richTextBox1.Text = "ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;

            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "karpuzu ile ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "yeni kelimesinin zıt anlamı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrençilerin kötü karne getirnce bakıştığı nesnene?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyalının meşur meyvesi?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bağar aylarında düzenlenen meşur çiçek festivali?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların cok sevmediği pirinç, havuc gibi sebzelerle yapılan yemek?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11Ayın sultanı?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "şimşek kelimesinin eş anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Ege bölgsinin en çok ağacı bulunan yalıda yapılan kahvaltı besini?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Kebabı ile ünlü ilimiz?";
                button23.BackColor = Color.Yellow;
            }

        }
    }
}
