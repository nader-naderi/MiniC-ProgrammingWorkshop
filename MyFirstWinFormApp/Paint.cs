using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
    public partial class Paint : Form
    {
        private Graphics graphics;
        private bool isPainting = false;
        private int startingX;
        private int startingY;
        private bool isDrawingSqure = false;
        private bool isDrawingRect = false;
        private bool isDrawingCircle = false;

        public Paint()
        {
            InitializeComponent();

            graphics = CreateGraphics();

        }

        private void Paint_Load(object sender, EventArgs e)
        {
            // 212314534256432525134532

            // 212314534256432525134532

            // 212314534256432525134532
        }
    }
}
