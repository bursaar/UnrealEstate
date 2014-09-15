using UnityEngine;
using System.Collections;
using Fungus;

public class RestoreView : MonoBehaviour {
	
	public View overviewView;
	
	void Start()
	{
		GameObject tempObj = GameObject.FindGameObjectWithTag("Overview");
		overviewView = tempObj.GetComponent<View>();
	}

	public void RestoreStoredView()
	{
		Debug.Log ("Exiting current room!");
		/*Game.PanToView(overviewView, 1.5f);
		Variables.SetBoolean("zoomedIn", false);
		Execute();*/
	}
	
	
}
