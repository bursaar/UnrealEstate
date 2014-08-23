using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public Reputation myRep;
	public Assets myAssets;
	Text scoreText;
	
	// Use this for initialization
	void Start () {
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		myRep = this.GetComponent<Reputation>();
		myRep.SetParameters(0.0f, 0.0f, 0.0f);
		myAssets = this.GetComponent<Assets>();
		myAssets.SetBalance(3000000);
		myAssets.SetDebt(-500);
	}
	
	// Update is called once per frame
	void Update () {
		UpdateScore();
	}
	
	public void UpdateScore()
	{
		scoreText.text = "Success: " + myRep.GetSuccess() + "  Soundness: " + myRep.GetSoundness() + "  Predictability: " + myRep.GetPredictability();
	}
	
	public static Player GetInstance()
	{
		Player thisPlayer;
		thisPlayer = FindObjectOfType<Player>();
		return thisPlayer;
	}
	
	
}
