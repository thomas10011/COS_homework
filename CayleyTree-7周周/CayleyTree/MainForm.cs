using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void GraphicsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;




        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = GraphicsPanel.CreateGraphics();
            DrawCayleyTree(10, 250, 500, 100, -Math.PI / 2);

        }

        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }


        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pens.Brown, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void LeftPeerTrackBar_Scroll(object sender, EventArgs e)
        {
            per1 = LeftPeerTrackBar.Value / 100.0;
            label1.Text = Convert.ToString(LeftPeerTrackBar.Value / 100.0);
            
        }

        private void RightPeerTrackBar_Scroll(object sender, EventArgs e)
        {
            per2 = RightPeerTrackBar.Value / 100.0;
            label2.Text = Convert.ToString(RightPeerTrackBar.Value / 100.0);
        }

        private void LeftThTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                th1 = LeftThTrackBar.Value * Math.PI / 180;
                label3.Text = Convert.ToString(LeftThTrackBar.Value) + "°";
            }
            catch(Exception ep)
            {
                Console.WriteLine(ep.Message);
            }
        }

        private void RightThTrackBar_Scroll(object sender, EventArgs e)
        {
            th2 = RightThTrackBar.Value * Math.PI / 180;
            label4.Text = Convert.ToString(RightThTrackBar.Value) + "°";
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
        }
    }
}
