using MyFinancalCrmProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancalCrmProject
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
        void List()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }
        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();

            bills.BillTitle = txtTitle.Text;
            bills.BillPeriod =txtPeriot.Text;
            bills.BillAmount = decimal.Parse(txtAmount.Text);
            db.Bills.Add(bills);

            db.SaveChanges();
            MessageBox.Show("Ekleme başarılı bir şekilde eklendi!");
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPeriot.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var bilId = db.Bills.Find(id);
            db.Bills.Remove(bilId);
            db.SaveChanges();
            MessageBox.Show("silme işlemi başarıyle silindi");
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bilTitle =txtTitle.Text;
            decimal bilAmount = decimal.Parse(txtAmount.Text);
            string bilDate = txtPeriot.Text;
            int id = int.Parse(txtId.Text);
            var values =db.Bills.Find(id);

            values.BillTitle = bilTitle;
            values.BillAmount = bilAmount;
            values.BillPeriod = bilDate;
            db.SaveChanges();
            MessageBox.Show("güncelleme işlemi başarıyle güncellendi");
            List();



        }
    }
}
