using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour, IPointerClickHandler
{

    public GameObject menu;
    public GameObject uitleg;
    public GameObject camera;
    public GameObject main;
    string state;

    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if(state != "Camera")
                {
                    if(state == "Settings")
                    {
                        menu.SetActive(false);
                        uitleg.SetActive(false);
                        state = "Camera";
                        camera.SetActive(true);
                    }
                    else
                    {
                        menu.SetActive(true);
                        uitleg.SetActive(false);
                        state = "Settings";
                        camera.SetActive(false);
                    }
                }
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if(gameObject.tag == "Close")
        {
            menu.SetActive(false);
            uitleg.SetActive(false);
            state = "Camera";
            camera.SetActive(true);
            main.SetActive(true);
        }

        if(gameObject.tag == "Back")
        {
            menu.SetActive(true);
            uitleg.SetActive(false);
            state = "Settings";
            camera.SetActive(false);
        }

        if (gameObject.tag == "Hamburger")
        {
            menu.SetActive(true);
            main.SetActive(false);
            state = "Settings";
            camera.SetActive(false);
        }

    }

}
