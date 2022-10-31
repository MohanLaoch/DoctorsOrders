using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentPill = 1;
    public int correctPills = 0;

    [Header("Pill Order")]
    public string[] pillsNeeded;

    public List<string> pillsChosen = new List<string>();

    public void CheckPill()
    {
        switch (currentPill)
        {
            case 1:
                if (pillsNeeded[0] == pillsChosen[0])
                    correctPills++;
                break;
            case 2:
                if (pillsNeeded[1] == pillsChosen[1])
                    correctPills++;
                break;
            case 3:
                if (pillsNeeded[2] == pillsChosen[2])
                    correctPills++;
                break;
            case 4:
                if (pillsNeeded[3] == pillsChosen[3])
                    correctPills++;
                break;
            case 5:
                if (pillsNeeded[4] == pillsChosen[4])
                    correctPills++;
                break;
            case 6:
                if (pillsNeeded[5] == pillsChosen[5])
                    correctPills++;
                break;
            case 7:
                if (pillsNeeded[6] == pillsChosen[6])
                    correctPills++;
                break;
            case 8:
                if (pillsNeeded[7] == pillsChosen[7])
                    correctPills++;
                break;
            case 9:
                if (pillsNeeded[8] == pillsChosen[8])
                    correctPills++;
                break;
            case 10:
                if (pillsNeeded[9] == pillsChosen[9])
                    correctPills++;
                break;
        }
    }
}
