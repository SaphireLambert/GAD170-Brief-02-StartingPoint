using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Functions to complete:
/// - Spawn Team
/// - Add New Dancer
/// - Remove Dancer From Active
/// </summary>
public class DanceTeam : MonoBehaviour
{
    public Color teamColor = Color.white; // Our team colours, we can change these in the inspectors.
    public string danceTeamName; // this is set from our SetTroupeName Function.

    public GameObject fightWinContainer; // This is just a point light in our scene that gets turned on and off if we win just to make it look fancy.
    public Text troupeNameText; // this is just a text element in the scene that set by the troupe name function.

    public List<Character> allDancers = new List<Character>(); // A list of all the dancers on our team.
    public List<Character> activeDancers = new List<Character>(); // A list of our currently active dancers, when they die they need to be removed from this list. 
    public List<Transform> characterSpawnPoints = new List<Transform>(); // these will be the spawn points for the characters

    public CharacterNameGenerator nameGenerator;

    /// <summary>
    /// Takes in a dancer prefab and loops over all the spawn points in the game and spawns a dancer for us.
    /// </summary>
    /// <param name="dancerPrefab"></param>
    public void SpawnTeam(GameObject dancerPrefab)
    {
        List<CharacterName> allCharacterNames = new List<CharacterName>(); // a list to hold all our character name references.

        // so here we want to be able to loop over all of our character spawn points.
      
            // for each spawn point, we want to use our Instantiate(Gameobject, Vector3, Quaternion); and pass in our dancer prefab, as well as the position and rotation of the spawn point
            // Once that does occur, we should store what was spawned into a gameobject for use later on.
            GameObject clone = null;

            // After our dancer clone is spawned, we should use a getcomponent on the dancer and store a reference to the charactername class.
            CharacterName clonedCharacterName = null;
            // with that referecne let's add it to our list of all character names.
            allCharacterNames.Add(clonedCharacterName);
            
            // here let's grab a reference to the character class that is on the cloned dancer, we probably want to use get component to grab it and store it. 
            Character cloneCharacter = null;

            if (clone != null)
            {
                // Here we are using this, this is essentially referening myself; so the clone character gets a reference of this class.
                cloneCharacter.myTeam = this;
                // finally let's call the AddNewDancer function and pass in our reference to our cloneCharcter

            }

        // we get to here our team is spawned in, yay but now.... we want to call the SetTeamCharacterNames function from our NameGenerator assuming we already have a reference to it
        // and pass in our list of all character names
    }

    /// <summary>
    /// takes in a new dancer and adds it to our active and all dancers lists
    /// </summary>
    private void AddNewDancer(Character dancer)
    {
        // here we want to add the dancer coming in, into our active and all dancers lists.

    }

    /// <summary>
    /// Removes a dancer to our dance team.
    /// </summary>
    /// <param name="dancer"></param>
    public void RemoveDancerFromActive(Character dancer)
    {
        // so here we have a dancer coming in, we should probably remove them from our active dancers list.
    }

    #region No mods Required
    /// <summary>
    /// Sets the team's troupe name to something we pass in.
    /// </summary>
    /// <param name="name"></param>
    public void SetTroupeName(string name)
    {
        danceTeamName = name;
        if (troupeNameText != null)
        {
            troupeNameText.text = name;
        }
    }


    /// <summary>
    /// Enables the win effects for the winning dancer/team
    /// </summary>
    public void EnableWinEffects()
    {
        if (fightWinContainer != null)
        {
            fightWinContainer.SetActive(true);
            var l = fightWinContainer.GetComponentInChildren<Light>();
            if (l != null)
            {
                l.color = teamColor;
            }
        }
    }

    /// <summary>
    /// Disables the win effects for the winner/dancing team.
    /// </summary>
    public void DisableWinEffects()
    {
        if (fightWinContainer != null)
        {
            fightWinContainer.SetActive(false);
        }
    }
    #endregion
}
