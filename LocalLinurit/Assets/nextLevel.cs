using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour {
	public GameObject fade;
	public int nextLvl;
	//sets the next level to go to
	//starts to this level away to travel to the next level
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("Level") < nextLvl) {
			PlayerPrefs.SetInt ("Level", nextLvl);
		}
		PlayerPrefs.SetInt ("CurLevel", nextLvl);
		fade.GetComponent<fadeTime> ().fading = true;
		fade.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
