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
	int nextScene; //0 = Play Button, 1 = Levels, 2 = A specific Level
	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		if (fading)
			alpha = 0f;
		else
			alpha = 1f;


	}

	void LevelSceneNext(){
		
		nextScene = 1;
	}

	void PreciseLevelNext(){
		nextScene = 2;
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


			if (Lev == 0) {
				PlayerPrefs.SetInt ("CurLevel", 1);
				PlayerPrefs.SetInt ("Level", 1);
				Lev = 1;
			}
			switch (nextScene) {
			case 0:
				PlayerPrefs.SetInt ("CurLevel", Lev);
				SceneManager.LoadScene ("Level Display");
				break;
			case 1:
				PlayerPrefs.SetInt ("CurLevel", Lev);
				SceneManager.LoadScene ("Level Screen");
				break;
			case 2:
				
				SceneManager.LoadScene ("Level Display");
				break;
				
			}


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
