using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapierCubuklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int value = 8;
            string binary = Convert.ToString(value, 2);
            int kop= Convert.ToInt32(binary, 2);
            string[] dizi = new string[5];
            label1.Text = Convert.ToString(checkBox1.Checked);
        
            //label1.Text = binary;
            label3.Text = "21";
            label4.Text = "17";
            label5.Text = "24";
            label6.Text = "27";
            label7.Text = "18";
            label8.Text = "19";
            label9.Text = "26";
            label10.Text = "30";
            label11.Text = "29";
            label12.Text = "22";
            label13.Text = "28";
            label14.Text = "16";
            label15.Text = "25";
            label16.Text = "31";
            label17.Text = "20";
            label18.Text = "23";
            label19.Text = "10";
            label20.Text = "11";
            label21.Text = "28";
            label22.Text = "9";
            label23.Text = "30";
            label24.Text = "8";
            label25.Text = "27";
            label26.Text = "12";
            label27.Text = "25";
            label28.Text = "31";
            label29.Text = "29";
            label30.Text = "26";
            label31.Text = "15";
            label32.Text = "14";
            label33.Text = "24";
            label34.Text = "13";
            label35.Text = "19";
            label36.Text = "6";
            label37.Text = "10";
            label38.Text = "18";
            label39.Text = "7";
            label40.Text = "31";
            label41.Text = "14";
            label42.Text = "3";
            label43.Text = "30";
            label44.Text = "2";
            label45.Text = "15";
            label46.Text = "27";
            label47.Text = "26";
            label48.Text = "23";
            label49.Text = "11";
            label50.Text = "22";
            label51.Text = "7";
            label52.Text = "14";
            label53.Text = "31";
            label54.Text = "15";
            label55.Text = "29";
            label56.Text = "21";
            label57.Text = "6";
            label58.Text = "30";
            label59.Text = "20";
            label60.Text = "12";
            label61.Text = "23";
            label62.Text = "28";
            label63.Text = "22";
            label64.Text = "5";
            label65.Text = "13";
            label66.Text = "4";
            label67.Text = "11";
            label68.Text = "21";
            label69.Text = "17";
            label70.Text = "19";
            label71.Text = "13";
            label72.Text = "9";
            label73.Text = "25";
            label74.Text = "7";
            label75.Text = "31";
            label76.Text = "23";
            label77.Text = "1";
            label78.Text = "29";
            label79.Text = "15";
            label80.Text = "27";
            label81.Text = "3";
            label82.Text = "5";
            Random rnd = new Random();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cb1 = checkBox1.Checked == false ? "1" : "0";
            string cb2 = checkBox2.Checked == false ? "1":"0" ;
            string cb3 = checkBox3.Checked == false ? "1" : "0";
            string cb4 = checkBox4.Checked == false ? "1" : "0";
            string cb5 = checkBox5.Checked == false ? "1" : "0";
            string cb_all = cb1 + cb2 + cb3 + cb4 + cb5;
            int son = Convert.ToInt32(cb_all, 2);
            label2.Text = Convert.ToString(son);



        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
    }
}
