using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeam : Form
    {
        private List<PersonModel> availableMembers=new List<PersonModel>();
        private List<PersonModel> chosenMembers = new List<PersonModel>();

        /// <summary>
        /// Saves the error messages when validating forms
        /// </summary>
        public string outputString { get; set; }

        public CreateTeam()
        {
            InitializeComponent();

            getAllPeopleData();
          
        }

        //ToDo- Do Add member button, delete member, add team 

        private void CreateTeam_Load(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (!ValidateCreateTeamMembers())
            {
                MessageBox.Show(outputString, "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputString = "";
                clearCreateMemberFields();
            }
            else {
                PersonModel model=GlobalConfig.Connection.CreatePerson(new PersonModel {
                    FirstName = firstNameText.Text,
                    LastName= lastNameText.Text,
                    ContactNumber=contactText.Text,
                    EmailAddress=emailText.Text
                });
                
                if (model == null)
                {
                    MessageBox.Show("Couldnt Create Member", "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearCreateMemberFields();

                }
                else {
                    MessageBox.Show("Member Created", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearCreateMemberFields();
                    getAllPeopleData();
                }
            }

        }

        /// <summary>
        /// gets all people records from the database and set it to availabel members list
        /// </summary>
        private void getAllPeopleData() {
            List<PersonModel> personList=GlobalConfig.Connection.GetAllPeople();
            if (personList.Count<=0) {
                selectTeamMemberCombo.Text ="No data found in database. Add a new member" ;

            } else {
                availableMembers = personList;
                selectTeamMemberCombo.DataSource = availableMembers;
                selectTeamMemberCombo.DisplayMember = "FullName";
            }
           
        }

        /// <summary>
        /// Clearing field inputs in create members
        /// </summary>
        private void clearCreateMemberFields()
        {
            foreach (Control item in addNewMemberGroupBox.Controls)
            {  
                if (item is TextBox) {
                    item.Text = "";
                }
            }
        }

        private bool ValidateCreateTeamMembers() {
            //TODO- Validate fields in Team Members

            return true;
        }

    }
}
