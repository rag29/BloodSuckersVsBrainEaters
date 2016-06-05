using UnityEngine;
using System.Collections;

public class MoveWithMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 temp = Input.mousePosition;
		temp.z = 1f;
		this.transform.position = Camera.main.ScreenToWorldPoint (temp);
	}
}
