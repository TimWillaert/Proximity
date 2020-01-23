using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//This script handles the explanation page
public class UitlegScript : MonoBehaviour, IPointerClickHandler
{

    //Variable instantiation
    public GameObject menu;
    public GameObject uitleg;

    public RawImage schilderij;
    public Text title;
    public Text author;
    public Text explanation;

    public string titlestring;
    public string authorstring;
    public string explanationstring;

    public Texture locked;
    public Texture unlocked;
    public Texture painting;

    //Whenever a user clicks on a painting, applies the proper text and image to the explanation page
    public void OnPointerClick(PointerEventData eventData)
    {

        if(gameObject.GetComponent<RawImage>().texture != locked)
        {
            menu.SetActive(false);
            uitleg.SetActive(true);

            schilderij.texture = painting;
            title.text = titlestring;
            author.text = authorstring;
            explanation.text = explanationstring;
        }
        
    }
    
}
