using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        public PersonUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Person anPerson = new Person(firstNameTextBox.Text, middlaNameTextBox.Text,lastNameTextBox.Text);
            Person aPerson = new Person(firstNameTextBox.Text, lastNameTextBox.Text);

            fullNameTextBox.Text = anPerson.GetFullName();
            reversNameTextBox.Text = anPerson.GetFullReversName();
        }
    }
}
