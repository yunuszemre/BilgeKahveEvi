using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeKahveEvi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Object> Orders = new List<Object>();
        List<decimal> prices = new List<decimal>();
        List<Customer> Customers = new List<Customer>();
        decimal totalPrice;
        //List<BaseProduct> products = new List<BaseProduct>();
        private void Form1_Load(object sender, EventArgs e)
        {
            FillCoffeeBox();
            FillColdDrinks();
        }
        void FillCoffeeBox()
        {
            cmbCoffees.Items.Clear();
            cmbCoffees.Items.Add("Misto");
            cmbCoffees.Items.Add("Americano");
            cmbCoffees.Items.Add("Bianco");
            cmbCoffees.Items.Add("Cappucino");
            cmbCoffees.Items.Add("Macchiato");
            cmbCoffees.Items.Add("Con Panna");
            cmbCoffees.Items.Add("Mocha");

        }
        void FillColdDrinks()
        {
            cmbColdDrinks.Items.Clear();
            cmbColdDrinks.Items.Add("San Pellegrino Limonlu Gazlı İçecek");
            cmbColdDrinks.Items.Add("Feel More Üzüm Suyu");
            cmbColdDrinks.Items.Add("San Pellegrino Doğal Mineralli Su");
            cmbColdDrinks.Items.Add("San Pellegrino Portakallı Gazlı İçecek");
        }
        void GetOrder()
        {
            CoffeOrder();
            GetCustomer();
            ColdDrinkOffer();
            foreach (BaseProduct item in Orders)
            {
                lstOrder.Items.Clear();
                totalPrice += item.Price;
                lstOrder.Items.Add(item);
                
            }

        }

        #region Coffee
        private void CoffeOrder()
        {
            Coffee coffee = new Coffee();
            coffee.Name = cmbCoffees.Text;
            coffee.Count = (int)coffeesNumUp.Value;
            coffee.Category = "Coffee";
            CoffeMilk(coffee);
            CoffeShot(coffee);
            CoffeSize(coffee);
            coffee.CalculatePrice();
            
            Orders.Add(coffee);
        }

        private void CoffeSize(Coffee coffee)
        {
            if (radioVenti.Checked)
            {
                coffee.Size = 1.75;
            }
            else if (radioGrande.Checked)
            {
                coffee.Size = 1.25;
            }
            else
            {
                coffee.Size = 1;
            }
        }

        private void CoffeShot(Coffee coffee)
        {
            if (radio1x.Checked)
            {
                coffee.Shot = "1x";
            }
            else
            {
                coffee.Shot = "2x";
            }
        }


        private void CoffeMilk(Coffee coffee)
        {
            if (radioButter.Checked)
            {
                coffee.Süt = "Yağsız";
            }
            else
            {
                coffee.Süt = "Soya";
            }
        }

        //private static void CoffePrice(Coffee coffee)
        //{
        //    switch (coffee.Name)
        //    {
        //        case "Misto":
        //            coffee.UnitPrice = 4.5m;
        //            break;
        //        case "Americano":
        //            coffee.UnitPrice = 5.75m;
        //            break;
        //        case "Bianco":
        //            coffee.UnitPrice = 6m;
        //            break;
        //        case "Cappucino":
        //            coffee.UnitPrice = 7.5m;
        //            break;
        //        case "Macchiato":
        //            coffee.UnitPrice = 6.75m;
        //            break;
        //        case "Con Panna":
        //            coffee.UnitPrice = 8m;
        //            break;
        //        case "Mocha":
        //            coffee.UnitPrice = 7.75m;
        //            break;
        //        default:
        //            break;
        //    }
        //    coffee.Price = (coffee.Count * coffee.UnitPrice) * (decimal)coffee.Size;
        //} 
        #endregion

        void ColdDrinkOffer()
        {
            ColdDrink coldDrink = new ColdDrink();
            coldDrink.Name = cmbColdDrinks.Text;
            coldDrink.Count = (int)coldDrinksUp.Value;
            coldDrink.Category = "Soğuk İçecek";
            coldDrink.UnitPrice = 5.5m;
            coldDrink.CalculatePrice();
            Orders.Add(coldDrink);
        }

        void GetCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerName = txtFullName.Text;
            customer.Phone = txtPhone.Text;
            customer.Adress = txtAdress.Text;
            Customers.Add(customer);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GetOrder();
        }
        
    }
}
