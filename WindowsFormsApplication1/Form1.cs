using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label2.Location);
            pos = pictureBox7.PointToClient(pos);
            label2.Parent = pictureBox7;
            label2.Location = pos;
            label2.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(label3.Location);
            pos1 = pictureBox7.PointToClient(pos1);
            label3.Parent = pictureBox7;
            label3.Location = pos1;
            label3.BackColor = Color.Transparent;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu.Visible = false;

            login1.Visible = false;
            register1.Visible = false;
            custRegister1.Visible = false;
            //custRegister1.BringToFront();

            viewBookingRecord1.Visible = false;
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            menu.Visible = true;
            menu.BringToFront();
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            login1.Visible = true;
            login1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register1.Visible = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            custRegister1.Visible = true;
            custRegister1.BringToFront();
            custRegister1.Select();
            menu.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            viewBookingRecord1.Visible = true;
            viewBookingRecord1.BringToFront();
            viewBookingRecord1.Select();
            menu.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menu.Visible = false;

            login1.Visible = false;
            register1.Visible = false;
            custRegister1.Visible = false;
            //custRegister1.BringToFront();

            viewBookingRecord1.Visible = false;
        }
    }
}

