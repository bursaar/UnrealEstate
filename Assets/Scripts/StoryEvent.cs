using UnityEngine;
using System.Collections;

public class StoryEvent : MonoBehaviour {

	int turnsRemaining;
	public string nameOfEvent;
	bool enabled = true;
	
	public void ToggleState()
	{
		Debug.Log (nameOfEvent + " state is toggled from " + enabled + " to " + !enabled);
		enabled = !enabled;
	}
	
	public void SetState(bool pSetState)
	{
		Debug.Log (nameOfEvent + " enabled state is set to " + pSetState);
		enabled = pSetState;
	}
	
	public bool GetState()
	{
		return enabled;
	}

	public void SetTurnsRemaining(int pTurnsToSet)
	{
		Debug.Log ("Setting turns remaining for " + nameOfEvent + " to " + pTurnsToSet);
		turnsRemaining = pTurnsToSet;
	}
	
	public int GetTurnsRemaining()
	{
		return turnsRemaining;
	}
	
	public void DecrementTurnsRemaining()
	{
		Debug.Log ("Decrementing turns remaining for " + nameOfEvent);
		turnsRemaining--;
	}
	
	public void IncrementTurnsRemaining()
	{
		Debug.Log ("Incrementing turns remaining for " + nameOfEvent);
		turnsRemaining++;
	}
	
	public void SubtractFromTurnsRemaining(int pToSubtract)
	{
		Debug.Log ("Subtracting " + pToSubtract + " from " + nameOfEvent + "'s turns.");
		turnsRemaining -= pToSubtract;
		Debug.Log (nameOfEvent + " now has " + turnsRemaining + " turns remaining.");
	}
	
	public void AddToTurnsRemaining(int pToAdd)
	{
		Debug.Log ("Adding " + pToAdd + " to " + nameOfEvent + "'s turns.");
		turnsRemaining += pToAdd;
		Debug.Log (nameOfEvent + " now has " + turnsRemaining + " turns remaining.");
	}
}
