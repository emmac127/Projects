using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getLevlNum : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int lvl = PlayerPrefs.GetInt ("CurLevel");
		gameObject.GetComponent<Text> ().text = lvl.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
