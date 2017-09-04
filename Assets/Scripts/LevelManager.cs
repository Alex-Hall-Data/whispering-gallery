using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadRing(){
		SceneManager.LoadScene ("Ring");
	}

	public void LoadEllipse(){
		SceneManager.LoadScene ("Ellipse");
	}

	public void LoadNYGC(){
		SceneManager.LoadScene ("NYGC");
	}
}
