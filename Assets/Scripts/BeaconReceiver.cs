using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script allows a device to receive iBeacon signals and perform specific actions
public class BeaconReceiver : iBeaconReceiver
{

    //Variable instantiation
    public Text received;
    public Text distance;
    public Canvas canvas;
    public GameObject vorm;
    int MasksQuestions;

    //Start function, runs before first frame
    void Start()
    {
        if (!PlayerPrefs.HasKey("MasksQuestions"))
        {
            MasksQuestions = 0;
        }
        else
        {
            MasksQuestions = PlayerPrefs.GetInt("MasksQuestions");
        }
        //Enables Bluetooth
        BluetoothState.EnableBluetooth();
        BeaconRangeChangedEvent += BeaconReceiver_BeaconRangeChangedEvent;
        try
        {
            //Start scanning for beacons
            Scan();
        }
        catch (iBeaconException e)
        {
            Debug.Log(e);
        }
    }

    //Runs every time a change in range from a beacon is detected
    private void BeaconReceiver_BeaconRangeChangedEvent(Beacon[] beacons)
    {

        string ID = beacons[0].UUID.ToString();
        received.text = ID;

        BeaconRange range = beacons[0].range;
        distance.text = range.ToString();

        //Show the masks questions
        if (ID == "3da41fa8-e4af-457f-9fd1-4793e4a94aa1" && MasksQuestions == 0 && range == BeaconRange.NEAR)
        {
            vorm.SetActive(true);
            MasksQuestions = 1;
            PlayerPrefs.SetInt("MasksQuestions", 1);
        } else if (ID == "3da41fa8-e4af-457f-9fd1-4793e4a94aa1" && MasksQuestions == 0 && range == BeaconRange.IMMEDIATE)
        {
            vorm.SetActive(true);
            MasksQuestions = 1;
            PlayerPrefs.SetInt("MasksQuestions", 1);
        }
    }

}
