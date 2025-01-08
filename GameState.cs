using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker;

public class GameState
{
    public string SaveName { get; set; }
    public DateTime LastSave { get; set; }
    public List<Combatant> Combatants { get; set; }
    public int RoundNumber { get; set; }
    public int CurrentPlayerIndex { get; set; }
    public int SelectedCombatant { get; set; }

    public GameState(string saveName, DateTime lastSave, List<Combatant> combatants, int roundNumber, int currentPlayerIndex, int selectedCombatant)
    {
        SaveName = saveName;
        LastSave = lastSave;
        Combatants = combatants;
        RoundNumber = roundNumber;
        CurrentPlayerIndex = currentPlayerIndex;
        SelectedCombatant = selectedCombatant;
    }
}
