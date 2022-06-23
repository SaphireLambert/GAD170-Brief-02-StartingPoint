using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the ordering of initialisation and kick off of the first round of the dance battle. Avoids the 
/// need for special cases in other classes to get the game running.
/// 
/// NOTE: Provided with framework, no modification required
/// TODO: Nothing
/// </summary>
public class BattleStarter : MonoBehaviour
{
    public float initialWaitTime;
    public DanceTeamInit danceTeamInit;
    public BattleSystem fightManager;

    void Awake()
    {
        StartCoroutine(FirstRound());
    }

    IEnumerator FirstRound()  
    {
        yield return null; //wait a frame
        danceTeamInit.InitTeams();

        // waits a number of seconds before calling the first round.
        yield return new WaitForSeconds(initialWaitTime);
        fightManager.RequestRound();        
    }
}
