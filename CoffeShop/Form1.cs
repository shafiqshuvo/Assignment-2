using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ordercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ordercombo.SelectedItem.ToString() == "Cold coffee")
            {
                paytext.Text = (float.Parse(quantitycombo.Text) * 100).ToString();

                dataGridView1.Rows.Add(customernametext.Text, customernotext.Text, addresstext.Text, ordercombo.Text, quantitycombo.Text, paytext.Text);
            }
            
            else if (ordercombo.SelectedItem.ToString() == "Hot coffee")
            {
                paytext.Text = (float.Parse(quantitycombo.Text) * 90).ToString();

                dataGridView1.Rows.Add(customernametext.Text, customernotext.Text, addresstext.Text, ordercombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (ordercombo.SelectedItem.ToString() == "Black coffee")
            {
                paytext.Text = (float.Parse(quantitycombo.Text) * 120).ToString();

                dataGridView1.Rows.Add(customernametext.Text, customernotext.Text, addresstext.Text, ordercombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (ordercombo.SelectedItem.ToString() == "Regular coffee")
            {
                paytext.Text = (float.Parse(quantitycombo.Text) * 80).ToString();

                dataGridView1.Rows.Add(customernametext.Text, customernotext.Text, addresstext.Text, ordercombo.Text, quantitycombo.Text, paytext.Text);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
