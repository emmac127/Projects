using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeTime2 : MonoBehaviour {
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

		//image.CrossFadeAlpha (255f, 1f, false);

	}


	// Update is called once per frame
	void Update () {
		if (fading) {
			alpha += 1f * Time.deltaTime;
		}
		else
			alpha -= 1f * Time.deltaTime;

		if (alpha > 1f) {
			int Lev = PlayerPrefs.GetInt("CurLevel");
			if (Lev == 0) {
				Lev = 1;
			}
			SceneManager.LoadScene ("Level "+ Lev);
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
