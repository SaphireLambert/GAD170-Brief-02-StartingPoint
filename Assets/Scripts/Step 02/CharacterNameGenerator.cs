using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Create Names
/// - Set Individual Name
/// - Set Team Character Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
 
   
    public enum teamOneFname
    {
        John,
        Pickles,
        Nathan
    }
    public enum teamTwoFname
    {
        Josh,
        Gunther,
        Billy
    }
   
    public enum teamOneLname
    {
        Gunderberg,
        Shmickles,
        Drake
    }
    public enum teamTwoLname
    {
        Garner,
        Eisenhower,
        Butcher
    }

 

    public enum teamOneNickname
    {
        Hotshot,
        Bullseye,
        TheCaptain
    }
   public enum teamTwoNickname
    {
        BigBlondie,
        TheLeader,
        Eradicator

    }
    public teamOneFname currentTeamOneFnames;
    public teamOneLname currentTeamOneLnames;
    public teamOneNickname currentTeamOneNicknames;
    public teamTwoFname currentTeamTwoFnames;
    public teamTwoLname currentTeamTwoLnames;
    public teamTwoNickname currentTeamTwoNicknames;

    private void Awake()
    {
        // call the create names function
        CreateNames();
    }

    /// <summary>
    /// Creates a list of names for all our characters to potentiall use.
    /// </summary>
    public void CreateNames()
    {
        // So here we would ideally want to be able to add some names to our first names, last names and nick names lists. (currently at the beggining of the class)
    
  
    }

    /// <summary>
    /// set a characters name to a random value in our Part 02
    /// </summary>
    /// <param name="character"></param>
    public void SetIndividualCharacter(CharacterName character)
    {
        // So here rather than each character being called Blanky Blank Blank, we probably want it to be a random first,last and nickname
        currentTeamOneFnames = (teamOneFname)Random.Range(1, 4);
        currentTeamOneLnames = (teamOneLname)Random.Range(1, 4);
        currentTeamOneNicknames = (teamOneNickname)Random.Range(1, 4);
        currentTeamTwoFnames = (teamTwoFname)Random.Range(1, 4);
        currentTeamTwoLnames = (teamTwoLname)Random.Range(1, 4);
        currentTeamTwoNicknames = (teamTwoNickname)Random.Range(1, 4);


    }

    /// <summary>
    /// sets a character name for each member of a team, this is in our part 03
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public void SetTeamCharacterNames(List<CharacterName> teamCharacters)
    {
        // so here we have a list of character names coming in.
        // we should probably loop over that list of charcter names, and then for each chacter set thei first, last and nickname a random one from our lists
        // if you want to get fancy you could use another function within this script to help out here.
        for (int i = 0; i < teamCharacters.Count; i++)
        {
            //teamCharacters[i].teamOneFname = ((teamOneFname)Random.Range(1, 4)).ToString();  (Keep getting error and dont know how to fix)
            //teamCharacters[i].teamOneLname = ((teamOneLname)Random.Range(1, 4)).ToString();  (Keep getting error and dont know how to fix)
        }

    }
}