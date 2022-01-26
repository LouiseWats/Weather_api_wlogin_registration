using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Login_and_Registration
{
    public partial class LoginForm : Form
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

        public LoginForm()
        {
            
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;Data source=dbLoginAndRegistration.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private bool mouseDown;
        private Point lastLocation;

        private void loginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string login = "SELECT * FROM Users_tabel WHERE username= '" + usernameTextbox.Text + "' and password= '" + passwordTextbox.Text + "'";
            command = new OleDbCommand(login, connection);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
                new weatherForm().Show();
                this.Hide();
            }
            else
            {
                MessageType.Text = "Invalid password or username";
                MessageType.ForeColor = Color.Red;
                MessageType.Visible = true;
                System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
                {
                    Invoke(new MethodInvoker(() => { MessageType.Visible = false; }));
                });
                
                usernameTextbox.Text = "";
                passwordTextbox.Text = "";
                usernameTextbox.Focus();
            }
        }

        private void showPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckbox.Checked)
            {
                passwordTextbox.PasswordChar = '\0';
            }
            else
            {
                passwordTextbox.PasswordChar = '*';
            }
        }

        private void goToRegisterButton_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
