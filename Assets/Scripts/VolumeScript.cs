using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.
using UnityEngine.Video;

public class VolumeScript : MonoBehaviour
{
    public Slider mainSlider;
    ushort track = 0;

    public void Start()
    {
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        if (!PlayerPrefs.HasKey("Volume"))
        {
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
