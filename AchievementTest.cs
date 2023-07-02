using UnityEngine;

public class AchievementTest : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameEvent.Trigger("test1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameEvent.Trigger("test2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameEvent.Trigger("test3");
        }
    }
}
