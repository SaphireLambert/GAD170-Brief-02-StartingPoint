using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - SetDefaultValues
/// - AddXP
/// - LevelUp
/// </summary>
public class LevelingSystem : MonoBehaviour
{
    public StatsSystem myStatSystem; // a reference to our stats system

    public int currentLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    /// <summary>
    /// sets our script to default values
    /// </summary>
    public void SetDefaultValues()
    {
        // set our current level to 1

        // set our current XP to zero

        // set our current XP Threshold to be our level multiplied by our 100.

    }

    /// <summary>
    /// A function called when the battle is completed and some xp is to be awarded.
    /// The amount of xp gained is coming into this function
    /// </summary>
    public void AddXP(int xpGained)
    {
        // We want to be able to add on the xpGained onto our currentXp.

        // We probably want to check to see if we've gained enough xp to trigger a level up to occur.

        // if we do then let's call our level up function.
    }

    /// <summary>
    /// A function used to handle actions associated with levelling up.
    /// </summary>
    private void LevelUp()
    {
        // So let's increase our current level, but let's also recalculate our XP threshold to take into account the new level we've just gained. 
    }

    #region No Mods Required.
    public void TestImplementation()
    {
        SetDefaultValues();
        Debug.Log(string.Format("Current Xp is {0} the current level is {1} and the current threshold is {2}", currentXp, currentLevel, currentXPThreshold));
        AddXP(200);
        Debug.Log(string.Format("Current Xp is {0} the current level is {1} and the current threshold is {2}", currentXp, currentLevel, currentXPThreshold));
        myStatSystem.TestDistributePhysicalStatsOnLevelUp(); // in theory if we've distributed our stats they should be different.
    }
    #endregion
}
