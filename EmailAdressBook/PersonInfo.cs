using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmailAdressBook
{
    public partial class PersonInfo : Form
    {
        //instance variable
        private Person _person;
        private PersonRepository _personRepository;
        private PersonList _form;
       
        //constructor
        public PersonInfo(Person person, PersonList form)
        {
            _person = person;
            _form = form;
            _personRepository = new PersonRepository();
            InitializeComponent();
        }

        //form load event
        private void PersonInfo_Load(object sender, EventArgs e)
        {
            //set the text property of the below controls
            this.emailTextBox.Text = _person.Email; 
            this.phoneNumberTextBox.Text = _person.Number;
            this.nameTextBox.Text = _person.Name;
            this.IdLbl.Text = _person.Id.ToString();
            this.idLable.Text = _person.Id.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result; //store messabox result

            //display messagebox and store the result of the message box in result
            result = MessageBox.Show(this, "Are you sure you want to close this? All unsave data will not be save", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) //the user click yes on thhe message box
            {
                this.Close();//close the form
            }
         
        }

        //edit button is press
        private void editBtn_Click(object sender, EventArgs e)
        {
            //set the readOnly property of the below controls to false
            this.nameTextBox.ReadOnly = false;
            this.phoneNumberTextBox.ReadOnly=false;
            this.emailTextBox.ReadOnly=false;
        }
        

        //save button is press
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //try to run the code in the try block
            try
            {
                //method call to edit the person info
                _personRepository.Edit(new Person(this.nameTextBox.Text, this.emailTextBox.Text, this.phoneNumberTextBox.Text, Convert.ToInt16(this.idLable.Text)));
                PersonList.IsRefresh = true; //set to true
                MessageBox.Show("Successfully update"); //show message dialog

                //set the readOnly property of the below controls to true
                this.nameTextBox.ReadOnly = true;
                this.phoneNumberTextBox.ReadOnly = true;
                this.emailTextBox.ReadOnly = true;
            }

            //error occur this far
            catch (Exception ex)
            {
                //show message dialog with error
                MessageBox.Show("An error occur while updating the data. Error deatials: "+ex.Message);
            }
        }


        //delete button is press to delete record from the database
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this,"Are you sure you want to  delete "+nameTextBox.Text+"?","Confirm Deltete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            {
                try
                {
                    _personRepository.Delete(Convert.ToInt32(IdLbl.Text));
                    PersonList.IsRefresh = true; //set to true
                    MessageBox.Show("Successfully deleted");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occur while deleting the record from the database.\n" +
                        "Error deataild:"+ex.Message);
                }
            }
        }

        private void PersonInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.RefreshData(); //method call to refresh the datasource
        }
    }
}
