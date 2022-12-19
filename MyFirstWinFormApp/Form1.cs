namespace MyFirstWinFormApp
{
	public partial class Form1 : Form
	{
		// Constructor
		public Form1()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			string firstName = firstNameTxtBox.Text;
			string lastName = lastNameTxtBox.Text;

			MessageBox.Show("Welcome dear " + firstName + " " + lastName);
		}
	}
}