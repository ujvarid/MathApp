using EquationSolverApp;

namespace MathApp // csak nagy monitoron szep, abszolut modon kell meghatarozni a gombokat, matrixot stb
{ // controlbar off, back buttonnek lenne ertelme
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            this.Text = "MathApp";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void EqSolBtn_Click(object sender, EventArgs e)
        {
            var frm = new EquationSolver();
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

        private void MtClcBtn_Click(object sender, EventArgs e)
        {
            var frm = new MatrixCalculator();
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

        private void NumAppBtn_Click(object sender, EventArgs e)
        {
            var frm = new NumericalApproximationMenu();
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

        private void TwoVarBtn_Click(object sender, EventArgs e)
        {
            var frm = new TwoVarSolver();
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Choose from the menu.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
