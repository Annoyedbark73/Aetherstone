using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAnswer : MonoBehaviour
{

    public Text Alphabet;

    public void firstgame(string alphabet)
    {
        Alphabet.text += alphabet;
        string firstGameResult = alphabet;

        if (firstGameResult == "A")
        {
            Debug.Log("correct");

        }
    }
}
