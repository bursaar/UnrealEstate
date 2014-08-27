using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : Character {

	public Reputation myRep;
	public Assets myAssets;
	
	public float startingSuccess = 5.0f;
	public float startingIntegrity = 5.0f;
	
	public int startingBalance;
	public int startingDebt;
	public int startingCaymans;
	public int startingHiddenCash;
	
	// Use this for initialization
	void Start () {
		myRep = this.GetComponent<Reputation>();
		myRep.SetParameters(startingSuccess, startingIntegrity);
		myAssets = this.GetComponent<Assets>();
		myAssets.SetBalance(startingBalance);
		myAssets.SetDebt(startingDebt);
		SetAge(startingAge);
		AddToCast();
		CreateChild("Mitch", 14, Gender.GENDER_MALE, Orientation.ORIENTATION_STRAIGHT);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static Player GetInstance()
	{
		Player thisPlayer;
		thisPlayer = FindObjectOfType<Player>();
		return thisPlayer;
	}
	
	
}
