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
    public partial class PersonList : Form
    {
        //instance variables
        private List<Person> _list; // list of persons
        private PersonRepository _personRepository; //instance of PersonRepository
        private PersonInfo _personInfo; //PersonInfo Object
        private static bool _isRefresh = false; //
        private DatabaseInitializer _databaseInitializer;

        //constructor
        public PersonList()
        {
            InitializeComponent(); //initialize component
            _databaseInitializer = new DatabaseInitializer();
            _personRepository = new PersonRepository(); //new instance of PersonRepository
            _list = _personRepository.GetList(); //method call to set the value of _list
          
            if (_list.Count<1) //the numbero f data in  _list is 0
            {
                try
                {
                    _databaseInitializer.Seed(); //method call to seed the database with default values
                    _list = _personRepository.GetList(); //method call to set the value of _list
                }

                //program ecounter error
                catch (Exception ex)
                {
                    MessageBox.Show("An error occur while seeding the database.\n Error details "+ex.Message);
                }
            }

            emailaddressBindingSource.DataSource = _list; //set the datasource of emailaddressBindingSource to _list
           
        }

        public static bool IsRefresh
        {
            set { _isRefresh = value; }
        }
        
        //form load method
        //this method load after the constructor method runs
        private void AddressBook_Load(object sender, EventArgs e)
        {          
            personListBox.SelectedValueChanged += PersonListBox_SelectedValueChanged; //crete selectedValueChanged event
            personListBox.ClearSelected();  //clear the listbox selected item if any
            personListBox.Size = flowLayoutPanel1.Size;
        }

        //user selected item from the listbox
        private void PersonListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isRefresh==true)
            {
               // _isRefresh = false;
                return;
            }
            
            if (personListBox.SelectedIndex != -1)
            {
                var id = personListBox.SelectedValue; //get the valueMember of the item selected
                var person = _list.Where(m => m.Id.Equals((int)id)).SingleOrDefault();//query for the person in _list by the Id
                _personInfo = new PersonInfo(person,this); //new personinfo object
                _personInfo.ShowDialog(); //show personInfo form
            }
           
        }

       
        //method to refresh the datasource of the list box
        public void RefreshData()
        {
            _isRefresh = true; //determine if the refresh button is press
            personListBox.ClearSelected(); //clear the listbox selected item if any
            _list = _personRepository.GetList();//method call to get the list of persons and assign the result to _list
            emailaddressBindingSource.DataSource = _list; ;//set the data source of emailaddressBindingSource to _list
            _isRefresh = false; //set to false
          
        }

        //exit button is press on the menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; //store messabox result

            //display messagebox and store the result of the message box in result
            result = MessageBox.Show(this,"Are you sure you want to exit the application?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) //the user click yes on thhe message box
            {
                this.Close(); //exit the program
            }
            
        }

        //refresh button is press on the menu strip
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            RefreshData();//method call to refresh the data source of the listbox
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew addNew = new AddNew(this);//new AddNew object
            addNew.ShowDialog(); //show addNew as modal dialog
        }

       
        private void AddressBook_Resize(object sender, EventArgs e)
        {
            personListBox.Size = flowLayoutPanel1.Size;
        }
    }
}
