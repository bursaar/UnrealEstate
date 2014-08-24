using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;

public class Bank : Room {

	public Canvas mainCanvas;
	public Canvas bankCanvas;
	public Canvas buildingCanvas;
	
	public Room levelOne;
	
	public Player player;
	
	public List<int> options;
	
	public enum Options {OPTION_ONE = 0, OPTION_TWO = 1, OPTION_THREE = 2, OPTION_FOUR = 3, OPTION_FIVE = 4, OPTION_SIX = 5, OPTION_SEVEN = 6, OPTION_EIGHT = 7};
	public enum Mode {MODE_BORROWING = 0, MODE_BRIBING = 1};
	
	public Options selectedOption;
	public Mode mode;

	void OnEnter()
	{
		TidyUpCanvasas();
		SetCharacter("BankManager");
		Say ("Welcome to Anglo Irish Bank, how can we help you today?");
		SetCharacter("You");
		Say ("Hi there! I'd like to get a loan please. Quite a big one, if you don't mind.");
		Call (SetToBorrow);
		SetCharacter("BankManager");
		Say ("Sure thing, no worries. How much did you want?");
		SetCharacter("You");
		Call (PopulateOptions);
		AddOption ("€", OptionOne);
		AddOption ("€", OptionTwo);
		AddOption ("€", OptionThree);
		AddOption ("€", OptionFour);
		Say ("Could I have...");
		Call (MoveToLevelOne);
	}
	
	void SetToBorrow()
	{
		mode = Mode.MODE_BORROWING;
	}
	
	void PopulateOptions()
	{
		options.Add(100000);
		options.Add(250000);
		options.Add(500000);
		options.Add(750000);
	}
	
	void OptionOne()
	{
		selectedOption = Options.OPTION_ONE;
		Call (ExecuteChoice);
	}
	
	void OptionTwo()
	{
		selectedOption = Options.OPTION_TWO;
		Call (ExecuteChoice);
	}
	
	void OptionThree()
	{
		selectedOption = Options.OPTION_THREE;
		Call (ExecuteChoice);
	}
	
	void OptionFour()
	{
		selectedOption = Options.OPTION_FOUR;
		Call (ExecuteChoice);
	}
	
	void OptionFive()
	{
		selectedOption = Options.OPTION_FIVE;
		Call (ExecuteChoice);
	}
	
	void OptionSix()
	{
		selectedOption = Options.OPTION_SIX;
		Call (ExecuteChoice);
	}
	
	void ExecuteChoice()
	{
		if (mode == Mode.MODE_BORROWING)
		{
			player.myAssets.TakeOutLoan(options[(int) selectedOption]);
		}
	}
	
	void TidyUpCanvasas()
	{
		bankCanvas.enabled = true;
		mainCanvas.enabled = false;
		buildingCanvas.enabled = false;
	}
	
	public void MoveToLevelOne()
	{
		Clear ();
		options.Clear();
		MoveToRoom(levelOne);
		Execute ();
		bankCanvas.enabled = false;
		mainCanvas.enabled = true;
	}
}
