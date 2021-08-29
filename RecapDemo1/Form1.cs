using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] button = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= button.GetUpperBound(0); i++) //0.boyutun en büyük alabileceği dğer
            {
                for (int j = 0; j <= button.GetUpperBound(1); j++) //1.boyutun en büyük alabileceği dğer
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Left = left; //soldan uzaklığı
                    button[i, j].Top = top;//yukardan uzaklığı
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        button[i, j].BackColor = Color.Black;
                    }
                    else
                        button[i, j].BackColor = Color.Brown;
                    this.Controls.Add(button[i, j]);
                }
                left = 0;
                top += 50;
            }
        }
    }
}
