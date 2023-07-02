using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AchievementList", menuName = "PaeruxSystems/Achievement/Achievement List")]
public class AchievementSO : ScriptableObject
{
    public List<Achievement> achievements;
}
