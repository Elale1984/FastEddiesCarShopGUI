using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastEddiesCarShopGUI;

namespace FastEddiesCarShopGUI
{
    public partial class FastEddiesGUI : Form
    {
        Store store = new Store();

        BindingSource CarListBinding = new BindingSource();
        BindingSource ShopingCartBinding = new BindingSource();

        public FastEddiesGUI()
        {
            InitializeComponent();

            WelcomeToFastEddies loadScreen = new WelcomeToFastEddies();
            loadScreen.ShowDialog();

          
           
            SetBinding();

        }

        private void SetBinding()
        {
            CarListBinding.DataSource = store.CarList;
            lb_CarList.DataSource = CarListBinding;
            lb_CarList.DisplayMember = "Display";

            ShopingCartBinding.DataSource = store.ShoppingCartList;
            lb_ShoppingCart.DataSource = ShopingCartBinding;
            lb_ShoppingCart.DisplayMember = "Display";
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car userCar = new Car();
                userCar.Make = tb_Make.Text;
                userCar.Model = tb_Model.Text;
                userCar.Color = tb_Color.Text;
                userCar.Miles = int.Parse(tb_Miles.Text);
                userCar.Price = Decimal.Parse(tb_Price.Text);

                store.CarList.Add(userCar);
                CarListBinding.ResetBindings(false);

                tb_Make.Clear();
                tb_Model.Clear();
                tb_Color.Clear();
                tb_Miles.Clear();
                tb_Price.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Oops, you missed something or put incompatable data \nin one or more of your feeds. \n\nTry again");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            store.ShoppingCartList.Add((Car)lb_CarList.SelectedItem);
            ShopingCartBinding.ResetBindings(false);
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            lbl_TotalCost.Text = store.Checkout().ToString("C", CultureInfo.GetCultureInfo("en-US"));
            store.ShoppingCartList.Clear();
            ShopingCartBinding.ResetBindings(false);

        }
    }
}
