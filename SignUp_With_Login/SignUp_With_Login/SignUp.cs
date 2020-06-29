using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp_With_Login
{
    public partial class SignUp : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["csdb"].ConnectionString;

        public SignUp()
        {
            InitializeComponent();
        }

        private void textBoxId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {

                textBoxId.Focus();
                errorProviderId.SetError(this.textBoxId, "Id must be filled");
            }
            else {

                errorProviderId.Clear();
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {

                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Name must be filled");
            }
            else
            {

                errorProviderName.Clear();
            }
        }

        private void textBoxFatherName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFatherName.Text))
            {

                textBoxFatherName.Focus();
                errorProviderFatherName.SetError(this.textBoxFatherName, "Father name must be filled");
            }
            else
            {

                errorProviderFatherName.Clear();
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSurname.Text))
            {

                textBoxSurname.Focus();
                errorProviderSurname.SetError(this.textBoxSurname, "Surname must be filled");
            }
            else
            {

                errorProviderSurname.Clear();
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedItem == null)
            {

                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Gender must be selected");
            }
            else
            {

                errorProviderGender.Clear();
            }
        }

        private void numericUpDownClass_Leave(object sender, EventArgs e)
        {
            if (numericUpDownClass.Value == 0)
            {

                numericUpDownClass.Focus();
                errorProviderClass.SetError(this.numericUpDownClass, "Class must be selected");
            }
            else
            {

                errorProviderClass.Clear();
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {

                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Email must be filled");
            }
            else
            {

                errorProviderEmail.Clear();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {

                textBoxPassword.Focus();
                errorProviderPassword.SetError(this.textBoxPassword, "Password must be filled");
            }
            else
            {

                errorProviderPassword.Clear();
            }

        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmPassword.Text != textBoxPassword.Text)
            {

                textBoxConfirmPassword.Focus();
                errorProviderConfirmPassword.SetError(this.textBoxConfirmPassword, "Confirm password is not identical");
            }
            else
            {

                errorProviderConfirmPassword.Clear();
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch))
            {

                e.Handled = false;
            }
            else if (ch == 8)
            {

                e.Handled = false;
            }

            else {

                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {

                e.Handled = false;
            }

            else if (ch == 8)
            {

                e.Handled = false;
            }
            else {

                e.Handled = true;
            }
        }

        private void textBoxFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {

                e.Handled = false;
            }

            else if (ch == 8)
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {

                e.Handled = false;
            }
            else if (ch == 32)
            {

                e.Handled = false;
            }

            else if (ch == 8)
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {

                textBoxId.Focus();
                errorProviderId.SetError(this.textBoxId, "Id must be filled");
            }
            else if (string.IsNullOrEmpty(textBoxName.Text))
            {

                textBoxName.Focus();
                errorProviderName.SetError(this.textBoxName, "Name must be filled");
            }
            else if (string.IsNullOrEmpty(textBoxFatherName.Text))
            {

                textBoxFatherName.Focus();
                errorProviderFatherName.SetError(this.textBoxFatherName, "Father name must be filled");
            }
            else if (string.IsNullOrEmpty(textBoxSurname.Text))
            {

                textBoxSurname.Focus();
                errorProviderSurname.SetError(this.textBoxSurname, "Surname must be filled");
            }
            else if (comboBoxGender.SelectedItem == null)
            {

                comboBoxGender.Focus();
                errorProviderGender.SetError(this.comboBoxGender, "Gender must be selected");
            }
            else if (numericUpDownClass.Value == 0)
            {

                numericUpDownClass.Focus();
                errorProviderClass.SetError(this.numericUpDownClass, "Class must be selected");
            }
            else if (string.IsNullOrEmpty(textBoxEmail.Text))
            {

                textBoxEmail.Focus();
                errorProviderEmail.SetError(this.textBoxEmail, "Email must be filled");
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {

                textBoxPassword.Focus();
                errorProviderPassword.SetError(this.textBoxPassword, "Password must be filled");
            }
            else if (textBoxConfirmPassword.Text != textBoxPassword.Text)
            {

                textBoxConfirmPassword.Focus();
                errorProviderConfirmPassword.SetError(this.textBoxConfirmPassword, "Confirm password must be filled");
            }
            else {

                SqlConnection conn = new SqlConnection(cs);
                string queryForId = "select * from Student where Id = @id";
                SqlCommand cmdForId = new SqlCommand(queryForId, conn);
                cmdForId.Parameters.AddWithValue("@id", textBoxId.Text);
                conn.Open();
                SqlDataReader reader = cmdForId.ExecuteReader();
                if (reader.HasRows)
                {

                    MessageBox.Show($"{textBoxId.Text} Id Already Exists.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
                else
                {
                    conn.Close();

                    string query = "insert into Student values(@id, @name, @fName, @surname, @gender, @class, @email, @password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", textBoxId.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@fName", textBoxFatherName.Text);
                    cmd.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.SelectedItem);
                    cmd.Parameters.AddWithValue("@class", numericUpDownClass.Value);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {

                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"Your email is: {textBoxEmail.Text}\n\nYour password is: {textBoxPassword.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login login = new Login();
                        this.Hide();
                        login.Show();

                    }
                    else
                    {

                        MessageBox.Show("Registration Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    conn.Close();
                }

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxFatherName.Clear();
            textBoxSurname.Clear();
            comboBoxGender.SelectedItem = null;
            numericUpDownClass.Value = 0;
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
        }
    }
}
