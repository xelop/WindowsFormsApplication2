using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            List<Point[]> coordenates = new List<Point[]>();
            coordenates.Add(new Point[]{new Point(50,50), new Point(75,40), new Point(100,50)});
            coordenates.Add(new Point[]{new Point(50,50), new Point(75,40), new Point(100,50)});
            coordenates.Add(new Point[]{new Point(100, 50), new Point(125, 40), new Point(150, 50) });
            coordenates.Add(new Point[]{ new Point(150, 50), new Point(175, 40), new Point(200, 50) });
            coordenates.Add(new Point[]{ new Point(200, 50), new Point(225, 40), new Point(250, 50) });
            coordenates.Add(new Point[]{ new Point(250, 50), new Point(275, 40), new Point(300, 50) });
            water(coordenates);
        }
        private void water(List<Point[]> coordenates)
        {
            for (int element_counter=0; element_counter < coordenates.Count;element_counter++)
            {
                g.FillClosedCurve(Brushes.Blue,coordenates[element_counter]);
            }

        }

    }
}
