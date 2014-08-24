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
	public bool owned = false;
	public SpriteRenderer thisSprite;
	public int actionPointCostToBuy;
	public float prestige = 0.1f;
	
	public float panDuration = 1.5f;
	public bool visible = true;
	public Canvas mainWorkingCanvas;
	ZoomControl zc;
	BuildingControl bc;
	Player player;
	Text thisText;
	
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
				thisText.text = "OWNED\n€" + quarterlyIncome + "/q";
			} else {
				thisText.text = "€" + cost;
			}
		} else {
			thisText.enabled = false;
		}
	}
	
}
