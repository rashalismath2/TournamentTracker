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
    public partial class CreateTournament : Form,IGetPrize,IGetTeam
    {
        List<TeamModel> teamList = new List<TeamModel>();
        List<TeamModel> SelectedTeamList = new List<TeamModel>();
        List<PrizeModel> SelectedPrizeList = new List<PrizeModel>();

        private string outputString { get; set; }

        public CreateTournament()
        {
            InitializeComponent();

            GetAllTeams();
            SetInitialElementsValues();
        }

        /// <summary>
        /// Getting all the teams from the database and adding to the list
        /// </summary>
        private void GetAllTeams() {
            List<TeamModel> teams = GlobalConfig.Connection.GetAllTeam();
            if (teams == null) {
                MessageBox.Show("Couldnt get data from DB", "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                teamList.Clear();
                teamList = teams;
            }
        }

        /// <summary>
        /// Setting initial values for elements on the form
        /// </summary>
        private void SetInitialElementsValues() {
            selectTeamCombo.DataSource = null;
            selectTeamCombo.DataSource = teamList;
            selectTeamCombo.DisplayMember = "TeamName";

            slectedTeamListBox.DataSource = null;
            slectedTeamListBox.DataSource = SelectedTeamList;
            slectedTeamListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = SelectedPrizeList;
            prizesListBox.DisplayMember = "PrizeName";
        }

        private void CreateTournament_Load(object sender, EventArgs e)
        {

        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrize prizeForm =new  CreatePrize(this);
            prizeForm.Show();
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            //Call the createnewTeam form
            CreateTeam teamForm = new CreateTeam(this);
            //Get back the the team model
            teamForm.Show();

            /**
            CreateTeam form=new CreateTeam();
            form.Show();
           
            GetAllTeams();

            foreach (TeamModel team in SelectedTeamList) {
                teamList.Remove(team);
            }
            selectTeamCombo.DataSource = null;
            selectTeamCombo.DataSource = teamList;
            selectTeamCombo.DisplayMember = "TeamName";
            **/
        }

        private void createNewButton_MouseHover(object sender, EventArgs e)
        {
           createNewButton.ForeColor= Color.FromArgb(25,211,174);
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel selectedTeam = (TeamModel)selectTeamCombo.SelectedItem;

            if (selectedTeam!=null) {
                SelectedTeamList.Add(selectedTeam);
                teamList.Remove(selectedTeam);

                SetInitialElementsValues();
            }
       
        }

        private void deleteTeamPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel selectedTeam = (TeamModel)slectedTeamListBox.SelectedItem;

            if (selectedTeam != null)
            {
                SelectedTeamList.Remove(selectedTeam);
                teamList.Add(selectedTeam);

                SetInitialElementsValues();
            }
        }

        public void RequestedPrize(PrizeModel prizeModel)
        {
            SelectedPrizeList.Add(prizeModel);
            prizesListBox.DataSource = null;
            prizesListBox.DataSource = SelectedPrizeList;
            prizesListBox.DisplayMember = "PlaceName";
        }

        public void GetTeam(TeamModel teamModel)
        {
            SelectedTeamList.Add(teamModel);
            slectedTeamListBox.DataSource = null;
            slectedTeamListBox.DataSource = SelectedTeamList;
            slectedTeamListBox.DisplayMember = "TeamName";
        }

        private void deletePrizesbutton_Click(object sender, EventArgs e)
        {
            PrizeModel selected = (PrizeModel)prizesListBox.SelectedItem;
            if (selected !=null) {
                SelectedPrizeList.Remove(selected);
                prizesListBox.DataSource = null;
                prizesListBox.DataSource = SelectedPrizeList;
                prizesListBox.DisplayMember = "PrizeName";
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //createNewButton tournament model
            if (ValidateTournamentModel())
            {

                TournamentModel tournament=new TournamentModel
                {
                    TournamentName = tournamentNameText.Text,
                    Prizes = SelectedPrizeList,
                    EnteredTeams = SelectedTeamList,
                    EntryFee = decimal.Parse(entryFeeText.Text)
                };

                //TODO- try to clone the tournament list in CreateRoundOne method
                TournamentLogic.CreateRoundOne(tournament);
                TournamentModel model = GlobalConfig.Connection.CreateTrounament(tournament);

                if (model != null)
                {
                    MessageBox.Show("Record created in the database", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Record wasnt created in the database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show(outputString, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }

        public bool ValidateTournamentModel() {
            //TODo- Validate tournament forms inputs
            return true;
        }
    }
}
