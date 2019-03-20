using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class Arduino : MonoBehaviour {

    SerialPort stream = new SerialPort("/dev/cu.usbmodem1411", 9600);
    public GameObject tree;
    Material treeMaterial;
    float temperature = 0f;

    private float temperatureMax = 70f;
    private float temperatureMin = 20f;

	// Use this for initialization
	void Start () {
        stream.Open();
        treeMaterial = tree.GetComponent<Renderer>().materials[1];
        treeMaterial.color = Color.red;

	}
	
	// Update is called once per frame
	void Update () {
        string value = stream.ReadLine();
        Debug.Log(value);
        temperature = float.Parse(value);
        float inbetweenNumber = 0f; // We want this to be between 0 and 1, and change according to the temperature.
        inbetweenNumber = (temperature-temperatureMin)/(temperatureMax - temperatureMin);
        treeMaterial.color = Color.Lerp(Color.white, Color.red, inbetweenNumber);
	}
    private void OnApplicationQuit()
    {
        stream.Close();
    }

}
