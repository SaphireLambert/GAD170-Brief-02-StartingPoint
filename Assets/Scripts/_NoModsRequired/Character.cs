using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Initial Stats
/// - Return Battle Points
/// - Deal Damage
/// </summary>
public class Character : MonoBehaviour
{
    public CharacterName charName;
    public LevelingSystem myLevelSystem;
    public StatsSystem myStatsSystem;
    public PowerLevel myPowerSystem;
    [HideInInspector] public DanceTeam myTeam; // This holds a reference to the characters current dance team instance they are assigned to.

    [HideInInspector] public bool isSelected; // This is used for determining if this character is selected in a battle.
    [HideInInspector] public AnimationController animController; // A reference to the animationController, is used to switch dancing states.

    // This is called once, this then calls Initial Stats function
    void Start()
    {
        animController = GetComponent<AnimationController>();
        myLevelSystem.SetDefaultValues();
        myStatsSystem.SetDefaultValues();
    } 

    public void RemoveFromTeam()
    {
        if (myTeam)
        {
            myTeam.RemoveDancerFromActive(this);
        }
    }

}
