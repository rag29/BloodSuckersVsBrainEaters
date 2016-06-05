using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChooseASide : MonoBehaviour {

	public Light spotlight1;
	public Light spotlight2;

	// Use this for initialization
	void Start () 
	{
		spotlight1.enabled = false;
		spotlight2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseOver()
	{
		if (this.gameObject.tag == "left_choose_sprite") 
		{
			spotlight1.enabled = true;
		}

		else if (this.gameObject.tag == "right_choose_sprite") 
		{
			spotlight2.enabled = true;
		}
	}

	void OnMouseExit()
	{
		if (this.gameObject.tag == "left_choose_sprite") 
		{
			spotlight1.enabled = false;
		}

		else if (this.gameObject.tag == "right_choose_sprite") 
		{
			spotlight2.enabled = false;
		}
	}

	void OnMouseDown()
	{
		if (this.gameObject.tag == "left_choose_sprite") 
		{
			SceneManager.LoadScene("ChooseALevel");
			//add in code to set it to vampires
		}

		else if (this.gameObject.tag == "right_choose_sprite") 
		{
			SceneManager.LoadScene("ChooseALevel");
			//add in code to set it to zombies
		}
	}
}
