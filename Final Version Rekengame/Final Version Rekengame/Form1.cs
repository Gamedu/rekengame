using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Version_Rekengame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateGrid(10, 10, 150, 150, 2, 2);
        }

        private void GenerateGrid(int x, int y, int height, int width, int horizontal, int vertical)
        {
            for (int i = 0; i < vertical; i++)
            {
                GenerateRowOfButtons(i * (x + width), y, height, width, horizontal);
            }
        }

        private void GenerateRowOfButtons(int x, int y, int height, int width, int horizontal)
        {
            for (int i = 0; i < horizontal; i++)
            {
                GenerateButton(x, i * (y + width), height, width);
            }
        }

        private void GenerateButton(int x, int y, int height, int width)
        {
            Button button = new Button();
            Controls.Add(button);
            button.Top = x;
            button.Left = y;
            button.Height = height;
            button.Width = width;

        }


        private void tmrTypeCheck_Tick(object sender, EventArgs e)
        {
            //Code voor selecteren van type som met Arduino\\
        }
    }
}
