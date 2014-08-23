using UnityEngine;
using System.Collections;
using Fungus;

public class RestoreView : Room {
	
	public View overviewView;
	
	void Start()
	{
		GameObject tempObj = GameObject.FindGameObjectWithTag("Overview");
		overviewView = tempObj.GetComponent<View>();
	}

	public void RestoreStoredView()
	{
		Debug.Log ("Exiting current room!");
		Game.SetView(overviewView);
		Execute();
	}
	
	
}
