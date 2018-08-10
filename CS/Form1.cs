using Syncfusion.WinForms.Core.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusyIndicatorHelperSample
{
    public partial class Form1 : Form
    {
        BusyIndicator busyIndicator = new BusyIndicator();
        ObservableCollection<int> sampleData = new ObservableCollection<int>();
        public Form1()
        {
            InitializeComponent();           
        }
        private void sfButton1_Click(object sender, EventArgs e)
        {
            this.sfButton1.Text = string.Empty;
            busyIndicator.Show(this.sfButton1);

            //You can uncomment the below line if you want to show at any location.
            //this.sfButton1.Text = "Loading";
            //busyIndicator.Show(this.sfButton1, new Point((this.sfButton1.Width / 2) + this.busyIndicator.Image.Width, (this.sfButton1.Height / 2) - this.busyIndicator.Image.Height / 2));

            for (int i = 0; i <= 10000000; i++)
            {
                sampleData.Add(i);
            }
            busyIndicator.Hide();
            this.sfButton1.Text = "Get items";
            sampleData.Clear();
        }
    }   
}
