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
    public partial class ConCheck : Form
    {
        public Combatant SavingCombatant { get; set; }
        public int Damage { get; set; }
        public int ConSaveDC { get; set; }
        public bool Passed { get; set; }
        public ConCheck(Combatant savingCombatant, int damage)
        {
            InitializeComponent();
            SavingCombatant = savingCombatant;
            Damage = damage;

            ConSaveDC = Damage / 2;
            if (ConSaveDC <= 10) { ConSaveDC = 10; }

            txtName.Text = savingCombatant.Name;
            txtDC.Text = Convert.ToString(ConSaveDC);

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            Passed = true;
            Close();
        }

        private void btnFailed_Click(object sender, EventArgs e)
        {
            Passed = false;
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
