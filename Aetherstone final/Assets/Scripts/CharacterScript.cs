using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterScript : MonoBehaviour
{
    public Animator Anim;
    public TMPro.TextMeshProUGUI characterText; // The text object where we display our characters name
    public TMPro.TMP_InputField characterInput; // The input object where we type our characters name
    private string characterName = ""; // Private reference to our character class
    private const string CHARACTER_NAME_KEY = "CHARACTER_NAME_KEY"; // Set a CONST value to avoid spelling errors in save file
    public  GameObject GameObject;
    private void Start()
    {
        DontDestroyOnLoad(GameObject);
        InputGet(); // Display the character name.
    }

    /*
     * Here we get the player name, and return it, from any location
     * it exists. If it doesn't exist anywhere, we will still return
     * blank, but leave a debug for us to know why blank was returned.
     */
   public string GetCharacterName()
    {

        if (characterName != "")
        { // If we don't need to load, don't
            return characterName; // return the character name
        }
        else if (PlayerPrefs.HasKey(CHARACTER_NAME_KEY))
        { // If the playerName has been saved before and exists
            characterName = PlayerPrefs.GetString(CHARACTER_NAME_KEY); // Set the characterName based on the name in our save file.
            return characterName; // return the character name
        }
        else
        {
            Anim.SetTrigger("NoName");
            Debug.Log("Player name has not been set yet!");
            return "Enter Name"; // return placeholder, but submit a warning so we know why a name wasn't returned.
        }
    }

    /*
     * Set the character name, based on the string provided.
     */
    private void SetCharacterName(string name)
    {

        characterName = name;

    }

    /*
     * Save the character name in our save file. This is separate from save, because we might not ALWAYS want to save the name to a save file, but we would still like to set it at runtime.
     */
    private void SaveCharacterName(string name)
    {

        PlayerPrefs.SetString(CHARACTER_NAME_KEY, name); // Save the characters name, using the key 'characterName' and setting the value to the provided string value of name.

    }

    /*
     * Deletes the characters name.
     */
    public void DeleteCharacterName()
    {
        if (PlayerPrefs.HasKey(CHARACTER_NAME_KEY))
        {
            PlayerPrefs.DeleteKey(CHARACTER_NAME_KEY);
        }
        else
        {
            Debug.Log("No save file to delete!");//whopsie 
        }
    }

    /*
     * This function will actually start the process off. It allows us to keep the rest of the code private, and our variables secure.
     */
    public void InputSet()
    {
        string name = characterInput.text;
        SetCharacterName(name);
        SaveCharacterName(name);
        Debug.Log("registered");
        
    }

    /*
     * This function actually allows us to grab the information.
     */
    public void InputGet()
    {
        characterText.text = GetCharacterName();
        Debug.Log("saved");
    }

}
