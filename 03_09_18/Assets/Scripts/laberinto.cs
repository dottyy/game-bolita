using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laberinto : MonoBehaviour {

    // Use this for initialization
    public float velocidad = 3;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0, Input.GetAxis("Vertical") * velocidad * Time.deltaTime);
		
	}
}
