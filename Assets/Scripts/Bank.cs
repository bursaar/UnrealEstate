using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using Fungus;

public class Bank : Room {

	public Canvas mainCanvas;
	public Canvas buildingCanvas;
	
	public Room levelOne;
	
	public Player player;
	
	public List<int> options;
	
	public int loanAmount = 10000;
	public int bribeAmount = 500;
	
	UnityEngine.UI.Button[] canvasButtons;

	void OnEnter()
	{
		TidyUpCanvasas();
		FindObjectOfType<ActionPoints>().SubtractActionPoints(1);
		LoadScores();
		TidyUpCanvasas();
		SetCharacter("BankManager");
		Say ("Welcome to Anglo Irish Bank, how can we help you today?");
		SetCharacter("You");
		Say ("Hi there! I'd like to get a loan please.");
		SetCharacter("BankManager");
		Say ("Sure thing, no worries. How much are we talking about?");
		SetCharacter("You");
		AddOption("...to look after my friends.", Bribe);
		AddOption ("...just a small loan.", SmallLoan);
		AddOption ("...a vast amount of dosh.", LargeLoan);
		AddOption ("...to leave.", Leave);
		Say ("I'd like...");
	}
	
	void Bribe()
	{
		SetCharacter ("Narrator");
		Say ("You slide a brown envelope with €" + bribeAmount + " across the desk.");
		Say ("The bank manager smiles widely, hops up from his desk, shuts the door and takes a seat.");
		SetCharacter("BankManager");
		Say ("Is that so? Well, I don't see why I can't just approve you for a massive loan right away.");
		Say ("There'll be an additioinal €" + loanAmount + " in your account by the time you get back to the office.");
		Say ("You have a nice day, now!");
		Call (TransactBribe);
		Call (MoveToLevelOne);
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
		SetCharacter("BankManager");
		Say ("Very well, chap. Toodlepip.");
		Call (MoveToLevelOne);
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
		Clear ();
		options.Clear();
		MoveToRoom(levelOne);
		Execute ();
		mainCanvas.enabled = true;
	}
	
	void LoadScores()
	{
		Variables.SetFloat("Success", player.myRep.GetSuccess());
		Variables.SetFloat("Integrity", player.myRep.GetIntegrity());
	}
	
	void SetScores()
	{
		player.myRep.SetSuccess(Variables.GetFloat ("Success"));
		player.myRep.SetIntegrity(Variables.GetFloat ("Integrity"));
	}
}
