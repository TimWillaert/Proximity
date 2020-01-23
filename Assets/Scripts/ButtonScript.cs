using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//This script is for the different buttons in the app that appear multiple times (e.g the close button in the menu)
public class ButtonScript : MonoBehaviour, IPointerClickHandler
{

    //Variable instantiation
    public GameObject menu;
    public GameObject uitleg;
    public GameObject camera;
    public GameObject main;
    string state;

    //Runs when the user clicks on a button
    public void OnPointerClick(PointerEventData eventData)
    {

        //If-statements check which button the user clicked and performs the proper action
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

        if(gameObject.tag == "HostBeacon")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }

    }

}
