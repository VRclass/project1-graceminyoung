using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjectOFF : MonoBehaviour
{
    public Light ligthToSwitch = null;

    // When the trigger is entered 
    public void OnTriggerEnter(Collider other)
    {
        ligthToSwitch.enabled = false; // turn the light off
        print("entered the OFF trigger");  // print the message
    }

}
