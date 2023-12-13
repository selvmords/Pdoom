using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFader : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float fadeDuration = 2f;
    public float delayBetweenFades = 1f;

    void Start()
    {
        // Start the fading coroutine
        StartCoroutine(FadeText());
    }

    IEnumerator FadeText()
    {
        while (true)
        {
            // Fade in
            yield return Fade(1f);

            // Delay between fades
            yield return new WaitForSeconds(delayBetweenFades);

            // Fade out
            yield return Fade(0f);

            // Delay between fades
            yield return new WaitForSeconds(delayBetweenFades);
        }
    }

    IEnumerator Fade(float targetAlpha)
    {
        Color originalColor = text.color;
        Color targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, targetAlpha);

        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            text.color = Color.Lerp(originalColor, targetColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        text.color = targetColor;
    }
}