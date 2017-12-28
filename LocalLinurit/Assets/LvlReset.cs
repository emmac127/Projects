using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlReset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ResetLev(){
		PlayerPrefs.SetInt ("Level", 0);
	}
}
