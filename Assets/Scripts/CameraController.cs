using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Camera camera;

	// Use this for initialization
	void Start () {
		camera = FindObjectOfType<Camera> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		//translate camera
		if (Input.GetKey ("up")) {
			camera.transform.position += camera.transform.forward*0.1f;
		}
		if (Input.GetKey ("down")) {
			camera.transform.position += camera.transform.forward*-0.1f;
		}
		if (Input.GetKey ("left")) {
			camera.transform.position += camera.transform.right*-0.1f;
		}
		if (Input.GetKey ("right")) {
			camera.transform.position += camera.transform.right*0.1f;
		}


		//rotate camera
		if (Input.GetKey (KeyCode.W)) {
			camera.transform.eulerAngles += new Vector3 (-1.5f,0f,0f);
		}
		if (Input.GetKey (KeyCode.S)) {
			camera.transform.eulerAngles += new Vector3 (1.5f,0f,0f);
		}
		if (Input.GetKey (KeyCode.A)) {
			camera.transform.eulerAngles += new Vector3 (0.0f,-1.5f,0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			camera.transform.eulerAngles += new Vector3 (0.0f,1.5f,0f);
		}


		if (Input.GetKey ("escape")) {
			Application.Quit ();
		}
	}

	}
