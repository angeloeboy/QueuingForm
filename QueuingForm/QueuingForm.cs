﻿using System;
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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {   

            //lblQueue text will be equal to what the method returns
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");

            //get the value of lblQueue and adds it to queue
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindowForm = new CashierWindowQueueForm();
            cashierWindowForm.Show();

        }
    }
}
