using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.VisualBasic;

namespace Desktop
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private InventoryManager _inventoryManager = new InventoryManager(new EfInventoryDal());
        private CompanyManager _companyManager = new CompanyManager(new EfCompanyDal());
        private UserManager _userManager = new UserManager(new EfUserDal());

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
            CompanyLoad();
            CmbCompanyLoad();
            SaleLoad();
            UserLoad();
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 100000);
            var tarih = DateTime.Now.Date.Day.ToString();
            var tarih2 = DateTime.Now.Year.ToString();
            var tarih3 = DateTime.Now.Second.ToString();
            txtInventoryName.Text = "0000" + tarih + tarih2 + tarih3 + sayi;
        }

        private void UserLoad()
        {
            dgwUserList.DataSource = _userManager.GetList();
        }

        private void SaleLoad()
        {
            dgwSaleList.DataSource = _inventoryManager.GetList();
        }

        private void CmbCompanyLoad()
        {
            cbCompany.ValueMember = "Id";
            cbCompany.DisplayMember = "CompanyName";
            cbCompany.DataSource = _companyManager.GetList();
        }

        private void CompanyLoad()
        {
            dgwCompanyList.DataSource = _companyManager.GetList();
        }

        private void LoadInventory()
        {
            dgwInventoryList.DataSource = _inventoryManager.GetList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string inventoryName = txtInventoryName.Text;
            int companyId = Convert.ToInt32(cbCompany.SelectedValue);
            int quantity = Convert.ToInt32(txtQantity.Text);
            DateTime dateOfEntry = Convert.ToDateTime(dtEntry.Value.ToShortDateString());
            DateTime release = Convert.ToDateTime(dtRelease.Value.ToShortDateString());
            _inventoryManager.Add(inventoryName, companyId, dateOfEntry, release, quantity);
            LoadInventory();
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            _companyManager.Add(companyName);
            CompanyLoad();
        }

        private void dgwSaleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtInventorySaleText.Text = dgwSaleList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            int inventoryId = Convert.ToInt32(dgwSaleList.CurrentRow.Cells[0].Value.ToString());
            string inventoryNo = dgwSaleList.CurrentRow.Cells[1].Value.ToString();
            int quantity = Convert.ToInt32(txtQuantitySaleText.Text);
            int companyId = Convert.ToInt32(dgwSaleList.CurrentRow.Cells[3].Value.ToString());
            DateTime tarih = Convert.ToDateTime(dgwSaleList.CurrentRow.Cells[4].Value.ToString());
            DateTime tarih2 = Convert.ToDateTime(dgwSaleList.CurrentRow.Cells[5].Value.ToString());
            int quantityCheck = Convert.ToInt32(dgwSaleList.CurrentRow.Cells[2].Value.ToString());
            if (quantityCheck == 0)
            {
                MessageBox.Show("Quantity= " + quantityCheck);
            }
            else
            {
                _inventoryManager.Sale(inventoryId, quantity, inventoryNo, companyId, tarih, tarih2);
                SaleLoad();
            }
        }

        private void userAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            _userManager.Add(username, name, surname, departmentId);
            UserLoad();
        }
    }
}