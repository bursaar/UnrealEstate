using UnityEngine;
using System.Collections;

public class StoryEvent1 : MonoBehaviour {

	int turnsRemaining;
	public string eventName;
	bool enabled = true;
	
	
	
	
	
	// Setters and getters
	
	public bool GetState()
	{
		return enabled;
	}
	
	public void SetState(bool pState)
	{
		enabled = pState;
	}
	
	public void ToggleState()
	{
		enabled = !enabled;
	}
	
	public void DecrementTurnsRemaining()
	{
		turnsRemaining--;
	}
	
	public void IncrementTurnsRemaining()
	{
		turnsRemaining++;
	}
	
	public void SetTurnsRemaining(int pToSet)
	{
		turnsRemaining = pToSet;
	}
	
	public void AddTurnsRemaining(int pToAdd)
	{
		turnsRemaining += pToAdd;
	}
	
	public void SubtractTurnsRemaining(int pToSubtract)
	{
		turnsRemaining -= pToSubtract;
	}
	
	public int GetTurnsRemaining()
	{
		return turnsRemaining;
	}
	
}
