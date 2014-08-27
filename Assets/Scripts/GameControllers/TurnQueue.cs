using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnQueue : MonoBehaviour {

	// Take in actions, execute them and then wait.
	
	Date gameDate;
	ActionPoints actionPoints;
	GameStats stats;
	Player player;
	public int actionPointsToGive = 2;
	public List<StoryEvent> storyEventQueue;
	public List<Character> castOfCharacters;
	
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
		IncrementAges();
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
	
	void IncrementAges()
	{
		foreach(Character tmpChar in castOfCharacters)
		{
			tmpChar.IncrementAge();
		}
	}
	
	public void AddEventToQueue(StoryEvent pEventToAdd)
	{
		Debug.Log ("Adding " + pEventToAdd.nameOfEvent + " to the event queue.");
		storyEventQueue.Add (pEventToAdd);
	}
	
	public void AddCharactersToCast(Character pCharacter)
	{
		Debug.Log ("Adding " + pCharacter.name + " to the cast of characters.");
		castOfCharacters.Add (pCharacter);
	}
	
	void DecrementTurns()
	{
		foreach(StoryEvent tmpEvent in storyEventQueue)
		{
			tmpEvent.DecrementTurnsRemaining();
		}
	}
	
}
