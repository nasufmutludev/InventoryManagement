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

        InventoryManager inventoryManager=new InventoryManager(new EfInventoryDal());

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void LoadInventory()
        {
            dataGridView1.DataSource = inventoryManager.GetList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var inventoryAdd = new Inventory()
            {
                InventoryName = txtEnvanterAdi.Text
            };
            inventoryManager.Add(inventoryAdd);
            LoadInventory();
        }
    }
}