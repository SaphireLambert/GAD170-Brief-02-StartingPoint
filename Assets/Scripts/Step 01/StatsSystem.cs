using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - GeneratePhysicalStatsStats
/// - CalculateDancingStats
/// - ChangeHealth
/// - DistributePhysicalStatsOnLevelUp
/// </summary>
public class StatsSystem : MonoBehaviour
{
    public float playerHealth = 0;

    /// Our physical stats that determine our dancing stats.
    public int agility = 0;
    public int intelligence = 0;
    public int strength = 0;

    // Our variables used to determine our fighting power.
    public int style = 0;
    public int luck = 0;
    public int rhythm = 0;

    private Character character;


    /// <summary>
    /// This function should set our starting stats of Agility, Strength and Intelligence
    /// to some default RANDOM values.
    /// </summary>
    public void GeneratePhysicalStatsStats()
    {
        // Let's set up agility, intelligence and strength to some default Random values.
    }

    /// <summary>
    /// This function should set our style, luck and ryhtmn to values
    /// based on our currrent agility,intelligence and strength.
    /// </summary>
    public void CalculateDancingStats()
    {
        float agilityMultiplier = 0.5f;
        // create a strength multiplier should be set to 1
        float strengthMultiplier = 1f;
        // create an intelligence multiplier should be set to 2.
        float intelligenceMultiplier = 1.5f;

        // Debug out our current multiplier values.
        Debug.Log("agilMulti = " + agilityMultiplier + " strMulti = " + strengthMultiplier + " intelMulti = " + intelligenceMultiplier);

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values, hint your going to need to convert ints to floats, then floats to ints.

        // style should be based off our strength and be converted at a rate of 1 : 1.

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f

        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.

    }

    /// <summary>
    /// We probably want to use this to remove some hp (mojo) from our character.....
    /// Then we probably want to check to see if they are dead or not from that damage and return true or false.
    /// </summary>
    public void ChangeHealth(float amount)
    {
        // We probably want to change our current health based on the amount coming in.

        // currently we are just automatically removing our player...but we probably only want to do that if there is a character and their health is less than 0.
        if(character != null)
        {
            character.RemoveFromTeam();
        }
    }

    /// <summary>
    /// A function used to assign a random amount of points ot each of our skills.
    /// </summary>
    public void DistributePhysicalStatsOnLevelUp(int PointsPool)
    {
        // we've been granted some more points to increase our stats by.
        // let's share these points somewhat evenly or based on some formula to increase our current physical stats
        // then let's recalculate our dancing stats again to process and update the new values.

    }

    #region No Mods Required
    public void SetDefaultValues()
    {
        playerHealth = 1f;
        GeneratePhysicalStatsStats();
        CalculateDancingStats();
        character = GetComponent<Character>();
    }

    public void TestImplementation()
    {
        GeneratePhysicalStatsStats();
        CalculateDancingStats();
        ChangeHealth(-0.6f);
        Debug.Log("Current health is: " + playerHealth);
        DistributePhysicalStatsOnLevelUp(10);
        TestDistributePhysicalStatsOnLevelUp();
    }

    public void TestDistributePhysicalStatsOnLevelUp()
    {
        Debug.Log(string.Format("The new physical stats are str {0}, agil {1}, int {2}, the dancing stats are style {3}, luck {4}, rhythm {4}",strength,agility,intelligence,style,luck,rhythm)); 
    }
    #endregion
}
