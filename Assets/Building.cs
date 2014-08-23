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
	
	void Start()
	{
		thisButton = this.GetComponent<Button>();
		thisView = this.GetComponentInChildren<View>();
		mainWorkingCanvas = FindObjectOfType<Canvas>();
	}
	
	public void Examine()
	{
		StopSwipePan();
		StoreView("previousView");
		PanToView(thisView, panDuration);
	}
	
	void ShowExitButton()
	{
		
	}
	
	
	public void Exit()
	{
	
	}
	
}
