using UnityEngine;
using System.Collections;

public class TurnQueue : MonoBehaviour {

	// Take in actions, execute them and then wait.
	
	Date gameDate;
	ActionPoints actionPoints;
	GameStats stats;
	Player player;
	public int actionPointsToGive = 2;
	
	
	void Start()
	{
		player = FindObjectOfType<Player>();
		actionPoints = FindObjectOfType<ActionPoints>();
		gameDate = FindObjectOfType<Date>();
	}
	
	
	
	public void NextTurn()
	{
		player.myAssets.AddToBalance(TotalQuarterlyIncome());
		actionPoints.AddActionPoints(actionPointsToGive);
		gameDate.IncrementQuarter();
		ReputationOperations();
		
	}
	
	void ReputationOperations()
	{

		if (player.myRep.IsRepDecaying())
		{
			player.myRep.Decay();
		}
	}
	
	public int TotalQuarterlyIncome()
	{
		int indexCap = FindObjectOfType<Player>().myAssets.ownedProperties.Count;
		
		int total = 0;
		
		for (int i = 0; i < indexCap; i++)
		{
			total += FindObjectOfType<Player>().myAssets.ownedProperties[i].quarterlyIncome;
		}
		
		return total;
	}
	
	
	
	
	
}
