using UnityEngine;
using System.Collections;

public class ActionPoints : MonoBehaviour {

	int actionPoints;
	
	public int GetActionPoints()
	{
		return actionPoints;
	}
	
	public void SetActionPoints(int pNewPoints)
	{
		Debug.Log ("Action points are being set to " + pNewPoints);
		actionPoints = pNewPoints;
	}
	
	public void SubtractActionPoints(int pToTakeAway)
	{
		Debug.Log ("Action points are being reduced by " + pToTakeAway);
		actionPoints -= pToTakeAway;
		Debug.Log ("Action points are now " + actionPoints);
	}
	
	public void AddActionPoints(int pToAdd)
	{
		Debug.Log ("Action points are being increased by " + pToAdd);
		actionPoints += pToAdd;
		Debug.Log ("Action points are now " + actionPoints);
	}
}
