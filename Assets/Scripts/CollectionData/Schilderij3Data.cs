using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schilderij3Data : MonoBehaviour
{

    int isScanned;
    public Texture unlocked;
    public Text titel;
    public Text auteur;

    // Start is called before the first frame update
    void Start()
    {
        isScanned = PlayerPrefs.GetInt("Schilderij3");
        if (isScanned == 1)
        {
            gameObject.GetComponent<RawImage>().texture = unlocked;
            titel.text = "Self Portrait";
            auteur.text = "James Ensor";
        }
    }

}
