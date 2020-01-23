using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script fades in the main app after the splashscreen
public class FadeInCamera : MonoBehaviour
{

    //Variable instantiation
    public CanvasGroup canvas;

    //Start function, runs before first frame
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
