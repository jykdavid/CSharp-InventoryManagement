namespace InventoryManagementSystem
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void LoginShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (LoginShowPW.Checked)
            {
                PWTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PWTextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginClear_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = String.Empty;
            PWTextBox.Text = String.Empty;
        }
    }
}