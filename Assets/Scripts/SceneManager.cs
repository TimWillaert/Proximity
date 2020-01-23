using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for the splashscreen
public class SceneManager : MonoBehaviour
{

    //Variable instantiation
    public CanvasGroup canvas;

    //Start function, runs before first frame
    private void Start()
    {
        StartCoroutine(Fade());
    }

    //Fades the splashscreen in and o ut
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
        //Switches to the camera scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}


