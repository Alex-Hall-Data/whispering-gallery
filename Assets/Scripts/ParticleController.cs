using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleController : MonoBehaviour {

	public Slider xpos;
	public Slider ypos;
	public Slider zpos;
	public Slider zrotation;
	public Slider spread;
	public Slider emissionRateSlider;

	private float deltax;
	private float deltay;
	private float deltaz;
	private float deltaRotation;
	private float deltaSpread;
	private float emissionRate;
	private ParticleSystem particles;

	private Vector3 defaultPosition = new Vector3(8f,3f,-8f); //defailt = 8,3,-8 //FLAG X VALUE CHANGED TO 18 FROM 8

	// Use this for initialization
	void Start () {
		particles = FindObjectOfType<ParticleSystem> ();
		var particleShape = particles.shape;
		particleShape.enabled = true;
		particleShape.angle = 30;
	}
	
	// Update is called once per frame
	void Update () {

		//get slider positions
		deltax = xpos.value;
		deltay = ypos.value;
		deltaz = zpos.value;
		deltaRotation = zrotation.value;
		deltaSpread = spread.value;
		emissionRate = emissionRateSlider.value;

		//assign slider values to particle system
		transform.position = defaultPosition + new Vector3 (deltax, deltay, deltaz);
		transform.eulerAngles = new Vector3 (-deltaRotation, 135f, 0f);

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
