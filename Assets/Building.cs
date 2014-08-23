using UnityEngine;
using System.Collections;
using Fungus;

public class Building : Room {

	public Button thisButton;
	public View thisView;
	public View overviewView;
	
	public float panDuration = 1.5f;
	public bool visible = true;
	public Canvas mainWorkingCanvas;
	public ZoomControl zc;
	public BuildingControl bc;
	
	void Start()
	{
		bc = FindObjectOfType<BuildingControl>();
		zc = FindObjectOfType<ZoomControl>();
		thisButton = this.GetComponent<Button>();
		thisView = this.GetComponentInChildren<View>();
		mainWorkingCanvas = FindObjectOfType<Canvas>();
	}
	
	public void Examine()
	{
		StopSwipePan();
		StoreView("previousView");
		Variables.SetBoolean("zoomedIn", true);
		PanToView(thisView, panDuration);
		ShowButton(thisButton, Exit);
		bc.HideOtherButtons(this);
	}
	
	void ShowExitButton()
	{
		
	}
	
	
	public void Exit()
	{
		zc.ZoomIn();
		bc.ShowFlaggedButtons();
	}
	
}
