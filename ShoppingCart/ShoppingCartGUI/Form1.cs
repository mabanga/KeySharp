using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ShoppingCartGUI
{
    public partial class MainForm : Form
    {
        Store s = new Store();
        Product p = new Product();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            txtMake.Select();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string txt = $"{p.Make} {p.Model} {p.Price}";
            p = new Product();
            p.Make = txtMake.Text;
            p.Model = txtModel.Text;
            p.Price = Convert.ToDecimal(txtPrice.Text);
            MessageBox.Show(p.ToString());
            lstProduct.Items.Add(p);
            Write(@"c:\res\data\car.txt", txt) ;
        }
        public void Write(string path, string txt)
        {
            //List<string> list = new List<string>();
            StreamWriter writer = new StreamWriter(path);
            //writer.NewLine.;
                writer.WriteLine(txt);

            writer.Flush();
            writer.Close();
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            //p = (Product)lstProduct.SelectedItem;
            s.Cart.Add((Product)lstProduct.SelectedItem);
            lstCart.Items.Add((Product)lstProduct.SelectedItem);
        }
        private void btnDeleteCart_Click(object sender, EventArgs e)
        {
            //p = (Product)lstCart.SelectedItem;
            s.Cart.Remove((Product)lstProduct.SelectedItem);
            lstCart.Items.Remove((Product)lstCart.SelectedItem);
        }
        private void btnResetCart_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            lstProduct.Items.Remove(lstProduct.SelectedItem);
        }
        private void btnResetProduct_Click(object sender, EventArgs e)
        {
            lstProduct.Items.Clear();
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;

            decimal total = s.Checkout();
            lblResult.Text = $"{total:c}";
            //s.Cart.RemoveAll(Cart[]);
        }
        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
