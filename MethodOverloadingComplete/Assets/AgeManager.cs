using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AgeManager : MonoBehaviour
{
    public void IncreaseAge(int currentAge)
    {
        currentAge += 1;
        Debug.Log("Age after 1 year: " + currentAge);
    }

    public void IncreaseAge(int increaseAge, int currentAge)
    {
        currentAge += increaseAge;

        Debug.Log("Age after " + increaseAge + "years: " + currentAge);
    }


    void Start()
    {
        int currentAge = 1;
        IncreaseAge(currentAge);

        int increaseAge = 5;
        IncreaseAge(increaseAge, currentAge);

        int anotherIncreaseAge = 10;
        IncreaseAge(anotherIncreaseAge, currentAge);



    }
}
