using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class AddForm : Form
    {
        public List<Combatant> newCombatants = new List<Combatant>();
        public AddForm()
        {
            InitializeComponent();
        }
        private BaseForm baseForm = null;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadCombatants(List<Combatant> existingCombatants)
        {
            newCombatants = existingCombatants;
            lbCombatants.Items.Clear();
            foreach (Combatant combatant in newCombatants)
            {
                lbCombatants.Items.Add(Convert.ToString(combatant.Name));
            }
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            string name = txtNameInput.Text;
            decimal decMaxHP = numMaxHP.Value;
            decimal decCurrentHP = numCurrentHP.Value;
            int currentHP = 0;
            int maxHP = 0;
            decimal decInit = numInitInput.Value;
            int init = 0;
            if (name == "")
            {
                MessageBox.Show("Combatant must have a name");
                return;
            }
            else if (decMaxHP <= 0)
            {
                MessageBox.Show("Combatant's maximum hitpoints must be greater than 0");
                return;
            }
            maxHP = Convert.ToInt32(decMaxHP);
            if (numCurrentHP.Value == 0)
            {
                currentHP = maxHP;
            }
            else { currentHP = Convert.ToInt32(decCurrentHP); }
            init = Convert.ToInt32(decInit);

            Combatant combatant = new Combatant(name, maxHP, currentHP, init);
            txtNameInput.Text = "";
            numMaxHP.Value = 0;
            numCurrentHP.Value = 0;
            numInitInput.Value = 0;

            lblAddConfirm.Text = $"Combatant {combatant.Name} added";
            lbCombatants.Items.Add(Convert.ToString(combatant.Name));
            newCombatants.Add(combatant);



        }
        public void AddDemoData()
        {
            newCombatants.Add(new Combatant("Kyron", 47, 42, 3));
            newCombatants.Add(new Combatant("Xander", 26, 26, 17));
            newCombatants.Add(new Combatant("Atlas", 38, 31, 12));
            newCombatants.Add(new Combatant("Bandit 1", 14, 14, 2));
            newCombatants.Add(new Combatant("Bandit 2", 14, 14, 17));
            newCombatants.Add(new Combatant("Bandit Captain", 53, 53, 14));
        }

        private void btnAddBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedCombName = Convert.ToString(lbCombatants.SelectedItem);
            for (int i = 0; i < newCombatants.Count; i++)
            {
                if (newCombatants[i].Name == selectedCombName)
                {
                    newCombatants.Remove(newCombatants[i]);
                    lbCombatants.Items.Remove(selectedCombName);
                }
            }
        }

        private void txtHPInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
