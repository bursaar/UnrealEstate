using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Fungus;

public class Building : Room {

	public Fungus.Button thisButton;
	public View thisView;
	public View overviewView;
	public int cost;
	public string name;
	public int quarterlyIncome;
	bool owned = false;
	SpriteRenderer thisSprite;
	public int actionPointCostToBuy;
	public float prestige = 0.1f;
	
	public float panDuration = 1.5f;
	public bool visible = true;
	public Canvas mainWorkingCanvas;
	ZoomControl zc;
	BuildingControl bc;
	Player player;
	Text thisText;
	
	public void SetOwnership(bool pOwned)
	{
		Debug.Log("Ownership of " + name + " is being set from " + owned + " to " + pOwned + ".");
		owned = pOwned;
		
		if (owned)
		{
			SetOpacity(1.0f);	//TODO make compatible with Fungus.Button rendering methods.
		} else {
			SetOpacity(0.5f);
		}
	}
	
	public bool GetOwnership()
	{
		return owned;
	}
	
	void Start()
	{
		bc = FindObjectOfType<BuildingControl>();
		zc = FindObjectOfType<ZoomControl>();
		
		thisText = this.GetComponentInChildren<Text>();
		thisButton = this.GetComponent<Fungus.Button>();
		thisSprite = this.GetComponent<SpriteRenderer>();
		
		thisView = this.GetComponentInChildren<View>();
		mainWorkingCanvas = FindObjectOfType<Canvas>();
		player = Player.GetInstance();
		bc.ToggleCanvas();
		
		SetOwnership(false);
	}
	
	public void Examine()
	{
		StopSwipePan();
		StoreView("previousView");
		bc.activeBuilding = this;
		PanToView(thisView, panDuration);
		Variables.SetBoolean("zoomedIn", true);
		ShowButton(thisButton, Exit);
		bc.HideOtherButtons(this);
		bc.ToggleCanvas();
	}
	
	void SetOpacity(float pOpacity)
	{
		Color tempColour = thisSprite.color;
		tempColour.a = pOpacity;
		thisSprite.color = tempColour;
		Debug.Log ("Opacity of " + name + " is being set to " + pOpacity);
	}
	
	
	public void Exit()
	{
		if (Variables.GetBoolean("zoomedIn"))
			zc.ZoomIn();
		bc.activeBuilding = null;
		bc.ToggleCanvas();
		bc.ShowFlaggedButtons();
	}
	
	public void DrawLabel(bool pEnabled)
	{
		if (pEnabled)
		{
			thisText.enabled = true;
			
			if (owned)
			{
				thisText.text = "OWNED\n" + Denominator.NumbersToMoney(quarterlyIncome) + "/q";
			} else {
				thisText.text = Denominator.NumbersToMoney(cost);
			}
		} else {
			thisText.enabled = false;
		}
	}
	
}
