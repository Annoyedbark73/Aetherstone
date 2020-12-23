using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharLimit : MonoBehaviour
{
    float Min = 1;
    float Max = 20;
    float NumberToClamp;
    void Update()
    {
        NumberToClamp = Mathf.Clamp(NumberToClamp, Min, Max);
    }
}
