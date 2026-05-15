using MyFinancalCrmProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFinancalCrmProject
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri

            var zirratBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakiBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();
            var halkBankBalance = db.Banks.Where(x => x.BankTitle == "Halkbank").Select(y => y.BankBalance).FirstOrDefault();
            lblZiraat.Text = zirratBankBalance.ToString();
            lblVakif.Text = vakiBankBalance.ToString();
            lblHalk.Text = halkBankBalance.ToString();

            //Banka Haraketleri
            var bankaProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblProcess1.Text = bankaProcess1.Description + " " + bankaProcess1.Amount + " " + bankaProcess1.ProcessDate;

            var bankaProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblProcess2.Text = bankaProcess2.Description + " " + bankaProcess2.Amount + " " + bankaProcess2.ProcessDate;

            var bankaProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblProcess3.Text = bankaProcess3.Description + " " + bankaProcess3.Amount + " " + bankaProcess3.ProcessDate;

            var bankaProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblProcess4.Text = bankaProcess4.Description + " " + bankaProcess4.Amount + " " + bankaProcess4.ProcessDate;


            var bankaProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblProcess5.Text = bankaProcess5.Description + " " + bankaProcess5.Amount + " " + bankaProcess5.ProcessDate;
        }
    }
}
