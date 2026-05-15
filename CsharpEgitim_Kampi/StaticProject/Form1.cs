using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EfTravelDbEntities db = new EfTravelDbEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            LblLocationCount.Text = db.TblLocation.Count().ToString();
            lblGuidCount.Text = db.TblGuid.Count().ToString();
            lblSumKapasite.Text =db.TblLocation.Sum(x => x.LocationCapacity).ToString();
            lblAverageLocation.Text =db.TblLocation.Average(x => x.LocationCapacity).ToString();
            lblSumPrice.Text = db.TblLocation.Sum(x => x.LocationPrice).ToString();
            lblLastCountry.Text = db.TblLocation.OrderByDescending(x => x.LocationId).Select(y => y.LocationCountry).FirstOrDefault();
            lblTokyoKapasite.Text = db.TblLocation.Where(x => x.LocationCity == "Tokyo").Average(y => y.LocationCapacity).ToString();
            lblAverageTurkeyPrice.Text = db.TblLocation.Where(x => x.LocationCountry =="Fransa").Sum(y => y.LocationPrice).ToString();

            var guideId = db.TblLocation.Where(x => x.LocationCity =="Roma").Select(y => y.GuidId).FirstOrDefault();
            lblRomaGuide.Text = db.TblGuid.Where(x => x.GuidId ==guideId).Select(y => y.GuidName + " " + y.GuidSurname).FirstOrDefault();
            lblMaxKapasite.Text = db.TblLocation.Max(x => x.LocationCapacity).ToString();
            LblMaxPriceTur.Text = db.TblLocation.Max(y => y.LocationPrice).ToString();

            var guidename = db.TblGuid.Where(x => x.GuidName == "Ayşe" && x.GuidSurname == "Demir").Select(y => y.GuidId).FirstOrDefault();
            lblAyseTurCount.Text = db.TblLocation.Where(x => x.GuidId == guidename).Count().ToString();
           
        }
    }
}
