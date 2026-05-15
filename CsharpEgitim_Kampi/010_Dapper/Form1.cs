using _010_Dapper.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_Dapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbLibrary;Trusted_Connection=True;");
      
        private  async void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var query = "insert into TblBook(BookName,Author,BookPageCount) values(@bookname,@author,@bookpagecount)";
            var parametre = new DynamicParameters();
            parametre.Add("@bookname", txtname.Text);
            parametre.Add("@author", txtwriter.Text);
            parametre.Add("@bookpagecount",int.Parse(txtpage.Text));
            await connection.ExecuteAsync(query,parametre);
            List();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            List();
        }
        async void List()
        {
            var query = "select * from TblBook";
            var values = await connection.QueryAsync<ResultBookDto>(query);
            dataGridView1.DataSource = values;
        }
       async void Sil()
        {
            var query = "Delete from TblBook where BookID =@bookId";
            var parametre = new DynamicParameters();
            parametre.Add("@bookId", txtId.Text);
            await connection.ExecuteAsync(query, parametre);
            MessageBox.Show("Silme işlemi başarılı silindi");
        }

        async void Guncelleme()
        {
            var query = "Update TblBook set BookName=@bookname, Author=@author,BookPageCount=@bookPageCount where BookID=@bookId";
            var parametre = new DynamicParameters();
            parametre.Add("@bookname", txtname.Text);
            parametre.Add("@author", txtwriter.Text);
            parametre.Add("@bookPageCount", txtpage.Text);
            parametre.Add("@bookId", int.Parse(txtId.Text));

            await connection.ExecuteAsync(query,parametre);
            MessageBox.Show("Güncellendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelleme();
            List();
        }
    }
}
