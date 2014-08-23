using UnityEngine;
using System.Collections;
using Fungus;

public class BuildingControl : MonoBehaviour {

	public Building[] buildingButtons;

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
	
	void Update()
	{
		// ShowFlaggedButtons();
	}
}
