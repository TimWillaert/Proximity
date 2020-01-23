using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for the 3D James Ensor behaviour
public class ModelScript : MonoBehaviour
{

    //Variable instantiation
    public GameObject parent;
    private SkinnedMeshRenderer meshrenderer;
    private AudioSource audiosource;
    private Animator anim;

    bool isPlaying;

    //Start function, runs before first frame
    void Start()
    {
        meshrenderer = gameObject.GetComponent<SkinnedMeshRenderer>();
        audiosource = gameObject.GetComponent<AudioSource>();
        anim = parent.GetComponent<Animator>();
        audiosource.enabled = false;
        anim.enabled = false;
        isPlaying = false;
    }

    //Update function, runs each frame
    void Update()
    {

        //If-statement checks if Ensor is already playing or not, and performs the proper actions
        if (meshrenderer.enabled == true && isPlaying == false)
        {
            audiosource.enabled = true;
            anim.enabled = true;
            anim.Rebind();
            isPlaying = true;
            Handheld.Vibrate();
        } else if(meshrenderer.enabled == true && isPlaying == true)
        {
            //
        } else if(meshrenderer.enabled == false)
        {
            isPlaying = false;
            audiosource.enabled = false;
            anim.enabled = false;
        }
    }
}
