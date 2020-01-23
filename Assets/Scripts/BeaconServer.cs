using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script allows a device to act as an iBeacon
public class BeaconServer : iBeaconServer
{

    //Variable instantiation
    public Text isTransmitting;
    public Text transmit;
    public Text bluetooth;

    //Start function, runs before first frame
    private void Start()
    {
        //Enable Bluetooth
        BluetoothState.EnableBluetooth();

        //Check if the device is capable of transmitting as a beacon and if Bluetooth is enabled, shows on screen
        transmit.text = "Can transmit: " + checkTransmissionSupported().ToString();
        bluetooth.text = "Bluetooth: " + BluetoothState.GetBluetoothLEStatus().ToString();

        try
        {
            //Start transmitting
            Transmit();
            isTransmitting.text = "TRANSMITTING";
        }
        catch (iBeaconException e)
        {
            Debug.Log(e);
            isTransmitting.text = e.ToString();
        }
    }
   
}
