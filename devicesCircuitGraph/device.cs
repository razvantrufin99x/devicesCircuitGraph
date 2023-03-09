using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devicesCircuitGraph
{
    public partial class device : UserControl
    {
        public device()
        {
            InitializeComponent();
        }
        public void setLabel(string s)
        { 
            this.label1.Text = s;
        }
            
        private void device_Load(object sender, EventArgs e)
        {

        }
    }
}
