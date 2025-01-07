using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class DamageHeal : Form
    {
        public int damage;
        public int healing;
        public bool isHeal;
        public Combatant AffectedCombatant { get; set; }
        public DamageHeal(Combatant affectedCombatant)
        {
            InitializeComponent();
            AffectedCombatant = affectedCombatant;
            txtCombatant.Text = AffectedCombatant.Name;
        }
        private void btnDamage_Click(object sender, EventArgs e)
        {
            damage = 0;
            damage = Convert.ToInt32(numDmgHeal.Value);
            isHeal = false;
            Close();
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            healing = 0;
            healing = Convert.ToInt32(numDmgHeal.Value);
            isHeal = true;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
