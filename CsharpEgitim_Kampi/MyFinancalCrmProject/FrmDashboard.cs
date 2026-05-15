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
using System.Windows.Forms.DataVisualization.Charting;

namespace MyFinancalCrmProject
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Count++;
            if( Count % 4 == 1)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblAmount.Text = elektrikFaturasi.ToString() + " " + "₺";
            }
            if( Count % 4 == 2)
            {
                var suFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblAmount.Text = suFaturasi.ToString() + " " + "₺";

            }
            if (Count % 4 == 3)
            {
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblAmount.Text = internetFaturasi.ToString() + " " + "₺";

            }
            if (Count % 4 == 0)
            {
                var GazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblAmount.Text = GazFaturasi.ToString() + " " + "₺";

            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
           
            var sumBalance = db.Banks.Sum(x => x.BankBalance);
            lblSumBalance.Text = sumBalance.ToString() + " " + "₺";

            var lasprocessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y =>y.Amount).FirstOrDefault();

            lblLastProcessAmount.Text = lasprocessAmount.ToString() + " " + "₺";


            //Chart1 kodlar

            var bankaData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            });
            chart1.Series.Clear();

            var series = chart1.Series.Add("Series1");
            foreach(var item in bankaData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            //Chart 2 kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            });
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType =SeriesChartType.Renko;
            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }
    }
}
