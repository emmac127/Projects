using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulate : MonoBehaviour {

	private GameObject[] nodes;
	public Sprite Sel;

	// Use this for initialization
	void Start () {


		//sim ();
	}

	void sim(){
		nodes = GameObject.FindGameObjectsWithTag("Star");
		for (int i = 0; i < nodes.Length; i++) {
			if (nodes [i].GetComponent<SpriteRenderer> ().sprite == Sel) {
				nodes[i].GetComponent<DieTime> ().enabled = true;
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
