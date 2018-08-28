using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hellow, Window Form !!");
            Console.WriteLine("今天是 {0}-{1}-{2}", 2018, 8, 27);
            Console.WriteLine("今天是 {1}-{2}-{0}",2018, 8, 27);
            Console.WriteLine("pi = {0}",3.141592);
        }
    }
}
