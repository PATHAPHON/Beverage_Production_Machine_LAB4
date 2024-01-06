using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Ingredient coffeemachine;
        public Form1()
        {
            InitializeComponent();
            coffeemachine = new Ingredient();
            UpdateTextBoxes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeBlackCoffee(); //ใน program ส่งของมูลออกมาเป็นจริงจะทำการชงเครื่องดึ่ม
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.BlackCoffee;
                textBox1.Text = "ออเดอร์ของเสร็จแล้ว กรุณารับเครื่องดื่ม";
                UpdateTextBoxes();
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Out_of_stock;
                textBox1.Text = "วัตถุดิบไม่เพียงพอโปรดเดิมวัตถุดิบ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeLatte();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Latte;
                textBox1.Text = "ออเดอร์ของเสร็จแล้ว กรุณารับเครื่องดื่ม";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.Out_of_stock;
                textBox1.Text = "วัตถุดิบไม่เพียงพอโปรดเดิมวัตถุดิบ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeMocha();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Mocha;
                textBox1.Text = "ออเดอร์ของเสร็จแล้ว กรุณารับเครื่องดื่ม";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.Out_of_stock;
                textBox1.Text = "วัตถุดิบไม่เพียงพอโปรดเดิมวัตถุดิบ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeChocolate();
            if (canMake)
            {
                pictureBox2.Image = Properties.Resources.Chocolate;
                textBox1.Text = "ออเดอร์ของเสร็จแล้ว กรุณารับเครื่องดื่ม";
                UpdateTextBoxes();

            }
            else
            {
                pictureBox2.Image = Properties.Resources.Out_of_stock;
                textBox1.Text = "วัตถุดิบไม่เพียงพอโปรดเดิมวัตถุดิบ";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coffeemachine.water += 100;
            UpdateTextBoxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coffeemachine.coffee += 100;
            UpdateTextBoxes();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coffeemachine.milk += 100;
            UpdateTextBoxes();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            coffeemachine.chocolate += 100;
            UpdateTextBoxes();
        }
        //แสดงข้อมูลของวัตถุดิบ
        private void UpdateTextBoxes()
        {
            waterbox.Text = coffeemachine.water.ToString();
            coffeebox.Text = coffeemachine.coffee.ToString();
            milkbox.Text = coffeemachine.milk.ToString();
            chocolatebox.Text = coffeemachine.chocolate.ToString();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void milkbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
