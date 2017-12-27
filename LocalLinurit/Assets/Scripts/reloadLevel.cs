using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Application.LoadLevel(Application.loadedLevel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
