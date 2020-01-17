﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoScript : MonoBehaviour
{

    public MeshRenderer meshrenderer;
    public VideoPlayer player;
    public string title;
    public string author;
    public Text textobj;
    public Text subtitleobj;

    public RawImage panel;
    public Texture panelImg;
    public Material blurshader;

    public Texture painting;
    public int paintingnumber;
    public GameObject collection;

    int Schilderij1, Schilderij2, Schilderij3, Schilderij4;

    private bool tekstSet = false;

    // Start is called before the first frame update
    void Start()
    {
        player.enabled = false;
        Schilderij1 = PlayerPrefs.GetInt("Schilderij1");
        Schilderij2 = PlayerPrefs.GetInt("Schilderij2");
        Schilderij3 = PlayerPrefs.GetInt("Schilderij3");
        Schilderij4 = PlayerPrefs.GetInt("Schilderij4");
    }

    // Update is called once per frame
    void Update()
    {

        if(meshrenderer.enabled == true && tekstSet == false)
        {
            tekstSet = true;
            Handheld.Vibrate();
            player.enabled = true;
            textobj.text = title;
            subtitleobj.text = author;

            panel.material = null;
            panel.texture = panelImg;

            string number = paintingnumber.ToString();
            string concat1 = "Schilderij" + number;
            string concat2 = "TxtSchilderij" + number;
            string concat3 = "AuthorSchilderij" + number;

            PlayerPrefs.SetInt(concat1, 1);

            GameObject collectiontitle = collection.transform.Find(concat2).gameObject;
            collectiontitle.GetComponent<Text>().text = title;

            GameObject collectionimg = collection.transform.Find(concat1).gameObject;
            collectionimg.GetComponent<RawImage>().texture = painting;

            GameObject collectionauthor = collection.transform.Find(concat3).gameObject;
            collectionauthor.GetComponent<Text>().text = author;

        } else if(meshrenderer.enabled == false && tekstSet == true)
        {
            tekstSet = false;
            player.enabled = false;
            textobj.text = "Proximity";
            subtitleobj.text = "Scan een schilderij";

            panel.texture = null;
            panel.material = blurshader;
        }
    }
}
