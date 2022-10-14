using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {

        CustomerView customerView = new CustomerView();
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            customerView.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            //clears the view list and readds value by looping through queue provided by the parameter
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //dequeue lols
            CashierClass.CashierQueue.Dequeue();
            customerView.UpdateService(CashierClass.CashierQueue.Peek());
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

            //runs RefreshList method contiuously
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(RefreshList);
            timer.Start();

        }

        private void RefreshList(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
