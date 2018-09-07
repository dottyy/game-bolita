using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoFisico : MonoBehaviour {

    // Use this for initialization
    public float forceValue;
    private Rigidbody rigidbody;
    private AudioSource sonido;
	void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
        sonido = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * 2);
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
        {
            rigidbody.AddForce(Vector3.up * 4, ForceMode.Impulse);
            sonido.Play();
        }
	}
}
