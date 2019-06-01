using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        void otkl()
        {
            radioButton1.Checked = false; //1
            radioButton2.Checked = false; //2
            radioButton3.Checked = false; //3
            radioButton4.Checked = false; //4
            radioButton5.Checked = false; //5
            radioButton6.Checked = false; //6
            radioButton7.Checked = false; //7
            radioButton8.Checked = false; //8
            radioButton9.Checked = false; //9
            radioButton10.Checked = false; //10
            radioButton11.Checked = false; //11
            radioButton12.Checked = false; //12
            radioButton13.Checked = false; //13
            radioButton14.Checked = false; //14
            radioButton15.Checked = false; //15 
            radioButton16.Checked = false; //16
            radioButton17.Checked = false; //17
            radioButton18.Checked = false; //18
            radioButton19.Checked = false; //19
            radioButton20.Checked = false; //20
            radioButton21.Checked = false; //21
            radioButton22.Checked = false; //22
            radioButton23.Checked = false; //23
            radioButton24.Checked = false; //24
            radioButton25.Checked = false; //25
            radioButton26.Checked = false; //26
            radioButton27.Checked = false; //27
            radioButton28.Checked = false; //28
            radioButton29.Checked = false; //29
            radioButton30.Checked = false; //30
            radioButton31.Checked = false; //31
            radioButton32.Checked = false; //32
            radioButton33.Checked = false; //33
            radioButton34.Checked = false; //34
            radioButton35.Checked = false; //35
            radioButton36.Checked = false; //36

        }
        void off()
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            off();
            textBox1.Visible = true;
            button8.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            off();
            textBox2.Visible = true;
            button8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            off();
            textBox3.Visible = true;
            button8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            off();
            textBox4.Visible = true;
            button8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            off();
            textBox5.Visible = true;
            button8.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            off();
            textBox6.Visible = true;
            button8.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Учебник создал студент Академического колледжа  \n обучающийся в группе 2-ПКС9 \n Ванян Г.А.", "Сведения об Авторе");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            off();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            off();
            button8.Visible = false;
            panel1.Visible = true;
            tabControl1.Visible = true;
            otkl();
            tabControl1.SelectedIndex = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; // убираем панель
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1; //кнопка далее , + 1 к стр
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1; // кнопка Назад , -1 к стр
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                button12.Enabled = false; // блок кнопки НАЗАД при нахождении на 1 стр
            }
            else
            {
                button12.Enabled = true; // иначе вкл
            }

            if (tabControl1.SelectedIndex == 9)
            {
                button10.Enabled = false; // блок кнопки ДАЛЕЕ при стр 10 
            }
            else
            {
                button10.Enabled = true; // иначе выкл
            }
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            button15.Visible = true;
            tabControl1.Visible = false; // выключаем всё возможное из теста
            button12.Visible = false;
            button10.Visible = false;
            label1.Visible = true; // включаем показ результатов 
            label2.Visible = true;
            int s = 0;
            int i = 9;
            if (radioButton3.Checked == false) //первый вопрос
            {
                i--;
            }

            if (radioButton6.Checked == false) // второй вопрос
            {
                i--;
            }

            if (radioButton10.Checked == false) // третий вопрос
            {
                i--;
            }

            if (radioButton16.Checked == false) // четвертый вопрос
            {
                i--;
            }

            if (radioButton18.Checked == false) // пятый вопрос
            {
                i--;
            }

            if (radioButton22.Checked == false) // шестой вопрос
            {
                i--;
            }

            if (radioButton28.Checked == false) // седьмой вопрос
            {
                i--;
            }
            if (radioButton29.Checked == false) // восьмой вопрос
            {
                i--;
            }
            if (radioButton35.Checked == false) // девятый вопрос
            {
                i--;
            }



            //ПОДСЧЁТ ОЦЕНКИ

            if (i == 9)
                s = 5;
            if (i == 8)
                s = 4;
            if (i == 7)
                s = 4;
            if (i == 6)
                s = 3;
            if (i == 5)
                s = 3;
            if (i < 5)
                s = 2;

            // если  тест не сдан
            if (s < 5)

                label2.ForeColor = Color.Red;
            
            if (s < 5)
                label2.Text = ("Зачет не сдан! Оценка: " + Convert.ToString(s));

            // если тест сдан
            if (s >= 3)
                label2.ForeColor = Color.Lime;
            if (s >= 3)
                label2.Text = ("Зачёт сдан! Оценка: " + Convert.ToString(s));


        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ответ не правильный! подумай ещё раз!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            tabControl1.Visible = true;
            otkl();
            tabControl1.SelectedIndex = 0;
            button12.Visible = true;
            button10.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button16_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int T = 150;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
