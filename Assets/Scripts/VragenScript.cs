using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//This script handles the questions when a user gets close to a painting
public class VragenScript : MonoBehaviour, IPointerClickHandler
{

    //Variable instantiation
    public GameObject vorm;
    public GameObject kleur;
    public GameObject licht;
    public GameObject imgtarget;
    public GameObject textObj;
    public AudioClip correct;

    //Handles the user input and performs the proper action depending on if they got it right or wrong
    public void OnPointerClick(PointerEventData eventData)
    {
        if(gameObject.tag == "Juist")
        {
            AudioSource.PlayClipAtPoint(correct, new Vector3(0, 0, 0), 0.5f);
            vorm.SetActive(false);
            kleur.SetActive(false);
            licht.SetActive(false);
            //imgtarget.SetActive(true);
            textObj.SetActive(true);
        }

        if(gameObject.tag == "Fout")
        {
            vorm.SetActive(false);
            kleur.SetActive(true);
            Handheld.Vibrate();
        }

        if(gameObject.tag == "Fout1")
        {
            kleur.SetActive(false);
            licht.SetActive(true);
            Handheld.Vibrate();
        }

        if(gameObject.tag == "Fout2")
        {
            licht.SetActive(false);
            vorm.SetActive(true);
            Handheld.Vibrate();
        }

    }

}
