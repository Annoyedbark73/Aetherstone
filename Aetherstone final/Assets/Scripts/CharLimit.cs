using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharLimit : MonoBehaviour
{
    float Min = 1;
    float Max = 20;
    float NumberToClamp;
    void Update()
    {
        InputField input;
        NumberToClamp = Mathf.Clamp(NumberToClamp, Min, Max);
        if (NumberToClamp < 20)
        {
            
        }
        
    }
}
