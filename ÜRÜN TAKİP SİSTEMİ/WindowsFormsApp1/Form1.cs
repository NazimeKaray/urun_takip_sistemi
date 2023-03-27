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
            static void Main(string[] args)
            {
                char a = 'A';
                string b = "a";
                Console.WriteLine(Convert.ToInt32(a));
                Console.WriteLine(Convert.ToInt32(Convert.Tochar(b)));
                Console.ReadLine();
            }
        }
    }
}
