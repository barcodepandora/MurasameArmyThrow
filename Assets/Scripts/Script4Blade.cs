using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4Blade : MonoBehaviour {

	public Transform blade; // arma

	public int VELOCIDAD = 10; // VELOCIDAD

	// Use this for initialization
	void Start () {

		blade = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (blade.gameObject.activeInHierarchy) { // es un elemento activo

// movemos
			blade.Translate( new Vector3 (VELOCIDAD * Time.deltaTime, blade.position.y, blade.position.z) );

//			print ("esta en " + blade.position.x);
		}
	}
}
