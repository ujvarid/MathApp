using EquationSolverApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class NumericalApproximationMenu : Form
    {
        public NumericalApproximationMenu()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void EBtn_Click(object sender, EventArgs e)
        {
            var frm = new NumAppE();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += (s, args) =>
            {
                this.Location = frm.Location;
                FadeIn(this);
                this.Show();
            };
            FadeIn(frm);
            FadeOut(this);
        }

        private void PiBtn_Click(object sender, EventArgs e)
        {
            var frm = new NumAppPi();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += (s, args) =>
            {
                this.Location = frm.Location;
                FadeIn(this);
                this.Show();
            };
            FadeIn(frm);
            FadeOut(this);
        }

        private void FadeIn(Form form, int duration = 300) // arra a helyre kene visszamennie ahol az elozot kinyomtak
        {
            form.Opacity = 0;
            form.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            double step = 0.05;
            timer.Tick += (sender, e) =>
            {
                form.Opacity += step;
                if (form.Opacity >= 1)
                {
                    form.Opacity = 1;
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private void FadeOut(Form form, int duration = 300)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            double step = 0.05;
            timer.Tick += (sender, e) =>
            {
                form.Opacity -= step;
                if (form.Opacity <= 0)
                {
                    form.Opacity = 0;
                    form.Hide();
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }
    }
}
