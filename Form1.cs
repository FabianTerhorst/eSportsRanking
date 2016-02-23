using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSportsRanking
{
    public partial class Form1 : Form
    {
        private List<Team> teams;
        private List<Game> games;

        public Form1()
        {
            InitializeComponent();
            teams = new List<Team>();
            games = new List<Game>();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            teams.Add(new Team(txtbxName.Text));
            refreshTeamList();
        }

        private void refreshTeamList()
        {
            lvLadder.Items.Clear();
            cbxTeam1.Items.Clear();
            cbxTeam2.Items.Clear();
            foreach (Team team in teams)
            {
                lvLadder.Items.Add(team.name);
                cbxTeam1.Items.Add(team.name);
                cbxTeam2.Items.Add(team.name);
            }
        }

        private void refreshRankingList()
        {
            lvLadder.Items.Clear();
            List<Team> sortedList = teams.OrderByDescending(t => t.winRatio).ToList();
            foreach(Team team in sortedList)
            {
                Console.WriteLine(team.winRatio);
                ListViewItem item = lvLadder.Items.Add(team.name);
                item.SubItems.Add(team.winCount.ToString());
                item.SubItems.Add(team.lossCount.ToString());
                item.SubItems.Add(team.gameCount.ToString());
            }
        }

        private void refreshGameList()
        {
            lvGames.Items.Clear();
            foreach (Game game in games)
            {
                ListViewItem item = lvGames.Items.Add(game.winTeam.name);
                item.SubItems.Add(game.lossTeam.name);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            String winTeamName = cbxTeam1.SelectedItem.ToString();
            String lossTeamName = cbxTeam2.SelectedItem.ToString();
            Team winTeam = getTeamByName(winTeamName);
            Team lossTeam = getTeamByName(lossTeamName);
            winTeam.winCount = winTeam.winCount + 1;
            lossTeam.lossCount = lossTeam.lossCount + 1;
            games.Add(new Game(winTeam, lossTeam));
            refreshGameList();
            refreshRankingList();
        }

        private Team getTeamByName(String name)
        {
            foreach(Team team in teams)
            {
                if(team.name == name)
                {
                    return team;
                }
            }
            return null;
        }
    }
}
