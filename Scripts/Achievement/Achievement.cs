using UnityEngine;
using System;

[Serializable]
public class Achievement
{
    [Header("Basic Settings")]
    public string id;
    public string title;
    public string description;
    public int points;
    public bool hidden;
    public int targetProgress;

    [Header("Visual")]
    public Sprite lockedIcon;
    public Sprite unlockedIcon;

    [Header("Current Status")]
    public int currentProgress;
    public bool unlocked;

    public void AddProgress(int progress)
    {
        if (!unlocked)
        { 
            currentProgress += progress;
            if (currentProgress >= targetProgress)
            {
                currentProgress = targetProgress;
                unlocked = true;
                AchievementUnlockedEvent.Trigger(this);
            }
        }
    }

}
