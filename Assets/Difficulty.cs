using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty
{
    static float secondsToMaxDifficulty = 60;

    public static float GetDifficultyPerecent()
    {
        return Mathf.Clamp01(Time.time / secondsToMaxDifficulty);
    }
}
