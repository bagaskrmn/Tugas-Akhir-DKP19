using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koronet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            terpanggil baru = new terpanggil();
            textBox1.Text = baru.kara();
            //textBox1.Text = "Intel Core I7-8750U, NVIDIA GTX 1080 Ti 11GB, RAM 32GB, HyperX Cloud II Headset, G703 Mouse, Black Widow Keyboard";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            terpanggil baru = new terpanggil();
            textBox1.Text = baru.koro();
            //textBox1.Text = "Intel Core I5-8350U, NVIDIA GTX 1070 8GB, RAM 16GB, G430 Headset, G403 Mouse, DA K1 keyboard";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            terpanggil baru = new terpanggil();
            textBox1.Text = baru.karo();
            //textBox1.Text = "Intel Core I5-8250U, NVIDIA GTX 1050 Ti 4GB, RAM 16GB, Fantech HG15 Headset, G400s Mouse, G213 keyboard";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kelas;
            int harga = 0;
            int total;
            int paket = 0;
            int jumlah = int.Parse(textBox3.Text);
            string nama = textBox2.Text;
            kelas = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0) //kelas VVIP
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    harga = 10000; //paket 1 jam
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    harga = 18000; // paket 2 jam
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    harga = 40000; // paket 5 jam
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    harga = 70000; // paket 10 jam
                }
            }
            else if (comboBox1.SelectedIndex == 1) //kelas VIP
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    harga = 7000; //paket 1 jam
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    harga = 12000; // paket 2 jam
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    harga = 30000; // paket 5 jam
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    harga = 55000; // paket 10 jam
                }
            }
            else if (comboBox1.SelectedIndex == 2) //kelas REUGLAR
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    harga = 4000; //paket 1 jam     
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    harga = 7000; // paket 2 jam 
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    harga = 14000; // paket 5 jam  
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    harga = 25000; // paket 10 jam
                }
            }
            total = harga * jumlah;
            textBox4.Text = "Selamat ! \nPenyewaan PC berjumlah " + jumlah + " Atas nama " + nama + " berhasil !";
            textBox5.Text = "Silahkan lakukan pembayaran pada kasir sejumlah Rp." + total;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih telah Menggunakan Koronet");
            Application.Exit();
        }
    }
}

