using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeTime : MonoBehaviour {
	//used in main menu when you press play
	Image image;
	float alpha;
	public bool fading;
	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		if (fading)
			alpha = 0f;
		else
			alpha = 1f;
		

	}
	
	// Update is called once per frame
	void Update () {
		if (fading) {
			alpha += 1f * Time.deltaTime;
		}
		else
			alpha -= 1f * Time.deltaTime;
		
		if (alpha > 1f) {
			int Lev = PlayerPrefs.GetInt("Level"); //max level reached
			PlayerPrefs.SetInt ("CurLevel", Lev);

			if (Lev == 0) {
				PlayerPrefs.SetInt ("CurLevel", 1);
				PlayerPrefs.SetInt ("Level", 1);
				Lev = 1;
			}

			SceneManager.LoadScene ("Level Display");

			alpha = 1f;
			//fading = false;
		}
		if (alpha < 0f && !fading){
			gameObject.SetActive (false);
		}
		Color c = image.color;
		c.a = alpha;
		image.color = c;
	}
}
