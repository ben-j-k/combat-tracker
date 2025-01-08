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
public partial class SaveNameInput : Form
{
    public Save SaveForm { get; set; }
    public SaveNameInput(Save saveForm)
    {
        SaveForm = saveForm;
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (txtSaveNameInput.Text.Length < 0 ||
            txtSaveNameInput.Text.Length > 15 ||
            txtSaveNameInput.Text.Any(c => !char.IsLetterOrDigit(c)))
        {
            MessageBox.Show("Save name must be between 1 and 15 characters and can only contain letters or numbers. Please try again.");
            return;
        }

        SaveForm.CurrentGame.SaveName = txtSaveNameInput.Text;
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
}
