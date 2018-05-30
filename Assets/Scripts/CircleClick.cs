using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CircleClick : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast (ray, out hit, 100.0f)){
				Debug.Log("test2");
			}
		}
	}
}
