using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker;

public partial class Save : Form
{
    public GameState CurrentGame { get; set; }
    public Save(GameState currentGame)
    {
        CurrentGame = currentGame;

        InitializeComponent();
    }

    private void lbSaves_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btnLoad_Click(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {

    }
}
