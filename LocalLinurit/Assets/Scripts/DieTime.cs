using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTime : MonoBehaviour {
	private float scale = 1;
	public GameObject competePrefab;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			transform.Rotate (0,0,8);
			scale -= 0.05f;
		if (scale <= 0) {
			//create line tracker
			GameObject[] lines;
			lines = GameObject.FindGameObjectsWithTag("Line");
			GameObject competer = (GameObject)Instantiate(competePrefab, transform.position, Quaternion.identity);
			//check if child1 or child2 are this object's transform
			for(int i = 0; i < lines.Length; i++){
				if (lines [i].GetComponent<lineRendS> ().childNode == gameObject.transform ||
				   lines [i].GetComponent<lineRendS> ().childNode2 == gameObject.transform) {
					lines [i].transform.SetParent (competer.transform);
				}
			}
			Destroy (gameObject);
		}
			transform.localScale = new Vector3(scale,scale,scale);

	
	}
}
