using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weekDayManager : MonoBehaviour
{
    public void Start()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in daysOfWeek)
        {
            PrintActivityUsingSwitch(day);
        }
    }

    public void PrintActivityUsingSwitch(string day)
    {
        switch (day)
        {
            case "Monday":
                Debug.Log("Monday: Work in P1 group.");
                break;
            case "Tuesday":
                Debug.Log("Tuesday: IKDU class, then go to work.");
                break;
            case "Wednesday":
                Debug.Log("Wednesday: PBL class.");
                break;
            case "Thursday":
                Debug.Log("Thursday: IKDU class, then pubcrawl.");
                break;
            case "Friday":
                Debug.Log("Friday: Skip school because you are tired from thursday.");
                break;
            case "Saturday":
                Debug.Log("Saturday: Sleep in, then do some work on P1 project.");
                break;
            case "Sunday":
                Debug.Log("Sunday: Dinner with family.");
                break;
            default:
                Debug.Log("Invalid day.");
                break;
        }
    }
}
