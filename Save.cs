using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker;

public partial class Save : Form
{
    public GameState CurrentGame { get; set; }
    public List<GameState> Saves { get; set; } = new List<GameState>();
    public Save(GameState currentGame)
    {
        CurrentGame = currentGame;
        InitializeComponent();
        PopulateSaves();
    }

    private void PopulateSaves()
    {
        try
        {
            string saveFolderPath = "./Saves";
            
            if (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
            }

            string[] saveFiles = Directory.GetFiles(saveFolderPath, "*.json");
            
            lbSaves.Items.Clear();

            foreach (string file in saveFiles)
            {
                try
                {
                    string jsonString = File.ReadAllText(file);
                    GameState game = JsonSerializer.Deserialize<GameState>(jsonString);
                    Saves.Add(game);
                    lbSaves.Items.Add($"{game.SaveName} - {game.LastSave.ToString("dd/MM/yy HH:mm:ss")}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load save file: {file}\n{ex.Message}");
                }
            }
        }
        catch (Exception)
        {

            throw;
        }
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
        if (lbSaves.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a save to load");
            return;
        }

        try
        {
            CurrentGame = Saves[lbSaves.SelectedIndex];
            Close();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if(CurrentGame.SaveName == "")
            {
                SaveNameInput input = new SaveNameInput(this);
                input.ShowDialog();
                if (CurrentGame.SaveName == "")
                {
                    return;
                }
            }
            CurrentGame.LastSave = DateTime.Now;
            string path = $"Saves/{CurrentGame.LastSave.ToString("dd-MM-yyyy-HH-mm")}_{CurrentGame.SaveName}.json";
            string jsonSave = JsonSerializer.Serialize(CurrentGame);
            File.WriteAllText(path, jsonSave);
            MessageBox.Show("Game saved successfully");
            PopulateSaves();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred.{ex.Message}");
            return;
        }

    }
    public void Cancel()
    {
        return;
    }
}
