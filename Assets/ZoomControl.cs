using UnityEngine;
using System.Collections;
using Fungus;

public class ZoomControl : MonoBehaviour {

	public View topLeftView;
	public View bottomRightView;
	public View overView;
	
	BuildingControl bc;
	
	void Start()
	{
		bc = FindObjectOfType<BuildingControl>();
	}

	public void ChangeZoom()
	{
		if (Variables.GetBoolean("zoomedIn"))
		{
			ZoomOut();
		} else {
			ZoomIn();
		}
		bc.ShowFlaggedButtons();
	}
	
	public void ZoomIn()
	{
		Debug.Log("Zooming in.");
		Variables.SetBoolean("zoomedIn", true);
		Room.StartSwipePan(topLeftView, bottomRightView, 1f);
		Room.Execute();
	}
	
	void ZoomOut()
	{
		Debug.Log ("Zooming out.");
		Variables.SetBoolean("zoomedIn", false);
		Room.PanToView(overView, 1f, false);
		Room.Execute();
	}
}
