using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    private static AchievementManager instance;
    public static AchievementManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindFirstObjectByType<AchievementManager>();
                if (instance == null)
                {
                    instance = new GameObject("AchievementManager").AddComponent<AchievementManager>();
                }
            }

            return instance;
        }
    }

    public AchievementSO achievementSO;


    public void UnlockAchievement(string id)
    {
        foreach(Achievement achievement in achievementSO.achievements)
        {
            if(achievement.id == id)
            {
                achievement.AddProgress(achievement.targetProgress);
            }
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
