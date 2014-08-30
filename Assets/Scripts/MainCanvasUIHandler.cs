using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainCanvasUIHandler : MonoBehaviour {

	public Canvas mainCanvas;
	public Button bankButton;
	Bank bankObject;

	public void DrawBankButton()
	{
		bankButton.GetComponentInChildren<Text>().text = "Bank (-" + bankObject.actionPointCost + ")";
		
		if (bankObject.actionPointCost > FindObjectOfType<ActionPoints>().GetActionPoints())
		{
			// If the cost is higher than the available:
			bankButton.interactable = false;
		} else {
			// If the cost is equal to or less than the available:
			bankButton.interactable = true;
		}
		
	}
		

	// Use this for initialization
	void Start () {
		bankObject = FindObjectOfType<Bank>();
	}
	
	// Update is called once per frame
	void Update () {
		DrawBankButton();
	}
}
