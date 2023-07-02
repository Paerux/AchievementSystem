public struct GameEvent
{
    public static GameEventDelegate OnGameEvent;
    public static void Register(GameEventDelegate d)
    {
        OnGameEvent += d;
    }
    public static void Unregister(GameEventDelegate d)
    {
        OnGameEvent -= d;
    }
    public delegate void GameEventDelegate(string eventType);
    public static void Trigger(string eventType)
    {
        OnGameEvent?.Invoke(eventType);
    }
}

public struct AchievementUnlockedEvent
{
    public static AchievementUnlockedDelegate OnAchievementUnlocked;
    public static void Register(AchievementUnlockedDelegate d)
    {
        OnAchievementUnlocked += d;
    }
    public static void Unregister(AchievementUnlockedDelegate d)
    {
        OnAchievementUnlocked -= d;
    }
    public delegate void AchievementUnlockedDelegate(Achievement achievement);
    public static void Trigger(Achievement achievement)
    {
        OnAchievementUnlocked?.Invoke(achievement);
    }
}
