using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schilderij2Data : MonoBehaviour
{

    int isScanned;
    public Texture unlocked;
    public Text titel;
    public Text auteur;

    // Start is called before the first frame update
    void Start()
    {
        isScanned = PlayerPrefs.GetInt("Schilderij2");
        if (isScanned == 1)
        {
            gameObject.GetComponent<RawImage>().texture = unlocked;
            titel.text = "Old Lady with Masks";
            auteur.text = "James Ensor";
        }
    }

}
