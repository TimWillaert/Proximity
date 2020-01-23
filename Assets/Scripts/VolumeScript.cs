using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Video;

//This script handles the volume slider in the settings
public class VolumeScript : MonoBehaviour
{

    //Variable instantiation
    public Slider mainSlider;
    ushort track = 0;

    //Start function, runs before first frame
    public void Start()
    {
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        if (!PlayerPrefs.HasKey("Volume"))
        {
            //Sets slider to 1 by default
            mainSlider.value = 1f;
            PlayerPrefs.SetFloat("Volume", 1f);
            foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Object"))
            {
                VideoPlayer player = fooObj.GetComponent<VideoPlayer>();
                player.SetDirectAudioVolume(track, 1f);
            }
        }
        else
        {
            mainSlider.value = PlayerPrefs.GetFloat("Volume");
            foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Object"))
            {
                VideoPlayer player = fooObj.GetComponent<VideoPlayer>();
                player.SetDirectAudioVolume(track, PlayerPrefs.GetFloat("Volume"));
            }
        }
    }

    //Runs every time the slider has changed values, updates volume
    public void ValueChangeCheck()
    {
        PlayerPrefs.SetFloat("Volume", mainSlider.value);
        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Object"))
        {
            VideoPlayer player = fooObj.GetComponent<VideoPlayer>();
            player.SetDirectAudioVolume(track, mainSlider.value);
        }

        foreach (GameObject fooObj in GameObject.FindGameObjectsWithTag("Object2"))
        {
            AudioSource player = fooObj.GetComponent<AudioSource>();
            player.volume = mainSlider.value;
        }
    }
}
