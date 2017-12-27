using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class competer : MonoBehaviour {
	private int childNum;
	// Use this for initialization
	void Start () {
		//load all children
		childNum = transform.childCount;

		if (childNum == 0) {
			DestroyObject (gameObject);

		} else {
			Transform hasPermission = transform.GetChild (0);
			float mag = 200000;
			for (int i = 0; i < childNum; i++) {
				LineRenderer LR = transform.GetChild (i).gameObject.GetComponent<LineRenderer> ();

				if (Mathf.Abs ((LR.GetPosition (1) - LR.GetPosition (0)).magnitude) < mag) {
					mag = Mathf.Abs ((LR.GetPosition (1) - LR.GetPosition (0)).magnitude);
					hasPermission = transform.GetChild (i);
				}
			}

			//make candestroy = true for the hasPermission
			hasPermission.gameObject.GetComponent<lineRendS> ().canDestroy = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//if one of the children is deleted, delete all children
		//only give permission to one of the lineRend objects to destroy
		if(childNum != transform.childCount ){
			for (int i = 0; i < transform.childCount; i++) {
				DestroyObject(transform.GetChild (i).gameObject);
			}
			DestroyObject (gameObject);
		}
			
	}
}
