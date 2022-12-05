using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class formCalculator : Form
    {
        public formCalculator()
        {
            InitializeComponent();
            OperatorInit();
        }

        private void OperatorInit()
        {
            txtOperasi.Items.Clear();
            txtOperasi.Items.Add("Penjumlahan");
            txtOperasi.Items.Add("Pengurangan");
            txtOperasi.Items.Add("Perkalian");
            txtOperasi.Items.Add("Pembagian");
            txtOperasi.SelectedIndex = 0;
        }

        public delegate void Hasil(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil);

        public event Hasil prosesEvent;

     
        
            

        private void btnProses_Click(object sender, EventArgs e)
        {
                int nilaiA = int.Parse(txtNilaiA.Text);
                int nilaiB = int.Parse(txtNilaiB.Text);
                string operasi = "";
                string operasiLabel = "";
                float hasil = 0;
                switch (txtOperasi.SelectedIndex)
                {
                    // Penjumlahan
                    case 0:
                        hasil = Operator.Penjumlahan(nilaiA, nilaiB);
                        operasiLabel = "Penjumlahan";
                        operasi = "+";
                        break;
                    // Pengurangan
                    case 1:
                        hasil = Operator.Pengurangan(nilaiA, nilaiB);
                        operasiLabel = "Pengurangan";
                        operasi = "-";
                        break;
                    // Perkalian
                    case 2:
                        hasil = Operator.Perkalian(nilaiA, nilaiB);
                        operasiLabel = "Perkalian";
                        operasi = "x";
                        break;
                    // Pembagian
                    case 3:
                        hasil = (float)Operator.Pembagian(nilaiA, nilaiB);
                        operasiLabel = "Pembagian";
                        operasi = "/";
                        break;

                }
                prosesEvent(nilaiA, nilaiB, operasi, operasiLabel, hasil);
        }

    }
}
