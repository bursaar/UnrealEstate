using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStats : MonoBehaviour {

	Reputation myRep;
	Text myScoreText;

	// Use this for initialization
	void Start () {
		GameObject tempObj = GameObject.FindGameObjectWithTag("Score");
		myScoreText = tempObj.GetComponent<Text>();
		myRep = new Reputation();
		myRep.SetParameters(0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
		UpdateScoreOnScreen();
	
	}
	
	void UpdateScoreOnScreen()
	{
		myScoreText.text = "Success: " + myRep.GetSuccess() + "  Soundness: " + myRep.GetSoundness() + "  Predictability: " + myRep.GetPredictability();
	}
}
