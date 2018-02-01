using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour {

	float zRotation = -12f;

	void OnMouseDown(){
		zRotation +=5f;
		transform.parent.eulerAngles = new Vector3(5, zRotation, 0);
	}
}

