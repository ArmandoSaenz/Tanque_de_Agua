using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Oxyplot Libraries
using OxyPlot;
using OxyPlot.Series;

namespace Tanque_de_Agua
{
    public partial class Form1 : Form
    {
        //Local variables
        double A, r, h0, f1, f2;

        public Form1()
        {
            InitializeComponent();
        }

        private double h(double t)
        {
            return (1 / A) * (f1 - f2) * t + h0;
        }
        private void btnGraficar_Click(object sender, EventArgs e)
        {
            r = double.Parse(this.tbRadio.Text);
            f1 = double.Parse(this.tbF1.Text);
            f2 = double.Parse(this.tbF2.Text);
            h0 = double.Parse(this.tbH0.Text);
            A = Math.PI * Math.Pow(r, 2);
            PlotModel Modelo = new PlotModel();
            Modelo.Series.Add(new FunctionSeries(this.h, 0, 600, 0.1));
            plotView1.Model = Modelo;
        }
    }
}
