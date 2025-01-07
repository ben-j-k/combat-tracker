using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class BaseForm : Form
    {
        public List<Combatant> combatants { get; set; }
        private int roundNumber = 0;
        private int currentPlayerIndex = 0;
        private int selectedCombatant = 0;
        AddForm addForm = new AddForm();
        public BaseForm()
        {
            InitializeComponent();
        }

        public void InitializeDataGridView()
        {
            combatants = combatants.OrderByDescending(combatant => combatant.Initiative).ToList();

            dataGridViewRounds.DataSource = combatants;

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
            selectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
        }

        private void AddNewRoundColumn()
        {
            roundNumber++;
            txtRoundNum.Text = roundNumber.ToString();
        }

        private void HighlightCurrentTurn()
        {
            if (currentPlayerIndex == 0)
            {
                if (combatants[combatants.Count - 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[combatants.Count - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[combatants.Count - 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }

            }
            else if (currentPlayerIndex >= 1 && currentPlayerIndex < combatants.Count)
            {
                if (combatants[currentPlayerIndex - 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[currentPlayerIndex - 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[currentPlayerIndex - 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
            }
            else if (currentPlayerIndex == combatants.Count) { }

            dataGridViewRounds.Rows[currentPlayerIndex].DefaultCellStyle.BackColor = Color.DarkOrange;
        }

        private void SelectNextTurn()
        {
            currentPlayerIndex++;
            if (currentPlayerIndex >= dataGridViewRounds.Rows.Count)
            {
                AddNewRoundColumn();
                currentPlayerIndex = 0;
            }
            HighlightCurrentTurn();


        }

        private void SelectPreviousTurn()
        {
            if (currentPlayerIndex == 0)
            {
                currentPlayerIndex = combatants.Count - 1;
                if (combatants[0].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[0].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[0].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
                roundNumber--;
                txtRoundNum.Text = roundNumber.ToString();
            }

            else if (currentPlayerIndex >= 1 && currentPlayerIndex < combatants.Count)
            {
                currentPlayerIndex--;
                if (combatants[currentPlayerIndex + 1].CurrentHP <= 0)
                {
                    dataGridViewRounds.Rows[currentPlayerIndex + 1].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    dataGridViewRounds.Rows[currentPlayerIndex + 1].DefaultCellStyle.BackColor = Color.FloralWhite;
                }
            }
            else if (currentPlayerIndex == combatants.Count) { }

            dataGridViewRounds.Rows[currentPlayerIndex].DefaultCellStyle.BackColor = Color.DarkOrange;
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
            if (combatants == null)
            {
                MessageBox.Show("Please select a combatant to damage or heal"); return;
            }
            selectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
            DamageHeal damageHeal = new DamageHeal(combatants[selectedCombatant]);
            damageHeal.ShowDialog();
            if (damageHeal.isHeal)
            {
                combatants[selectedCombatant].CurrentHP = combatants[selectedCombatant].CurrentHP + damageHeal.healing;
                if (combatants[selectedCombatant].CurrentHP > combatants[selectedCombatant].MaxHP)
                {
                    combatants[selectedCombatant].CurrentHP = combatants[selectedCombatant].MaxHP;
                }
            }
            else
            {
                combatants[selectedCombatant].CurrentHP = combatants[selectedCombatant].CurrentHP - damageHeal.damage;
                if (combatants[selectedCombatant].IsConcentrating)
                {
                    ConCheck conCheck = new ConCheck(combatants[selectedCombatant], damageHeal.damage);
                    conCheck.ShowDialog();
                    if (!conCheck.Passed)
                    {
                        combatants[selectedCombatant].IsConcentrating = false;
                    }
                }
                if (combatants[selectedCombatant].CurrentHP <= 0)
                {
                    MessageBox.Show($"{combatants[selectedCombatant].Name} is dead/unconscious");
                    combatants[selectedCombatant].CurrentHP = 0;
                    dataGridViewRounds.Rows[selectedCombatant].DefaultCellStyle.BackColor = Color.OrangeRed;
                }

            }
            dataGridViewRounds.Refresh();

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        public void RefreshForm(List<Combatant> newCombatants)
        {
            foreach (Combatant newCombatant in newCombatants)
            {
                combatants.Add(newCombatant);
            }
            InitializeDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            combatants = addForm.newCombatants;
            InitializeDataGridView();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SelectNextTurn();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (combatants == null)
            {
                MessageBox.Show("At least one combatant is required for combat");
                return;
            }
            else if (combatants.Count == 0)
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
            selectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (combatants == null)
            {
                MessageBox.Show("Please select a combatant to modify active conditions"); return;
            }
            selectedCombatant = dataGridViewRounds.CurrentCell.RowIndex;
            Combatant c = combatants[selectedCombatant];
            Effects manageStatusConditions = new Effects(c);
            manageStatusConditions.ShowDialog();

            c.CurrentConditions = manageStatusConditions.SelectedCondition;
            c.GetConditionsString();
            dataGridViewRounds.Refresh();

        }

        private void btnAddOrDelete_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
        }



        private void btnDemo_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.AddDemoData();
            combatants = addForm.newCombatants;
            InitializeDataGridView();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
