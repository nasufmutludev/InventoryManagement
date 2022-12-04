using Business.Concrete;
using DataAccess.Concrete;
using Entities;

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
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 100000);
            var tarih = DateTime.Now.Date.Day.ToString();
            var tarih2 = DateTime.Now.Year.ToString();
            var tarih3 = DateTime.Now.Second.ToString();
            txtInventoryName.Text = "0000" + tarih + tarih2 + tarih3 + sayi;
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
                InventoryName = txtInventoryName.Text,
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
    }
}