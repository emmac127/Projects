using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour {
	public Sprite Unsel;
	public Sprite Sel;
	private GameObject[] nodes;


	// Use this for initialization
	void Start () {

		nodes = GameObject.FindGameObjectsWithTag("Star");
	}

	void OnMouseDown(){
		nodes = GameObject.FindGameObjectsWithTag("Star");
		for (int i = 0; i < nodes.Length; i++) {
			nodes[i] .GetComponent<SpriteRenderer>().sprite = Unsel;
		}
		gameObject.GetComponent<SpriteRenderer>().sprite = Sel;

	}

	void OnMouseDrag()
	{
		//unselect all other sprites
		nodes = GameObject.FindGameObjectsWithTag("Star");
		for (int i = 0; i < nodes.Length; i++) {
			nodes[i] .GetComponent<SpriteRenderer>().sprite = Unsel;
		}
		gameObject.GetComponent<SpriteRenderer>().sprite = Sel;


		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
		transform.position = new Vector3( pos_move.x, pos_move.y, pos_move.z) ;

	}


	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward * Time.deltaTime * 30);

	}
}
