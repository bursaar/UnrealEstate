using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStats : MonoBehaviour {

	Player player;
	
	Text myBalanceText;
	Text myDebtText;
	
	Date gameDate;
	Text myDateText;
	
	ActionPoints actionPoints;
	Text myActionPointsText;

	// Use this for initialization
	void Start () {
		myBalanceText = GameObject.FindGameObjectWithTag("Balance").GetComponent<Text>();
		myDebtText = GameObject.FindGameObjectWithTag("Debt").GetComponent<Text>();
		myDateText = GameObject.FindGameObjectWithTag("Date").GetComponent<Text>();
		myActionPointsText = GameObject.FindGameObjectWithTag("ActionPoints").GetComponent<Text>();
		player = Player.GetInstance();
		actionPoints = GameObject.FindObjectOfType<ActionPoints>();
		gameDate = GameObject.FindObjectOfType<Date>();
		gameDate.InitialiseWithDefaultValues();
		actionPoints.SetActionPoints(2);
	}
	
	// Update is called once per frame
	void Update () {
		
		UpdateScoreOnScreen();
		UpdateBalanceOnScreen()	;
		UpdateDebtOnScreen();
		UpdateDateOnScreen();
		UpdateActionPointsOnScreen();
	}
	
	void UpdateBalanceOnScreen()
	{
		myBalanceText.text = "Bal: €" + player.myAssets.GetBalance();
	}
	
	void UpdateScoreOnScreen()
	{
		player.UpdateScore();
	}
	
	void UpdateDebtOnScreen()
	{
		myDebtText.text = "Debt: €" + player.myAssets.GetDebt();
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
	
}
