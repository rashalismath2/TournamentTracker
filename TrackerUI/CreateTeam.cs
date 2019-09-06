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
                    chosenMembers.Add(model);
                    teamMemberListBox.DataSource = null;
                    teamMemberListBox.DataSource = chosenMembers;
                    teamMemberListBox.DisplayMember = "FullName";
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
                addListsToTheFormElements();
            }
           
        }

        /// <summary>
        /// Assigning Declared lists to the elements in the form
        /// </summary>
        private void addListsToTheFormElements()
        {
            selectTeamMemberCombo.DataSource = null;
            teamMemberListBox.DataSource = null;

            selectTeamMemberCombo.DataSource = availableMembers;
            selectTeamMemberCombo.DisplayMember = "FullName";

            teamMemberListBox.DataSource = chosenMembers;
            teamMemberListBox.DisplayMember = "FullName";
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
            foreach (Control item in addNewMemberGroupBox.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "") {
                        outputString = $"Fields Cant Be Empty";
                        return false;
                    }
                }
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            ChooseMember();
        }

        /// <summary>
        /// Adding Member to chosen list box and removing selected item from combo box
        /// </summary>
        public void ChooseMember() {

            PersonModel person=(PersonModel)selectTeamMemberCombo.SelectedItem;

            if (person!=null) {
                availableMembers.Remove(person);
                chosenMembers.Add(person);
            }
            addListsToTheFormElements();
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedMember();
        }

        /// <summary>
        /// Removing selected team member from selected list box
        /// </summary>
        private void RemoveSelectedMember()
        {
            PersonModel person = (PersonModel)teamMemberListBox.SelectedItem;

            if (person != null)
            {
                availableMembers.Add(person);
                chosenMembers.Remove(person);
            }
            addListsToTheFormElements();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (validateCreateTeam())
            {
                TeamModel model = GlobalConfig.Connection.CreateTeam(new TeamModel { TeamName = teamnameText.Text, TeamMembers = chosenMembers });
                if (model != null)
                {
                    MessageBox.Show("Team Created", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearCreateTeamFields();
                }
            }
            else {
                MessageBox.Show($"{outputString}", "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearCreateTeamFields();
            }
        }

        private bool validateCreateTeam()
        {
            //TODO  validate fields before submit create team
            return true;
        }

        /// <summary>
        /// Clear out the team name text field and set the selctTeamCombo box values.
        /// </summary>
        private void clearCreateTeamFields() {
            teamnameText.Text = "";
            chosenMembers = null;
            getAllPeopleData();
        }
    }
}
