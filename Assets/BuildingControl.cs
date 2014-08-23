using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Fungus;

public class BuildingControl : MonoBehaviour {

	public Building[] buildingButtons;
	public Building activeBuilding;
	
	public Canvas buildingSheetCanvas;
	
	public void ShowFlaggedButtons()
	{
		for (int i = 0; i < buildingButtons.Length; i++)
		{
			if (buildingButtons[i].visible)
			{
				Room.ShowButton(buildingButtons[i].thisButton, buildingButtons[i].Examine);
			}
		}
		Room.Execute();
	}
	
	public void HideOtherButtons(Building pFeaturedBuilding)
	{
		for (int i = 0; i < buildingButtons.Length; i++)
		{
			if (buildingButtons[i] != pFeaturedBuilding)
			{
				Room.HideButton(buildingButtons[i].thisButton);
			}
		}
		Room.Execute();
	}
	
	public void ToggleCanvas()
	{
		if (activeBuilding == null)
		{
			// TODO something nicer here with lerping opacity.
			buildingSheetCanvas.enabled = false;
		}
		else
		{
			buildingSheetCanvas.enabled = true;
		}
	}
	
	void DisplayBuildingStats()
	{
		int cost = activeBuilding.cost;
		int income = activeBuilding.quarterlyIncome;
		string name = activeBuilding.name;
		
		buildingSheetCanvas.GetComponentsInChildren<Text>()[1].text = name;
		buildingSheetCanvas.GetComponentsInChildren<Text>()[2].text = "Cost: €" + cost;
		buildingSheetCanvas.GetComponentsInChildren<Text>()[3].text = "Income: €" + income;

	}
	
	public static BuildingControl GetInstance()
	{
		return FindObjectOfType<BuildingControl>();
	}
	
	void Update()
	{
		if (activeBuilding != null)
			DisplayBuildingStats();
	}
}
