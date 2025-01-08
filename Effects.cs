using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class Effects : Form
    {
        public StatusEffect SelectedCondition { get; set; }

        public Effects(Combatant c)
        {
            InitializeComponent();
            SelectedCondition = c.CurrentConditions;
            txtName.Text = c.Name;
            InitialiseLists();

        }

        private void InitialiseLists()
        {

            foreach (var prop in SelectedCondition.GetType().GetProperties())
            {
                if (Convert.ToBoolean(prop.GetValue(SelectedCondition)) == false)
                {
                    lbFalseConditions.Items.Add(prop.Name);
                }
                else if (Convert.ToBoolean(prop.GetValue(SelectedCondition)) == true)
                {
                    lbTrueConditions.Items.Add(prop.Name);
                }
            }
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            string selection = lbFalseConditions.SelectedItem.ToString();
            switch (selection)
            {
                case "Blinded": SelectedCondition.Blinded = true; break;
                case "Charmed": SelectedCondition.Charmed = true; break;
                case "Deafened": SelectedCondition.Deafened = true; break;
                case "Frightened": SelectedCondition.Frightened = true; break;
                case "Grappled": SelectedCondition.Grappled = true; break;
                case "Incapacitated": SelectedCondition.Incapacitated = true; break;
                case "Invisible": SelectedCondition.Invisible = true; break;
                case "Paralyzed": SelectedCondition.Paralyzed = true; break;
                case "Petrified": SelectedCondition.Petrified = true; break;
                case "Poisoned": SelectedCondition.Poisoned = true; break;
                case "Prone": SelectedCondition.Prone = true; break;
                case "Restrained": SelectedCondition.Restrained = true; break;
                case "Stunned": SelectedCondition.Stunned = true; break;
                case "Unconscious": SelectedCondition.Unconscious = true; break;
                case "Exhaustion": SelectedCondition.Exhaustion = true; break;
            }
            Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selection = lbTrueConditions.SelectedItem.ToString();
            switch (selection)
            {
                case "Blinded": SelectedCondition.Blinded = false; break;
                case "Charmed": SelectedCondition.Charmed = false; break;
                case "Deafened": SelectedCondition.Deafened = false; break;
                case "Frightened": SelectedCondition.Frightened = false; break;
                case "Grappled": SelectedCondition.Grappled = false; break;
                case "Incapacitated": SelectedCondition.Incapacitated = false; break;
                case "Invisible": SelectedCondition.Invisible = false; break;
                case "Paralyzed": SelectedCondition.Paralyzed = false; break;
                case "Petrified": SelectedCondition.Petrified = false; break;
                case "Poisoned": SelectedCondition.Poisoned = false; break;
                case "Prone": SelectedCondition.Prone = false; break;
                case "Restrained": SelectedCondition.Restrained = false; break;
                case "Stunned": SelectedCondition.Stunned = false; break;
                case "Unconscious": SelectedCondition.Unconscious = false; break;
                case "Exhaustion": SelectedCondition.Exhaustion = false; break;
            }
            Close();

        }

        private void lbTrueConditions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
