using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterName : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public string nickName;

    public TextMeshPro nickNameText;
    private CharacterNameGenerator nameGenerator;

    public string GetFullCharacterName()
    {
        // lets return the combination of their whole name and nick name i.e. Dwayne Johnson the Rock!
        return firstName + " " + lastName + " the " + nickName;
    }

    private void Start()
    {
        FaceNameToCamera();
    }

    /// <summary>
    /// Sets up our character name, no modifications required
    /// </summary>
    public void TestImplementation()
    {
        nameGenerator = FindObjectOfType<CharacterNameGenerator>();
        if (nameGenerator == null)
        {
            return;
        }
        // we probably want to grab a random first, last and nick name from the character name generator.
        nameGenerator.SetIndividualCharacter(this);
        FaceNameToCamera();
    }

    /// <summary>
    /// Is called inside of our DanceTeam.cs is used to set the characters name!
    /// </summary>
    /// <param name="characterName"></param>
    public void FaceNameToCamera()
    {
        if (nickNameText != null)
        {
            // set the text to be our nickname
            nickNameText.text = nickName;
            // nickText.text = charName.nickname;
            nickNameText.transform.LookAt(Camera.main.transform.position);
            //text faces the wrong way so
            nickNameText.transform.Rotate(0, 180, 0);
        }
    }
}
