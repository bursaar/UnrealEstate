using UnityEngine;
using System.Collections;

public class RestoreView : MonoBehaviour {
	
	
	void Start()
	{
		GameObject tempObj = GameObject.FindGameObjectWithTag("Overview");
	}

	public void RestoreStoredView()
	{
		Debug.Log ("Exiting current room!");
		/*Game.PanToView(overviewView, 1.5f);
		Variables.SetBoolean("zoomedIn", false);
		Execute();*/
	}
	
	
}
