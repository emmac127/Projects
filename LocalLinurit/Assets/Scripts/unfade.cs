using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unfade : MonoBehaviour {
	float timeInit;
	public GameObject fade;
	// Use this for initialization
	void Start () {
		timeInit = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeInit += Time.deltaTime;
		if (timeInit >= 2f) {
			fade.GetComponent<fadeTime2> ().fading = true;
			fade.SetActive (true);
		}
			
	}
}
