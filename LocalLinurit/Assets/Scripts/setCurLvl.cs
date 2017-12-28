using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setCurLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetTo1(){
		PlayerPrefs.SetInt ("CurLevel", 1);
	}
}
