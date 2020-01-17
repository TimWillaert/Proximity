using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearCache : MonoBehaviour
{

    public Button button;
    public Button ja;
    public Button nee;
    public GameObject panelDark;
    public GameObject panelLight;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button jabtn = ja.GetComponent<Button>();
        jabtn.onClick.AddListener(JaClick);

        Button neebtn = nee.GetComponent<Button>();
        neebtn.onClick.AddListener(NeeClick);
    }

    void TaskOnClick()
    {
        panelDark.SetActive(true);
        panelLight.SetActive(true);
    }

    void JaClick()
    {
        PlayerPrefs.DeleteAll();
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    void NeeClick()
    {
        panelDark.SetActive(false);
        panelLight.SetActive(false);
    }

}
