using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition: MonoBehaviour {

	Vector3 startPos;

	void Start () {
		startPos = transform.position;

	}

	void OnMouseDown(){
		gameObject.transform.position = startPos;
	}

}
