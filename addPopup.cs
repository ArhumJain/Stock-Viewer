using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Viewer
{
    public partial class addPopup : Form
    {
        stockViewer mainForm;
        public addPopup()
        {
            InitializeComponent();
        }
        public addPopup(stockViewer mainform)
        {
            InitializeComponent();
            this.mainForm = mainform;

        }

        private void addSubmit_Click(object sender, EventArgs e)
        {
            this.mainForm.addToStockList(addText.Text);
            Console.WriteLine(addText.Text);
            this.Dispose();
            //return addText.Text;
            
        }

        private void addPopup_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
