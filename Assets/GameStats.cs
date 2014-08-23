using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStats : MonoBehaviour {

	Player player;
	Text myBalanceText;
	Text myDebtText;

	// Use this for initialization
	void Start () {
		myBalanceText = GameObject.FindGameObjectWithTag("Balance").GetComponent<Text>();
		myDebtText = GameObject.FindGameObjectWithTag("Debt").GetComponent<Text>();
		player = Player.GetInstance();
	}
	
	// Update is called once per frame
	void Update () {
		
		UpdateScoreOnScreen();
		UpdateBalanceOnScreen()	;
		UpdateDebtOnScreen();
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
	
}
