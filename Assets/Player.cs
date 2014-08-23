using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	Reputation myRep;
	Text scoreText;
	
	// Use this for initialization
	void Start () {
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		myRep = this.GetComponent<Reputation>();
		myRep.SetParameters(0.0f, 0.0f, 0.0f);
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
