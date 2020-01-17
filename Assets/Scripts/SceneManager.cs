using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public CanvasGroup canvas;

    private void Start()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        for(float f = 0.05f; f <= 1.05f; f += 0.05f)
        {
            canvas.alpha = f;
            yield return new WaitForSeconds(0.025f);
        }
        yield return new WaitForSeconds(2.5f);
        for (float f = 1f; f >= 0f; f -= 0.05f)
        {
            canvas.alpha = f;
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}


