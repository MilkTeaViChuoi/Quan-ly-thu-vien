﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            muontrasach muontrasach = new muontrasach();
            muontrasach.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            danhmuc danhmuc = new danhmuc();
            danhmuc.Show();
            this.Hide();
        }
=======
>>>>>>> 29aa70d76e397b9e2018e5dfa244b39773e46614
    }
}
