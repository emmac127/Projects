using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxLvlSet : MonoBehaviour {
	int maxLvl;
	// Use this for initialization
	void Start () {
		maxLvl = PlayerPrefs.GetInt ("Level");
		GameObject[] go = GameObject.FindGameObjectsWithTag ("Star");
		for (int i = 0; i < go.Length; i++) {
			if (int.Parse(go[i].name) > maxLvl) {
				DestroyObject (go [i]);
			}
		
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
