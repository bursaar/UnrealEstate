﻿using UnityEngine;
using System.Collections;


public class ZoomControl : MonoBehaviour {

	
	BuildingControl bc;
	
	void Start()
	{
		bc = FindObjectOfType<BuildingControl>();
	}

	public void ChangeZoom()
	{
		/*if (Variables.GetBoolean("zoomedIn"))
		{
			ZoomOut();
		} else {
			ZoomIn();
		}*/
		bc.ShowFlaggedButtons();
	}
	
	public void ZoomIn()
	{
		Debug.Log("Zooming in.");
		/*Variables.SetBoolean("zoomedIn", true);
		Room.StartSwipePan(topLeftView, bottomRightView, 1f);
		Room.Execute();*/
	}
	
	void ZoomOut()
	{
		if (bc.activeBuilding != null)
			bc.activeBuilding.Exit();
			
		Debug.Log ("Zooming out.");
		/*Variables.SetBoolean("zoomedIn", false);
		Room.PanToView(overView, 1f, false);
		Room.Execute();*/
	}
}
