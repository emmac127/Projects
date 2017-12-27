using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starActive : MonoBehaviour {
	public Sprite empty;
	public Sprite full;
	public bool isFull;

	// Use this for initialization
	void Start () {
		isFull = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFull){
			gameObject.GetComponent<Image> ().sprite = full;
		}
	}
}
