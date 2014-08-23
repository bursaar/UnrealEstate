﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Fungus;

public class BuildingControl : MonoBehaviour {

	public List<Building> buildingButtons;
	public Building activeBuilding;
	
	public Canvas buildingSheetCanvas;
	
	void Start()
	{
		Building[] tempSet = GameObject.FindObjectsOfType<Building>();
		
		for (int i = 0; i < tempSet.Length; i++)
		{
			buildingButtons.Add(tempSet[i]);
		}
	}
	
	public void ShowFlaggedButtons()
	{
		for (int i = 0; i < buildingButtons.Capacity; i++)
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
		for (int i = 0; i < buildingButtons.Capacity; i++)
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
		
		if (activeBuilding.owned)
		{
			buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].interactable = false;
			buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].enabled = false;
			buildingSheetCanvas.GetComponentsInChildren<Text>()[0].text = "Owned";
		} else {
			if (activeBuilding.actionPointCostToBuy > FindObjectOfType<ActionPoints>().GetActionPoints() ||
				activeBuilding.cost > FindObjectOfType<Player>().myAssets.GetBalance())
			{
				buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].interactable = false;
				buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].enabled = false;
				buildingSheetCanvas.GetComponentsInChildren<Text>()[0].text = "Buy it! (" + activeBuilding.actionPointCostToBuy + ")";
			} else {
				buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].interactable = true;
				buildingSheetCanvas.GetComponentsInChildren<UnityEngine.UI.Button>()[0].enabled = true;
				buildingSheetCanvas.GetComponentsInChildren<Text>()[0].text = "Buy it! (" + activeBuilding.actionPointCostToBuy + ")";
			}
		}
		
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
