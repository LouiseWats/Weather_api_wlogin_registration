using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Login_and_Registration
{
    
    public partial class Register : Form
    {
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
        public Register()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDB.4.0;Data source=dbLoginAndRegistration.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();

        private bool mouseDown;
        private Point lastLocation;

        private void RegisterAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameRegTextbox.Text == "" && passwordRegTextbox.Text == "" && confirmRegPassTextbox.Text == "")
            {
                MessageType.Text = "Empty Fields";
                MessageType.ForeColor = Color.Red;
                MessageType.Visible = true;
                System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
                {
                    Invoke(new MethodInvoker(() => { MessageType.Visible = false; }));
                });
            }
            else if (passwordRegTextbox.Text == confirmRegPassTextbox.Text)
            {
                connection.Open();
                string register = "INSERT INTO Users_tabel VALUES ('" + usernameRegTextbox.Text + "','" + passwordRegTextbox.Text + "')";
                command = new OleDbCommand(register, connection);
                command.ExecuteNonQuery();
                connection.Close();

                usernameRegTextbox.Text = "";
                passwordRegTextbox.Text = "";
                confirmRegPassTextbox.Text = "";

                MessageType.Text = "Registraion Success";
                MessageType.ForeColor = Color.Green;
                MessageType.Visible = true;
                System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
                {
                    Invoke(new MethodInvoker(() => { MessageType.Visible = false; }));
                });
            }
            else
            {
                MessageType.Text = "Passwords do not match";
                MessageType.ForeColor = Color.Red;
                MessageType.Visible = true;
                System.Threading.Tasks.Task.Delay(5000).ContinueWith(_ =>
                {
                    Invoke(new MethodInvoker(() => { MessageType.Visible = false; }));
                });
                
                passwordRegTextbox.Text = "";
                confirmRegPassTextbox.Text = "";
                passwordRegTextbox.Focus();

            }
        }

        private void showPassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckbox.Checked)
            {
                passwordRegTextbox.PasswordChar = '\0';
                confirmRegPassTextbox.PasswordChar = '\0';
            }
            else
            {
                passwordRegTextbox.PasswordChar = '*';
                confirmRegPassTextbox.PasswordChar = '*';
            }
        }

        private void GoToLoginButton_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
