using System.Collections;
using UnityEngine;

public class AchievementUI : MonoBehaviour
{
    public GameObject prefab;
    public float displayDuration = 5f;
    public float fadeDuration = 0.2f;

    private void OnAchievementUnlocked(Achievement achievement)
    {
        StartCoroutine(AchievementCoroutine(achievement));
    }

    private IEnumerator AchievementCoroutine(Achievement achievement)
    {
        AchievementItem item = Instantiate(prefab).GetComponent<AchievementItem>();
        item.transform.SetParent(transform);
        item.title.text = achievement.title;
        item.description.text = achievement.description;
        item.icon.sprite = achievement.unlockedIcon;

        CanvasGroup cg = item.GetComponent<CanvasGroup>();
        cg.alpha = 0f;
        StartCoroutine(FadeCanvasGroup(cg, fadeDuration, 1));
        yield return new WaitForSeconds(displayDuration);
        StartCoroutine(FadeCanvasGroup(cg, fadeDuration, 0));
    }

    private void OnEnable()
    {
        AchievementUnlockedEvent.Register(OnAchievementUnlocked);
    }

    private void OnDisable()
    {
        AchievementUnlockedEvent.Unregister(OnAchievementUnlocked);
    }

    public static IEnumerator FadeCanvasGroup(CanvasGroup target, float duration, float targetAlpha)
    {
        float currentAlpha = target.alpha;
        float t = 0f;
        while (t < 1.0f)
        {
            float a = Mathf.SmoothStep(currentAlpha, targetAlpha, t);
            target.alpha = a;
            t += Time.unscaledDeltaTime / duration;
            yield return null;
        }
        target.alpha = targetAlpha;
    }
}
