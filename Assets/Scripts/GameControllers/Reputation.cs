using UnityEngine;
using System.Collections;

public class Reputation : MonoBehaviour {

	float success = 5.0f;				// Out of 10
	float integrity = 5.0f;				// Out of 10

	int repDecayCounter = 4;
	public float repDecayRate = 0.01f;
	
	public void SetParameters(float pSuccess, float pIntegrity)
	{
		Debug.Log ("Your parameters are being set. Before being set, they are: ");
		Debug.Log ("Success: " + success);
		Debug.Log ("Integrity: " + integrity);
		
		success = pSuccess;
		integrity = pIntegrity;
		
		Debug.Log ("Now that they have been set, they are: ");
		Debug.Log ("Success: " + success);
		Debug.Log ("Integrity: " + integrity);
	}
	
	public void SetSuccess(float pSuccess)
	{
		Debug.Log ("Success is being set to " + pSuccess);
		success = pSuccess;
	}
	
	// This can include negative values.
	public void AddSuccess(float pSuccessToAdd)
	{
		success += pSuccessToAdd;
		Debug.Log ("Apparent success has been increased by " + pSuccessToAdd + ". Your current success is now " + success);
	}
	
	public float GetSuccess()
	{
		return success;
	}
	
	public void SetIntegrity(float pIntegrity)
	{
		Debug.Log ("Integrity is being set to " + pIntegrity);
		integrity = pIntegrity;
	}
	
	public void AddIntegrity(float pIntegrityToAdd)
	{
		integrity += pIntegrityToAdd;
		Debug.Log ("Your integrity has been increased by " + pIntegrityToAdd + ". Your current integrity is now " + integrity);
	}
	
	public float GetIntegrity()
	{
		return integrity;
	}
	
	public bool IsRepDecaying()
	{
		repDecayCounter--;
		
		if (repDecayCounter <= 0)
		{
			return true;
		} else {
			return false;
		}
		
		
	}
	
	// This adds turns to the counter to ward off the decaying phase.
	public void PostponeDecay(int turnsToAdd)
	{
		if (repDecayCounter < 0)
			repDecayCounter = 0;
		
		Debug.Log ("Added " + turnsToAdd + " to reputation decay counter.");
		repDecayCounter += turnsToAdd;
		Debug.Log("Reputation decay counter is now up to " + repDecayCounter);
	}
	
	public void Decay()
	{
		success -= repDecayRate;
	}
	
}
