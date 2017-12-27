using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelFade : MonoBehaviour {
	//go from level to main menu
	Image image;
	float alpha;
	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		alpha = 0f;
		

		//image.CrossFadeAlpha (255f, 1f, false);

	}

	// Update is called once per frame
	void Update () {
		
		alpha += 1f * Time.deltaTime;
		

		if (alpha >= 1f) {
			SceneManager.LoadScene ("Main Menu");

		}

		Color c = image.color;
		c.a = alpha;
		image.color = c;
	}
}
