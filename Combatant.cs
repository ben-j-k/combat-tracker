using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatTracker;

public class Combatant
{
    public bool IsConcentrating { get; set; }
    public int Initiative { get; set; }
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int CurrentHP { get; set; }
    public string ActiveConditions { get; set; }
    public StatusEffect CurrentConditions { get; set; }
    


    public Combatant(string name, int maxHP, int hitPoints, int initiative)
    {
        Name = name;
        MaxHP = maxHP;
        CurrentHP = hitPoints;
        Initiative = initiative;

        IsConcentrating = false;
        CurrentConditions = new StatusEffect();
        GetConditionsString();
    }
    public Combatant()
    {
        CurrentConditions = new StatusEffect();
    }
    public void GetConditionsString()
    {
        List<string> activeConditions = new List<string>();

        if (CurrentConditions.Blinded) activeConditions.Add("Blinded");
        if (CurrentConditions.Charmed) activeConditions.Add("Charmed");
        if (CurrentConditions.Deafened) activeConditions.Add("Deafened");
        if (CurrentConditions.Frightened) activeConditions.Add("Frightened");
        if (CurrentConditions.Grappled) activeConditions.Add("Grappled");
        if (CurrentConditions.Incapacitated) activeConditions.Add("Incapacitated");
        if (CurrentConditions.Invisible) activeConditions.Add("Invisible");
        if (CurrentConditions.Paralyzed) activeConditions.Add("Paralyzed");
        if (CurrentConditions.Petrified) activeConditions.Add("Petrified");
        if (CurrentConditions.Poisoned) activeConditions.Add("Poisoned");
        if (CurrentConditions.Prone) activeConditions.Add("Prone");
        if (CurrentConditions.Restrained) activeConditions.Add("Restrained");
        if (CurrentConditions.Stunned) activeConditions.Add("Stunned");
        if (CurrentConditions.Unconscious) activeConditions.Add("Unconscious");
        if (CurrentConditions.Exhaustion) activeConditions.Add("Exhaustion");

        ActiveConditions = string.Join(", ", activeConditions);
    }
}
