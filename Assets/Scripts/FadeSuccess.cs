using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script fades out the "unlocked painting" message when correctly answering a question. This needs a separate script
//as a Coroutine cannot be activated from inactive scripts

public class FadeSuccess : MonoBehaviour
{

    Text txt;
    Color c;
    bool isFading;

    //Start function, runs before first frame
    private void Start()
    {
        txt = gameObject.GetComponent<Text>();
        c = txt.color;
        isFading = false;
    }

    //Checks if the object is active and makes sure the coroutine only starts once
    private void Update()
    {
        if(gameObject.active == true && isFading == false)
        {
            StartCoroutine(FadeOut());
            isFading = true;
        }        
    }

    //Fades out the text and disables the object afterwards
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2f);
        for (float f = 1f; f > 0f; f -= 0.05f)
        {
            c.a = f;
            txt.color = c;
            yield return new WaitForSeconds(0.035f);
        }
        gameObject.active = false;
    }

}
