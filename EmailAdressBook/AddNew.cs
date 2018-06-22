using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailAdressBook
{
    public partial class AddNew : Form
    {
        //instancevariables
        private PersonRepository _personRepository;
        private PersonList _form;
        private Validate _validate;

        //constructor
        public AddNew(PersonList form)
        {
            InitializeComponent();
            _personRepository = new PersonRepository(); //new PersonRepository object
            _form = form; //assignment
            _validate = new Validate(); //new Validate object
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            string phoneNumber = this.phoneNumberTextBox.Text.Replace("(", string.Empty).Replace(")", string.Empty).Replace("-", string.Empty).Replace(" ", string.Empty);
            try
            {
                if (!_validate.ValidatEmail(this.emailTextBox.Text)) //email not valid
                {
                    MessageBox.Show(_validate.Message);
                }
                else if (!_validate.ValidatePhoneNumber(phoneNumber)) //phone number not valid
                {
                    MessageBox.Show(_validate.Message);
                }
                else if (!_validate.ValidateName(this.nameTextBox.Text)) //name not valid
                {
                    MessageBox.Show(_validate.Message);
                }
               
                //validation is successful
                else
                {
                    //method call to add new record
                    _personRepository.Add(new Person(nameTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text));

                    MessageBox.Show("Successfully added");

                    if (this.closeFormChckBox.Checked) //if the check box is checked
                    {
                        this.Close();//close the form
                    }
                    else //check box is not check
                    {
                        this.nameTextBox.Text = "";
                        this.phoneNumberTextBox.Text = "";
                        this.emailTextBox.Text = "";
                    }
                }
              
            }

            //program encounter error
            catch (Exception ex)
            {
                MessageBox.Show("An error occur while adding the record.\n" +
                    "Error details: "+ex.Message);
            }
        }

        private void closeFormChckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //form closing event
        private void AddNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.RefreshData(); //method callto refresh data
        }
    }
}
