using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script allows the user to delete his data
public class ClearCache : MonoBehaviour
{

    //Variable instantiation
    public Button button;
    public Button ja;
    public Button nee;
    public GameObject panelDark;
    public GameObject panelLight;

    //Start function, runs before first frame
    void Start()
    {
        //Looks for Button components and adds action listeners to them
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button jabtn = ja.GetComponent<Button>();
        jabtn.onClick.AddListener(JaClick);

        Button neebtn = nee.GetComponent<Button>();
        neebtn.onClick.AddListener(NeeClick);
    }

    //Different actions for different buttons
    void TaskOnClick()
    {
        panelDark.SetActive(true);
        panelLight.SetActive(true);
    }

    void JaClick()
    {
        //Removes player-saved data
        PlayerPrefs.DeleteAll();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    void NeeClick()
    {
        panelDark.SetActive(false);
        panelLight.SetActive(false);
    }

}
