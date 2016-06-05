using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform goal;
	float speed;

	// Use this for initialization
	void Start () {
	
		speed = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move()
	{
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, goal.position, step);
	}

	void Attack()
	{
		
	}

	void OnCollisionEnter()
	{
		Destroy (this.gameObject);
	}

}
