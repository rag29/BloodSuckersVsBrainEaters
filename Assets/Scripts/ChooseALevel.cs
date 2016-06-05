using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseALevel : MonoBehaviour {

	public GameObject mySprite;
	public Light myLight;
	SpriteRenderer rend;
	public Text myText;
	// Use this for initialization
	void Start () 
	{
		rend = mySprite.GetComponent<SpriteRenderer> ();
		myLight.enabled = false;
		rend.enabled = false;
		myText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseOver()
	{
		myLight.enabled = true;
		rend.enabled = true;
		myText.enabled = true;
	}

	void OnMouseExit()
	{
		myLight.enabled = false;
		rend.enabled = false;
		myText.enabled = false;
	}
}
