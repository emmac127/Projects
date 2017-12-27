using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeLine : MonoBehaviour {
	public Transform[] targetArr;
	public GameObject prefab;
	// Use this for initialization

	void Start () {



		//for every child, make a new custom lineRend object
		for (int i = 0; i < targetArr.Length; i++) {
			GameObject line = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
			line.GetComponent<lineRendS> ().childNode = targetArr [i];
			line.GetComponent<lineRendS> ().childNode2 = transform;


		}

	}

	void Update()
	{


	}

	// Update is called once per frame
	void OnDrawGizmos() {
		

		for (int i = 0; i < targetArr.Length ; i++) {
			Transform target = targetArr [i];
			if (target != null) {
				Gizmos.color = Color.white;
				Gizmos.DrawLine(transform.position, target.position);
			}
		}

	}
}
