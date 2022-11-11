using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Kontak_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bersih()
        {
            txtNama.Clear();
            txtHP.Clear();
            //dgvKontak.Rows.Clear();
            txtNama.Focus();       }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKontak.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKontak.Columns[0].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            dgvKontak.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvKontak.Columns[1].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            dgvKontak.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvKontak.Columns[2].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            dgvKontak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            bersih();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int count = dgvKontak.Rows.Count;
            dgvKontak.Rows.Add();
            dgvKontak.Rows[count].Cells[0].Value = count + 1;
            dgvKontak.Rows[count].Cells[1].Value = txtNama.Text;
            dgvKontak.Rows[count].Cells[2].Value = txtHP.Text;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bersih2();
        }

        private void bersih2()
        {
            dgvKontak.Rows.Clear();
        }
    }
}
