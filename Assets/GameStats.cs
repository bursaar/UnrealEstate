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
	
	}
	
	void UpdateBalanceOnScreen()
	{
		// myScoreText.text = "Success: " + myRep.GetSuccess() + "  Soundness: " + myRep.GetSoundness() + "  Predictability: " + myRep.GetPredictability();
	}
	
	void UpdateScoreOnScreen()
	{
		player.UpdateScore();
	}
	
	void UpdateDebtOnScreen()
	{
	
	}
	
}
