using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login_and_Registration
{
    public partial class SplashScreen : Form
    {
        // Creating round corners on the form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );


        public SplashScreen()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            circularProgressBar1.Value = 0;
        } 
        
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }


            
        }

       
    }
}
