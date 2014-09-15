using UnityEngine;
using System.Collections;

public class TestRoom : MonoBehaviour {

	
	public Building[] buildingButtons;
	
	void Start()
	{
		
	}
	
	void Update()
	{
		ShowFlaggedButtons();
	}

	void OnEnter()
	{
		// Call (ZoomIn);
	}
	
	public void ChangeZoom()
	{
		/*if (Variables.GetBoolean("zoomedIn"))
		{
			ZoomOut();
		} else {
			ZoomIn();
		}*/
	}
	
	void ZoomIn()
	{
		Debug.Log("Zooming in.");
		/*Variables.SetBoolean("zoomedIn", true);
		StartSwipePan(topLeftView, bottomRightView, 1f);
		Execute();*/
	}
	
	void ZoomOut()
	{
		Debug.Log ("Zooming out.");
		/*Variables.SetBoolean("zoomedIn", false);
		PanToView(overView, 1f, false);
		Execute();*/
	}
	
	void ShowFlaggedButtons()
	{
		for (int i = 0; i < buildingButtons.Length; i++)
		{
			if (buildingButtons[i].visible)
			{
				/*ShowButton(buildingButtons[i].thisButton, buildingButtons[i].Examine);*/
			}
		}
	}
}
