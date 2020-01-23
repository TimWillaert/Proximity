using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//This script handles the tutorial
public class TutorialScript : MonoBehaviour, IPointerClickHandler
{

    //Variable instantiation
    public CanvasGroup canvas;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;

    int state;

    //Start function, runs before first frame
    private void Start()
    {
        state = 0;
        if (!PlayerPrefs.HasKey("Tutorial"))
        {
            StartCoroutine(FadeIn());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    //Fades in the tutorial
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(1f);
        for (float f = 0f; f < 0.75f; f += 0.05f)
        {
            canvas.alpha = f;
            yield return new WaitForSeconds(0.035f);
        }
    }

    //Fades out the tutorial
    IEnumerator FadeOut()
    {
        for (float f = 0.7f; f > 0f; f -= 0.07f)
        {
            canvas.alpha = f;
            yield return new WaitForSeconds(0.035f);
        }
        gameObject.SetActive(false);
    }

    //Handles user clicks. Checks if the user clicks on the left or right side of the screen to go to the next page or previous page
    public void OnPointerClick(PointerEventData eventData)
    {
        string touch = eventData.position.ToString().Remove(0, 1);
        string[] namesArray = touch.Split(',');
        float xpos = float.Parse(namesArray[0]);

        if(xpos > Screen.width / 2)
        {
            if (state == 0)
            {
                part1.SetActive(false);
                part2.SetActive(true);
                state = 1;
            }
            else if (state == 1)
            {
                part2.SetActive(false);
                part3.SetActive(true);
                state = 2;
            }
            else if (state == 2)
            {
                StartCoroutine(FadeOut());
                PlayerPrefs.SetString("Tutorial", "Completed");
            }
        } else if(xpos < Screen.width / 2)
        {
            if(state == 1)
            {
                part2.SetActive(false);
                part1.SetActive(true);
                state = 0;
            } else if(state == 2)
            {
                part3.SetActive(false);
                part2.SetActive(true);
                state = 1;
            }
        }
        
    }
}

