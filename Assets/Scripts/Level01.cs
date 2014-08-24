using UnityEngine;
using System.Collections;
using Fungus;

public class Level01 : Room {

	public BuildingControl buildingController;
	public Room bank;

	void OnEnter()
	{
		buildingController.ShowFlaggedButtons();
	}

	
	public void MoveToBank()
	{
		// StoreView("wentToBank");
		MoveToRoom(bank);
		Execute();
	}
	
	// Use this for initialization
	void Start () {
	
	buildingController = FindObjectOfType<BuildingControl>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
