using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum PerkType
{
    Speed,
    MaxHealth
}

public class PerkSystem : MonoBehaviour
{
    public List<Perk> currentPerks = new List<Perk>();

    private void Start()
    {
        foreach(Perk perk in currentPerks)
        {
            foreach(Stat stat in perk.stats)
            {
                switch(stat.type)
                {
                    case PerkType.Speed:
                        Player.speed += stat.value;
                        break;
                    case PerkType.MaxHealth:
                        Player.maxHealth += stat.value;
                        break;
                }
            }
        }
        Debug.Log($"{Player.speed} speed");
        Debug.Log($"{Player.maxHealth} maxHealth");
    }
}
