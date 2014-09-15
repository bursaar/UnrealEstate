using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Bank : MonoBehaviour {

	public Canvas mainCanvas;
	public Canvas buildingCanvas;
	
	public Player player;
	
	public List<int> options;
	
	public int loanAmount = 10000;
	public int bribeAmount = 500;
	public int actionPointCost = 1;
	
	UnityEngine.UI.Button[] canvasButtons;

	void OnEnter()
	{
		TidyUpCanvasas();
		FindObjectOfType<ActionPoints>().SubtractActionPoints(1);
		LoadScores();
		TidyUpCanvasas();
	}
	
	void Bribe()
	{
		/*Say ("You slide a brown envelope with " + Denominator.NumbersToMoney(bribeAmount) + " across the desk.");
		Say ("The bank manager smiles widely, hops up from his desk, shuts the door and takes a seat.");
		Say ("Is that so? Well, I don't see why I can't just approve you for a massive loan right away.");
		Say ("There'll be an additioinal €" + Denominator.NumbersToMoney(loanAmount) + " in your account by the time you get back to the office.");
		Say ("You have a nice day, now!");*/
		/*Call (TransactBribe);
		Call (MoveToLevelOne);*/
	}
	
	void TransactBribe()
	{
		player.myAssets.AddToDebt(loanAmount);
		player.myAssets.AddToBalance(loanAmount);
		player.myAssets.AddToBalance(-bribeAmount);
	}

	void SmallLoan()
	{
		
	}
	
	void LargeLoan()
	{
		
	}
	
	void Leave()
	{
		/*Say ("Very well, chap. Toodlepip.");
		Call (MoveToLevelOne);*/
	}
	
	void TidyUpCanvasas()
	{
		
		canvasButtons = GetComponentsInChildren<UnityEngine.UI.Button>();
		
		for (int i = 0; i > canvasButtons.Length; i++)
		{
			canvasButtons[i].enabled = false;
		}
		
		buildingCanvas.enabled = false;
	}
	
	void RestoreCanvases()
	{
		canvasButtons = GetComponentsInChildren<UnityEngine.UI.Button>();
		
		for (int i = 0; i > canvasButtons.Length; i++)
		{
			canvasButtons[i].enabled = true;
		}
	}
	
	public void MoveToLevelOne()
	{	
		RestoreCanvases();
		options.Clear();
		mainCanvas.enabled = true;
	}
	
	void LoadScores()
	{
		// Variables.SetFloat("Success", player.myRep.GetSuccess());
		// Variables.SetFloat("Integrity", player.myRep.GetIntegrity());
	}
	
	void SetScores()
	{
		// player.myRep.SetSuccess(Variables.GetFloat ("Success"));
		// player.myRep.SetIntegrity(Variables.GetFloat ("Integrity"));
	}
}
