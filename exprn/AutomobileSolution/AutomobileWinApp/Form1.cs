using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public frmCarDetails CarInfo { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ICarRepository CarRepository { get; set; }
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtPrice.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.IbReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.IbManufacturer.Trim();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new frmCarDetails
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if(InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update to car");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
