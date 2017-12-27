using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRendS : MonoBehaviour {
	private Color white = Color.white;
	public Transform childNode;
	public Transform childNode2; //used to be parent
	public Vector3 endPos;
	public bool canDestroy;
	LineRenderer LR;
	private Renderer rend;
	// Use this for initialization
	void Start () {
		canDestroy = false;
		LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
		rend = GetComponent<Renderer>();
		lineRenderer.startColor = white;
		lineRenderer.endColor = white;
		lineRenderer.startWidth = 2;
		lineRenderer.endWidth = 2;
		Material whiteDiffuseMat = new Material(Shader.Find("Unlit/Texture"));
		lineRenderer.material = whiteDiffuseMat;
		lineRenderer.widthMultiplier = 0.01f;
		LR = lineRenderer;
	}

	// Update is called once per frame
	void Update () {
		if (childNode2 == null && childNode == null) {
			Destroy (gameObject);
		}
		if (childNode2 == null) {
			//create animation to slowly destroy line
			//starting from childNode2
			endPos = LR.GetPosition (0);
			endPos = Vector3.MoveTowards (endPos, childNode.position, 0.05f);
			LR.SetPosition (0, endPos);
			if (endPos == childNode.position && canDestroy) {
				
				childNode.gameObject.GetComponent<DieTime> ().enabled = true;
				Destroy (gameObject);
			}
		} else {
			LR.SetPosition(0,childNode2.position);
		}

		if (childNode == null) {
			
			endPos = LR.GetPosition (1);
			endPos = Vector3.MoveTowards (endPos, childNode2.position, 0.05f);
			LR.SetPosition (1, endPos);
			if (endPos == childNode2.position && canDestroy) {
				childNode2.gameObject.GetComponent<DieTime> ().enabled = true;
				Destroy (gameObject);
			}
			//create animation to slowly destroy line
			//starting from childNode
			//Destroy (gameObject);
		}
		else{
			LR.SetPosition (1,childNode.position);
		}

		//rend.material.mainTextureScale = new Vector2((int)Vector2.Distance(childNode2.position,childNode.position), 1) ;

	}
}
