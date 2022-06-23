using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// -Do Round
/// </summary>
public class BattleSystem : MonoBehaviour
{
    public DanceTeam teamA,teamB; //References to TeamA and TeamB
    public FightManager fightManager; // References to our FightManager.

    public float battlePrepTime = 2;  // the amount of time we need to wait before a battle starts
    public float fightCompletedWaitTime = 2; // the amount of time we need to wait till a fight/round is completed.
    
    /// <summary>
    /// This occurs every round or every X number of seconds, is the core battle logic/game loop.
    /// </summary>
    /// <returns></returns>
    IEnumerator DoRound()
    {     
        // waits for a float number of seconds....
        yield return new WaitForSeconds(battlePrepTime);

        //checking for no dancers on either team
        if(teamA.allDancers.Count == 0 && teamB.allDancers.Count == 0)
        {
            Debug.Log("DoRound called, but there are no dancers on either team.");
            // This will be called if there are 0 dancers on both teams.

        }
        else if (teamA.activeDancers.Count > 0 && teamB.activeDancers.Count > 0)
        {
            //You need to select two random or engineered random characters to fight...so one from team a and one from team b....
            // we could also get fancy here by using the simulate battle first if we wanted to to find characters for a closer chance of winning, but to start with let's just keep it simple and randomly select one.

            Character teamAcharacter = null; // instead of null (nothing) we probably want a random charcter from each team.
            Character teamBCharacter = null;
            fightManager.Fight(teamAcharacter, teamBCharacter);
        }
        else
        {
            // IF we get to here...then we have a team that has won...winner winner chicken dinner.
            DanceTeam winner = null; // null is the same as saying nothing...often seen as a null reference in your logs.

            // We need to determine a winner...but how? what is our win condition for a team winning? and set our winner to be that team

            // here we are just checking we've decided which team has won, before we show the message and show some winning effects
            if (winner != null)
            {
                //Enables the win effects, and logs it out to the console.
                winner.EnableWinEffects();
                BattleLog.Log("The winner is: "+ winner.danceTeamName.ToString(), winner.teamColor);
                Debug.Log("DoRound called, but we have a winner so Game Over");
            }
          
        }
    }

    #region No Modifications Required
    // This is where we can handle what happens when we win or lose.
    public void FightOver()
    {
        StartCoroutine(HandleFightOver());
    }

    /// <summary>
    /// Used to Request A round.
    /// </summary>
    public void RequestRound()
    {
        //calling the coroutine so we can put waits in for anims to play
        StartCoroutine(DoRound());
    }

    /// <summary>
    /// Handles the end of a fight and waits to start the next round.
    /// </summary>
    /// <returns></returns>
    IEnumerator HandleFightOver()
    {
        yield return new WaitForSeconds(fightCompletedWaitTime);
        teamA.DisableWinEffects();
        teamB.DisableWinEffects();
        Debug.LogWarning("HandleFightOver called, may need to prepare or clean dancers or teams and checks before doing GameEvents.RequestFighters()");
        RequestRound();
    }
    #endregion
}
