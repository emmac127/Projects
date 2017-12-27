using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeLvlStats : MonoBehaviour {
	public int par; //the best number of moves for the round
	public int sims; //number of simulations run
	public GameObject fade;
	public GameObject panel;
	private float timeInterval;
	private bool statsShow; //stops updating when stat screen shows
	private int score = 0;
	// Use this for initialization
	void Start () {
		statsShow = false;
		sims = 0;
		PlayerPrefs.SetInt ("LvlPar", par);
		timeInterval = 0f;

	}

	//activated when someone presses the play button
	void simDone(){
		sims++;
	}

	int calcScore(){
		return 3 - (sims - par);

	}


	//activated when there are no nodes left
	void allSimDone(){
		fade.SetActive (true);
		panel.SetActive (true);
		score = calcScore();
		print (score);


	}
	
	// Update is called once per frame
	void Update () {
		timeInterval += Time.deltaTime;
		starActive[] activeS = panel.GetComponentsInChildren<starActive> ();
		for(int i = 0; i< score; i++){
			activeS [i].isFull = true;
		}

		if (timeInterval > 1 && !statsShow) {
			int len = GameObject.FindGameObjectsWithTag ("Star").Length;
			timeInterval = 0f;
			if (len == 0) {
				statsShow = true;
				allSimDone ();
			}

		}
	}
}
