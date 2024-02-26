using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Perk", menuName = "Add perk")]
public class Perk : ScriptableObject
{
    public string Name;
    public string Description;
    public Stat[] stats;
}
