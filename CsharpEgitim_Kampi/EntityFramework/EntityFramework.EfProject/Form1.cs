using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework.EfProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EfTravelDbEntities1 db = new EfTravelDbEntities1();
        private void btnListele_Click(object sender, EventArgs e)
        {

            var values = (from L in db.TblLocation
                          join G in db.TblGuid
                          on L.GuidId equals G.GuidId
                          select new
                          {
                              L.LocationId,
                              L.LocationCity,
                              L.LocationCountry,
                              L.LocationCapacity,
                              L.LocationPrice,
                              L.DayNight,
                              GuidName = G.GuidName,
                              GuidSurname = G.GuidSurname,
                          }).ToList();
           
            dataGridView1.DataSource = values;
           
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           

       TblGuid guid = new TblGuid();
        guid.GuidName =txtName.Text;
        guid.GuidSurname =txtSoyad.Text;
        db.TblGuid.Add(guid);
        db.SaveChanges();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id =int.Parse( txtId.Text);
            var GuideId = db.TblGuid.Find(id);
            db.TblGuid.Remove(GuideId);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyle Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id =int.Parse( txtId.Text);
            var GuideId =db.TblGuid.Find(id);

           GuideId.GuidName =txtName.Text;
           GuideId.GuidSurname=txtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyle Güncellendi");

        }

        private void btnIdGoreGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse( txtId.Text);
            var GuideValue = db.TblGuid.Where(x => x.GuidId == id).ToList();

            dataGridView1.DataSource = GuideValue;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var values = db.TblGuid.ToList();
            comboBox1.DisplayMember = "GuidName";
            comboBox1.ValueMember = "GuidId";
            comboBox1.DataSource = values;
        }
    }
}
