using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Color_Test
{
    public partial class Form1 : Form
    {
        private Random rngColor = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Color_Generate_Button_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rngColor.Next(256), rngColor.Next(256), rngColor.Next(256));
            changeColor(randomColor);
        }
        void changeColor(Color color)
        {
            this.BackColor = color;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
