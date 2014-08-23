using UnityEngine;
using System.Collections;
using Fungus;

public class Level01 : Room {

	public BuildingControl buildingController;

	void OnEnter()
	{
		buildingController.ShowFlaggedButtons();
	}


	// Use this for initialization
	void Start () {
	
	buildingController = FindObjectOfType<BuildingControl>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
