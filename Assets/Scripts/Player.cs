using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {

	public Reputation myRep;
	public Assets myAssets;
	
	public int startingBalance;
	public int startingDebt;
	
	// Use this for initialization
	void Start () {
		myRep = this.GetComponent<Reputation>();
		myRep.SetParameters(0.0f, 0.0f, 0.0f);
		myAssets = this.GetComponent<Assets>();
		myAssets.SetBalance(startingBalance);
		myAssets.SetDebt(startingDebt);
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
