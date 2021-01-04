using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Stock_Viewer
{
    public partial class stockViewer : Form
    {
        public stockViewer()
        {
            InitializeComponent();
            using (StreamReader file = new StreamReader("./resources/allstocks.txt"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    Stock.stocks.Add(new Stock(line));
                    this.stockList.Items.Add(line);
                }
            }

        }
        public void addToStockList(string stock)
        {
            Console.WriteLine("{0} added to stock list!", stock);
            if (stock != " " || stock != null)
            {
                stockList.Items.Add(stock);
                Stock.stocks.Add(new Stock(stock));
                using (StreamWriter file = new StreamWriter("./resources/allstocks.txt", true))
                {
                    file.WriteLine(stock);
                }
            }
            else
                MessageBox.Show("Blank stock name submitted");
            
        }
        private void stockViewer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stocksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingLabel.Visible = true;
            foreach (Stock i in Stock.stocks)
            {
                if (i.name == (string)stockList.SelectedItem)
                {
                    valueBox.Text = i.getValue();
                    changeValueBox.Text = i.getChange();
                    volumeBox.Text = i.getVolume();
                    nameBox.Text = (string)stockList.SelectedItem;           
                }
            }
            loadingLabel.Visible = false;

            Console.WriteLine(stockList.SelectedItem); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addPopup popup = new addPopup(this);
            popup.Show();

            Console.WriteLine("Add button clicked!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
