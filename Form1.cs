using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface IFigure
    {
        double obliczPole();
        double obliczObwód();
    }

    class trojkat:IFigure
    {
       public  double podstawa, wysokosc,bok_a,bok_b,pole, obwod;

        public double obliczPole()
         {
             return pole = podstawa * wysokosc / 2;
         }

         public double obliczObwód()
         {
             return obwod = bok_a + bok_b + podstawa;
         }
    }

    class kolo:IFigure
    {
        public double promien;
        public double obliczPole()
        {
            return Math.PI * promien * promien;
        }
        public double obliczObwód()
        {
            return Math.PI * 2 * promien;
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            trojkat tr = new trojkat();
            tr.podstawa = Double.Parse(textBox1.Text);
            tr.wysokosc = Double.Parse(textBox4.Text);
            textBox5.Text = tr.obliczPole().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trojkat tr = new trojkat();
            tr.podstawa = Double.Parse(textBox1.Text);
            tr.bok_a = Double.Parse(textBox2.Text);
            tr.bok_b = Double.Parse(textBox3.Text);
            textBox6.Text = tr.obliczObwód().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kolo o = new kolo();
            o.promien = Double.Parse(textBox7.Text);
            textBox8.Text = o.obliczPole().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kolo o = new kolo();
            o.promien = Double.Parse(textBox7.Text);
            textBox9.Text = o.obliczObwód().ToString();
        }
    }
}
