using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStats : MonoBehaviour {

	Player player;
	Text scoreText;
	
	Text myBalanceText;
	Text myDebtText;
	
	Date gameDate;
	Text myDateText;
	
	ActionPoints actionPoints;
	Text myActionPointsText;
	
	TurnQueue turnQueue;
	Text myQuarterlyIncome;
	
	public Text nextTurnButtonText;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		myBalanceText = GameObject.FindGameObjectWithTag("Balance").GetComponent<Text>();
		myDebtText = GameObject.FindGameObjectWithTag("Debt").GetComponent<Text>();
		myDateText = GameObject.FindGameObjectWithTag("Date").GetComponent<Text>();
		myActionPointsText = GameObject.FindGameObjectWithTag("ActionPoints").GetComponent<Text>();
		myQuarterlyIncome = GameObject.FindGameObjectWithTag("QuarterlyIncome").GetComponent<Text>();
		player = Player.GetInstance();
		actionPoints = GameObject.FindObjectOfType<ActionPoints>();
		gameDate = GameObject.FindObjectOfType<Date>();
		turnQueue = GameObject.FindObjectOfType<TurnQueue>();
		gameDate.InitialiseWithDefaultValues();
		actionPoints.SetActionPoints(2);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateNextTurnButton();
		UpdateScoreOnScreen();
		UpdateBalanceOnScreen()	;
		UpdateDebtOnScreen();
		UpdateDateOnScreen();
		UpdateActionPointsOnScreen();
		UpdateIncomeOnScreen();
	}
	
	void UpdateBalanceOnScreen()
	{
		myBalanceText.text = "Bal: €" + player.myAssets.GetBalance();
	}
	
	void UpdateDebtOnScreen()
	{
		myDebtText.text = "Debt: €" + player.myAssets.GetDebt();
	}
	
	void UpdateIncomeOnScreen()
	{
		myQuarterlyIncome.text = "Income / Quarter: € " + turnQueue.TotalQuarterlyIncome();
	}
	
	void UpdateDateOnScreen()
	{
		string num = " ";
		switch (gameDate.GetQuarter())
		{
		case 1:
			num = "st";
			break;
		case 2:
			num = "nd";
			break;
		case 3:
			num = "rd";
			break;
		case 4:
			num = "th";
			break;
		}
		myDateText.text = gameDate.GetQuarter() + num + " Quarter of " + gameDate.GetYear();
	}
	
	void UpdateActionPointsOnScreen()
	{
		myActionPointsText.text = "Action Points: " + actionPoints.GetActionPoints();
	}
	
	public void UpdateScoreOnScreen()
	{
		scoreText.text = "Success: " + player.myRep.GetSuccess() + "  Integrity: " + player.myRep.GetIntegrity();
	}
	
	void UpdateNextTurnButton()
	{
		nextTurnButtonText.text = "Next Turn (+" + turnQueue.actionPointsToGive + ")";
	}
	
}
