using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1._2
{
    public partial class Form1 :Form
    {
        Shop pyaterochka = new Shop();
        Product cola = new Product("Кола", 85);
        Product juice = new Product("Сок \"Добрый\"", 100);
        List<string> products = new List<string>();
        public Form1 ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Кола");
            comboBox1.Items.Add("Сок \"Добрый\"");
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            listBox1.Items.Add(cola.GetInfo());
            listBox1.Items.Add(juice.GetInfo());
            pyaterochka.AddProduct(cola, 9000);
            pyaterochka.AddProduct(juice, 9000);
            pyaterochka.WriteAllProducts(listBox1);
        }

        public bool checkSym (string text)
        {
            foreach (var ch in text)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Введи число");
                    return false;
                }
            }
            if (Convert.ToInt32(text) <= 0)
            {
                MessageBox.Show("Введи положительное число");
                return false;
            }
            return true;
        }
        Product product;
        private void button1_Click (object sender, EventArgs e)
        {
            int amount=0;
            textBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Кола":
                    amount = 9000;
                    break;
                case "Сок \"Добрый\"":
                    amount = 9000;
                    break;
                case "Чипсы":
                    amount = Convert.ToInt32(textBox4.Text);
                    break;
            }
            if (comboBox1.Text!="")
            {
                if (textBox6.Text != "")
                {
                    if (checkSym(textBox6.Text))
                    {
                        bool amountt = pyaterochka.amountReturn();
                        if (amountt)
                        {
                            label2.Text = $"{int.Parse(label2.Text) + (product.Price * int.Parse(textBox6.Text))}";
                            amount -= int.Parse(textBox6.Text);
                        }
                        pyaterochka.Sell(comboBox1.Text, int.Parse(textBox6.Text));
                        pyaterochka.WriteAllProducts(listBox1);
                    }
                } 
                else
                    MessageBox.Show("Введи количество");
            }
            else
                MessageBox.Show("Выбери товар");
            }

        private void button2_Click (object sender, EventArgs e)
        {
            if (checkSym(textBox4.Text)&& checkSym(textBox5.Text))
            {
                product = new Product(textBox3.Text, Convert.ToInt32(textBox5.Text));
                products.Add(textBox3.Text);
                comboBox1.Items.Add(textBox3.Text);
                pyaterochka.AddProduct(product, Convert.ToInt32(textBox4.Text));
                pyaterochka.WriteAllProducts(listBox1);
            }
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void tabPage1_Click (object sender, EventArgs e)
        {

        }
    }
}
