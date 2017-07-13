using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script4Action : MonoBehaviour {

	public Transform bladeShape; // molde arma
	public Transform blade; // arma
	public bool isThrowing = false; // indicador está lanzándose

	public int childOfBlade = 1;

	// Use this for initialization
	void Start () {

		bladeShape = GetComponent<Transform> ().GetChild(childOfBlade);
		bladeShape.gameObject.SetActive (false);

//		print ("mi arma es " + bladeShape);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.B)) { // hacemos accion de usar arma con B

			throwBlade ();
		}

		if (isThrowing && blade.position.x >= 5) { // desactivamos arma si esta lanzandose y llego al limite

//			print ("Ya llegue al limite");

			blade.gameObject.SetActive(false);
			isThrowing = false;
		}
	}

	// Accion de lanzar
	void throwBlade() {

//		print ("Aqui lanzamos");

		if (!isThrowing) {
	
			blade = Instantiate(bladeShape, new Vector3(2, 0, 0), Quaternion.identity);
			blade.gameObject.SetActive (true);
			isThrowing = true;
		}
	}
}
