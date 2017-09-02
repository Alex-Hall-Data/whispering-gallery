using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_ball : MonoBehaviour {

	public Rigidbody rb;
	public Vector3 start_velocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce( new Vector3 (100f,30f,-100f));
		//rb.velocity=start_velocity;
		
	}

		
	// Update is called once per frame
	void Update () {
		
	}
}
