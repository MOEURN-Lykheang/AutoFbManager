using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AutoFbManager
{
    public partial class Form1 : Form
    {
        AutoIt clickAuto = new AutoIt();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickAuto.MyClick("LEFT", 1534, 353, 1, -1);
            clickAuto.MyClick("LEFT", 1298, 535, 1, 30);
            clickAuto.MyClick("LEFT", 1180, 657, 1, 30);            
        }
    }
}
