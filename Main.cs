using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class BaseForm : Form
    {
        public GameState Game = new GameState("", DateTime.Now, [], 0, 0, 0);
        AddForm addForm = new AddForm();
        public BaseForm()
        {
            InitializeComponent();
        }

        public void InitializeDataGridView()
        {
            Game.Combatants = Game.Combatants.OrderByDescending(combatant => combatant.Initiative).ToList();

            dataGridViewRounds.DataSource = Game.Combatants;

            dataGridViewRounds.Columns[0].Width = (int)(dataGridViewRounds.Width * 0.1);
            dataGridViewRounds.Columns[0].HeaderText = "Concentration";
            dataGridViewRounds.Columns[1].Width = (int)(dataGridViewRounds.Width * 0.1);
            dataGridViewRounds.Columns[1].HeaderText = "Initiative";
            dataGridViewRounds.Columns[2].Width = (int)(dataGridViewRounds.Width * 0.1);
            dataGridViewRounds.Columns[2].HeaderText = "Name";
            dataGridViewRounds.Columns[3].Width = (int)(dataGridViewRounds.Width * 0.1);
            dataGridViewRounds.Columns[3].HeaderText = "Max HP";
            dataGridViewRounds.Columns[4].Width = (int)(dataGridViewRounds.Width * 0.1);
            dataGridViewRounds.Columns[4].HeaderText = "Current HP";
            dataGridViewRounds.Columns[5].HeaderText = "Active Conditions";
            dataGridViewRounds.Columns[5].Width = (int)(dataGridViewRounds.Width * 0.3);
            dataGridViewRounds.Columns[6].Visible = false;
        }

        private void dataGridViewRounds_SelectionChanged(object? sender, EventArgs e)
        {
            Game.SelectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
        }

        private void AddNewRoundColumn()
        {
            Game.RoundNumber++;
            txtRoundNum.Text = Game.RoundNumber.ToString();
        }

        private void HighlightCurrentTurn()
        {
            if (Game.CurrentPlayerIndex == 0)
            {
                if (Game.Combatants[Game.Combatants.Count - 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[Game.Combatants.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[Game.Combatants.Count - 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }

            }
            else if (Game.CurrentPlayerIndex >= 1 && Game.CurrentPlayerIndex < Game.Combatants.Count)
            {
                if (Game.Combatants[Game.CurrentPlayerIndex - 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[Game.CurrentPlayerIndex - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[Game.CurrentPlayerIndex - 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
            }
            else if (Game.CurrentPlayerIndex == Game.Combatants.Count) { }

            dataGridViewRounds.Rows[Game.CurrentPlayerIndex].DefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void SelectNextTurn()
        {
            Game.CurrentPlayerIndex++;
            if (Game.CurrentPlayerIndex >= dataGridViewRounds.Rows.Count)
            {
                AddNewRoundColumn();
                Game.CurrentPlayerIndex = 0;
            }
            HighlightCurrentTurn();


        }

        private void SelectPreviousTurn()
        {
            if (Game.CurrentPlayerIndex == 0)
            {
                Game.CurrentPlayerIndex = Game.Combatants.Count - 1;
                if (Game.Combatants[0].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[0].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[0].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
                Game.RoundNumber--;
                txtRoundNum.Text = Game.RoundNumber.ToString();
            }

            else if (Game.CurrentPlayerIndex >= 1 && Game.CurrentPlayerIndex < Game.Combatants.Count)
            {
                Game.CurrentPlayerIndex--;
                if (Game.Combatants[Game.CurrentPlayerIndex + 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[Game.CurrentPlayerIndex + 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[Game.CurrentPlayerIndex + 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
            }
            else if (Game.CurrentPlayerIndex == Game.Combatants.Count) { }

            dataGridViewRounds.Rows[Game.CurrentPlayerIndex].DefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void ConcentrationClicked(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewRounds.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void myDataGrid_OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnDamageHeal_Click(object sender, EventArgs e)
        {
            if (Game.Combatants == null)
            {
                MessageBox.Show("Please select a combatant to damage or heal"); return;
            }
            Game.SelectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
            DamageHeal damageHeal = new DamageHeal(Game.Combatants[Game.SelectedCombatant]);
            damageHeal.ShowDialog();
            if (damageHeal.isHeal)
            {
                Game.Combatants[Game.SelectedCombatant].CurrentHP = Game.Combatants[Game.SelectedCombatant].CurrentHP + damageHeal.healing;
                if (Game.Combatants[Game.SelectedCombatant].CurrentHP > Game.Combatants[Game.SelectedCombatant].MaxHP)
                {
                    Game.Combatants[Game.SelectedCombatant].CurrentHP = Game.Combatants[Game.SelectedCombatant].MaxHP;
                }
            }
            else
            {
                Game.Combatants[Game.SelectedCombatant].CurrentHP = Game.Combatants[Game.SelectedCombatant].CurrentHP - damageHeal.damage;
                if (Game.Combatants[Game.SelectedCombatant].IsConcentrating)
                {
                    ConCheck conCheck = new ConCheck(Game.Combatants[Game.SelectedCombatant], damageHeal.damage);
                    conCheck.ShowDialog();
                    if (!conCheck.Passed)
                    {
                        Game.Combatants[Game.SelectedCombatant].IsConcentrating = false;
                    }
                }
                if (Game.Combatants[Game.SelectedCombatant].CurrentHP <= 0)
                {
                    MessageBox.Show($"{Game.Combatants[Game.SelectedCombatant].Name} is dead/unconscious");
                    Game.Combatants[Game.SelectedCombatant].CurrentHP = 0;
                    dataGridViewRounds.Rows[Game.SelectedCombatant].DefaultCellStyle.BackColor = Color.OrangeRed;
                }

            }
            dataGridViewRounds.Refresh();

        }

        //Resize on load based on client viewport
        private void BaseForm_Load(object sender, EventArgs e)
        {
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(Convert.ToInt32(0.5 * workingRectangle.Width), Convert.ToInt32(0.5 * workingRectangle.Height));
            this.Location = new Point(Convert.ToInt32(workingRectangle.Width / 4), Convert.ToInt32(workingRectangle.Height / 4));

            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        public void RefreshForm(List<Combatant> newCombatants)
        {
            foreach (Combatant newCombatant in newCombatants)
            {
                Game.Combatants.Add(newCombatant);
            }
            InitializeDataGridView();
        }

        private void Resize(object sender, EventArgs e)
        {
            // Set the PictureBox position to keep it centered
            pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Game.Combatants = addForm.newCombatants;
            InitializeDataGridView();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SelectNextTurn();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Game.Combatants == null)
            {
                MessageBox.Show("At least one combatant is required for combat");
                return;
            }
            else if (Game.Combatants.Count == 0)
            {
                MessageBox.Show("At least one combatant is required for combat");
                return;
            }

            HighlightCurrentTurn();
            AddNewRoundColumn();
            btnStart.Visible = false;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SelectPreviousTurn();
        }

        private void dataGridViewRounds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Game.SelectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (Game.Combatants == null)
            {
                MessageBox.Show("Please select a combatant to modify active conditions"); return;
            }
            Game.SelectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
            Combatant c = Game.Combatants[Game.SelectedCombatant];
            Effects manageStatusConditions = new Effects(c);
            manageStatusConditions.ShowDialog();

            c.CurrentConditions = manageStatusConditions.SelectedCondition;
            c.GetConditionsString();
            dataGridViewRounds.Refresh();

        }

        private void btnAddOrDelete_Click(object sender, EventArgs e)
        {
            addForm.LoadCombatants(Game.Combatants);
            addForm.ShowDialog();
        }



        private void btnDemo_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.AddDemoData();
            Game.Combatants = addForm.newCombatants;
            InitializeDataGridView();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSaveLoad_Click(object sender, EventArgs e)
        {
            Save save = new Save(Game);
            save.ShowDialog();
            Game = save.CurrentGame;
            InitializeDataGridView();
            txtRoundNum.Text = Game.RoundNumber.ToString();
            HighlightCurrentTurn();
            AddNewRoundColumn();
            btnStart.Visible = false;
        }
    }
}
