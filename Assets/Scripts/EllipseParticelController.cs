using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EllipseParticelController : MonoBehaviour {

	public Slider xrotation;
	public Slider yrotation;
	public Slider spread;
	public Slider emissionRateSlider;

	private float deltaXRotation;
	private float deltaYRotation;
	private float deltaSpread;
	private float emissionRate;
	private ParticleSystem particles;

	private Vector3 defaultPosition = new Vector3(0f,0f,-8.66f); //defailt = 8,3,-8 //FLAG X VALUE CHANGED TO 18 FROM 8

	// Use this for initialization
	void Start () {
		particles = FindObjectOfType<ParticleSystem> ();
		var particleShape = particles.shape;
		particleShape.enabled = true;
		particleShape.angle = 10;
	}

	// Update is called once per frame
	void Update () {

		//get slider positions
		deltaXRotation = xrotation.value;
		deltaYRotation = yrotation.value;
		deltaSpread = spread.value;
		emissionRate = emissionRateSlider.value;

		//assign slider values to particle system
		transform.position = defaultPosition;
		transform.eulerAngles = new Vector3 (deltaXRotation, deltaYRotation, 0f);

		//get particle shape component and modify with slider value
		var particleShape = particles.shape;
		particleShape.enabled = true;
		particleShape.angle = deltaSpread;

		//get particle emission component and modify with slider value
		var particleEmission = particles.emission;
		particleEmission.enabled = true;
		particleEmission.rateOverTime = emissionRate;
	}
}
