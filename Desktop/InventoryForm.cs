using Business.Concrete;
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

        InventoryManager _inventoryManager = new InventoryManager(new EfInventoryDal());
        private CompanyManager _companyManager = new CompanyManager(new EfCompanyDal());

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
            CompanyLoad();
            CmbCompanyLoad();
            SaleLoad();
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 100000);
            var tarih = DateTime.Now.Date.Day.ToString();
            var tarih2 = DateTime.Now.Year.ToString();
            var tarih3 = DateTime.Now.Second.ToString();
            txtInventoryName.Text = "0000" + tarih + tarih2 + tarih3 + sayi;
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
            var inventoryAdd = new Inventory()
            {
                InventoryName = txtInventoryName.Text.Trim(),
                CompanyId = Convert.ToInt32(cbCompany.SelectedValue),
                DateOfEntry = dtEntry.Value.Date,
                ReleaseDate = dtRelease.Value.Date,
                Quantity = Convert.ToInt32(txtQantity.Text)
            };
            _inventoryManager.Add(inventoryAdd);
            LoadInventory();
        }

        private void btnCompanyAdd_Click(object sender, EventArgs e)
        {
            var companyAdd = new Company()
            {
                CompanyName = txtCompanyName.Text,
                Status = true
            };
            _companyManager.Add(companyAdd);
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
            int adetKontrol = Convert.ToInt32(dgwSaleList.CurrentRow.Cells[2].Value.ToString());
            if (adetKontrol == 0)
            {
                MessageBox.Show("Satýþ yapýlacak adet bulunamadý");
            }
            else
            {
                _inventoryManager.Sale(inventoryId, quantity, inventoryNo, companyId, tarih, tarih2);
                SaleLoad();
            }
        }
    }
}