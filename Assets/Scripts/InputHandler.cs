using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour {


	void Update () {
	
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		
	}
}
