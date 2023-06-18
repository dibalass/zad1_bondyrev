using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1_bondyrev
{
    class Shop
    {
        private Dictionary<Product, int> products;
        private string name;
        private decimal profit = 0;
        Product to_sell;

        public Shop(string _name)
        {
            products = new Dictionary<Product, int>();
            name = _name;
        }
        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        public void Sell(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else if (products[product] < count)
                {
                    MessageBox.Show("Такого количества товара нет в наличии");
                }
                else
                {
                    products[product] -= count;
                    profit += to_sell.Price * count;
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        public void Sell(string ProductName, int count)
        {
            to_sell = FindByName(ProductName);
            if (to_sell != null)
            {
                this.Sell(to_sell, count);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public decimal getProfit
        {
            get { return profit; }
            set { value = profit; }
        }
        public string getName
        {
            get { return name; }
            set { value = name; }
        }
        public void showAllProducts(ListBox list)
        {
            list.Items.Clear();
            foreach (var product in products)
            {
                list.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
    }
}
