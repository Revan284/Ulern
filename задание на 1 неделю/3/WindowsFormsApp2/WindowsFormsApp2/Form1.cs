using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static readonly Color[] colors = new Color[] {
        Color.FromArgb(((byte)(0)), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        Color.FromArgb(((byte)(255)), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        Color.White};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hour = 0;
            try
            {
                hour = int.Parse(hours.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var result = Expr3_Task.GetAngle(hour);
            degrees.Text = result.ToString();
            var clockwise = (hour % 12) > 6;
            var angle = (clockwise) ? 360 - result : result;
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(1, angle);
            chart1.Series[0].Points.AddXY(2, 360 - angle);
            if (clockwise)
            {
                chart1.Series[0].Points[0].Color = colors[2];
                chart1.Series[0].Points[1].Color = colors[0];
            }
            else
            {
                chart1.Series[0].Points[0].Color = colors[0];
                chart1.Series[0].Points[1].Color = colors[2];
            }
        }
    }
}
