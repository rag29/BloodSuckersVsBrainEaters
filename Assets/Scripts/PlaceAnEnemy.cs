using UnityEngine;
using System.Collections;

public class PlaceAnEnemy : MonoBehaviour {

	public GameObject enemySprite;
	bool instantiate;
	bool put;

	// Use this for initialization
	void Start () {
		instantiate = false;
		put = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (instantiate && !put) 
		{
			GameObject place_me = (GameObject)Instantiate (enemySprite, this.transform.position, Quaternion.Euler (0, 0, 0));
			put = true;
		}
	}

	void OnMouseDown()
	{
		instantiate = true;
	}
}
