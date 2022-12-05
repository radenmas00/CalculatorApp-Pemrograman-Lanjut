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
    public partial class formHasilPerhitungan : Form
    {
        public formHasilPerhitungan()
        {
            InitializeComponent();
           
        }
        // atur kolom listview


        private void HasilHitung(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            lvwHasil.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            formCalculator frmEntry = new formCalculator();
            frmEntry.prosesEvent += HasilHitung;
            frmEntry.ShowDialog();
        }
    }
}
