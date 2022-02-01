using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Function_1 name1 = new Function_1();
            name1.function_1(textBox1.Text, textBox2.Text);

            textBox3.Text = name1.Perimetr;
            textBox4.Text = name1.Ploshadb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Function_2 name2 = new Function_2();
            name2.function_2(textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);

            textBox9.Text = name2.Perimetr;
            textBox10.Text = name2.Ploshadb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Function_3 name3 = new Function_3();
            name3.function_3(textBox11.Text);

            textBox12.Text = name3.Perimetr;
            textBox13.Text = name3.Ploshadb;
        }
    }
    //Расчет площади и периметра для Прямоугольника
    public class Function_1
    {
        public string Perimetr;
        public string Ploshadb;

        public void function_1(string Stor1, string Stor2)
        {
            int Stor_1 = Convert.ToInt32(Stor1);
            int Stor_2 = Convert.ToInt32(Stor2);

            int Perimetr = 2 * (Stor_1 + Stor_2);
            int Ploshadb = Stor_1 * Stor_2;

            this.Perimetr = Convert.ToString(Perimetr);
            this.Ploshadb = Convert.ToString(Ploshadb);
        }
    }
    //Расчет площади и периметра для Треугольника
    public class Function_2
    {
        public string Perimetr;
        public string Ploshadb;

        public void function_2(string Stor1, string Stor2, string Stor3, string Stor_4)
        {
            int Visota = Convert.ToInt32(Stor1);
            
            int Stor_1 = Convert.ToInt32(Stor3);
            int Stor_2 = Convert.ToInt32(Stor_4);
            int Stor_3 = Convert.ToInt32(Stor2);

            int Perimetr = Stor_3 + Stor_1 + Stor_2;
            double Ploshadb = 0.5 * Stor_3 * Visota;

            this.Perimetr = Convert.ToString(Perimetr);
            this.Ploshadb = Convert.ToString(Ploshadb);
        }
    }
    //Расчет площади и периметра для Круга
    public class Function_3
    {
        public string Perimetr;
        public string Ploshadb;

        public void function_3(string Stor1)
        {
            int Radius = Convert.ToInt32(Stor1);

            double Perimetr = 2 * 3.14 * Radius;
            double Ploshadb = 3.14 * (Radius * Radius);

            this.Perimetr = Convert.ToString(Perimetr);
            this.Ploshadb = Convert.ToString(Ploshadb);
        }
    }
}
