using System;
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
    public partial class CustomerView : Form
    {

        public CustomerView()
        {
            InitializeComponent();
        }

        public void UpdateService(String serving)
        {
            lblQueue.Text = serving;

        }
    }
}
