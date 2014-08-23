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
		
	}
	
	
	
	public void NextTurn()
	{
		FindObjectOfType<Player>().myAssets.AddToBalance(TotalQuarterlyIncome());
		FindObjectOfType<ActionPoints>().AddActionPoints(actionPointsToGive);
		FindObjectOfType<Date>().IncrementQuarter();
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
