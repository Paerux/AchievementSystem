using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void OnGameEvent(string eventType)
    {
        if(eventType == "test1")
        {
            print("test1");
            AchievementManager.Instance.UnlockAchievement("test1");
        }

        if(eventType == "test2")
        {
            print("test2");
            AchievementManager.Instance.UnlockAchievement("test2");
        }

        if(eventType == "test3")
        {
            print("test3");
            AchievementManager.Instance.UnlockAchievement("test3");
        }
    }

    private void OnEnable()
    {
        GameEvent.Register(OnGameEvent);
    }

    private void OnDisable()
    {
        GameEvent.Unregister(OnGameEvent);
    }
}
