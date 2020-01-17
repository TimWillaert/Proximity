using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelScript : MonoBehaviour
{
    public GameObject parent;
    private SkinnedMeshRenderer meshrenderer;
    private AudioSource audiosource;
    private Animator anim;

    bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = gameObject.GetComponent<SkinnedMeshRenderer>();
        audiosource = gameObject.GetComponent<AudioSource>();
        anim = parent.GetComponent<Animator>();
        audiosource.enabled = false;
        anim.enabled = false;
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
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
