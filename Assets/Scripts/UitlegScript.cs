using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UitlegScript : MonoBehaviour, IPointerClickHandler
{

    public GameObject menu;
    public GameObject uitleg;

    public RawImage schilderij;
    public Text title;
    public Text author;

    public string titlestring;
    public string authorstring;

    public Texture locked;
    public Texture unlocked;
    public Texture painting;

    public void OnPointerClick(PointerEventData eventData)
    {

        if(gameObject.GetComponent<RawImage>().texture != locked)
        {
            menu.SetActive(false);
            uitleg.SetActive(true);

            schilderij.texture = painting;
            title.text = titlestring;
            author.text = authorstring;
        }
        
    }
    
}
