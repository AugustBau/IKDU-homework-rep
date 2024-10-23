using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weekDayManagerIfElse : MonoBehaviour
{
    void Start()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in daysOfWeek)
        {
            PrintActivityUsingIfElse(day);
        }
    }

    void PrintActivityUsingIfElse(string day)
    {
        if (day == "Monday")
        {
            Debug.Log("Monday: Work in P1 group.");
        }
        else if (day == "Tuesday")
        {
            Debug.Log("Tuesday: IKDU class, then go to work.");
        }
        else if (day == "Wednesday")
        {
            Debug.Log("Wednesday: PBL class.");
        }
        else if (day == "Thursday")
        {
            Debug.Log("Thursday: IKDU class, then pubcrawl.");
        }
        else if (day == "Friday")
        {
            Debug.Log("Friday: Skip school because you are tired from thursday.");
        }
        else if (day == "Saturday")
        {
            Debug.Log("Saturday: Sleep in, then do some work on P1 project.");
        }
        else if (day == "Sunday")
        {
            Debug.Log("Sunday: Dinner with family");
        }
        else
        {
            Debug.Log("Invalid day.");
        }
    }
}
