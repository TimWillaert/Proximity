using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInCamera : MonoBehaviour
{

    public CanvasGroup canvas;

    private void Start()
    {
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f > 0f; f -= 0.05f)
        {
            canvas.alpha = f;
            yield return new WaitForSeconds(0.035f);
        }
    }

}
