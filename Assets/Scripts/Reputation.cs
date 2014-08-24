using UnityEngine;
using System.Collections;

public class Reputation : MonoBehaviour {

	float success = 5.0f;				// Out of 10
	float integrity = 5.0f;				// Out of 10
	float predictability = 5.0f;		// Out of 10
	int repDecayCounter = 4;
	public float repDecayRate = 0.01f;
	
	public void SetParameters(float pSuccess, float pIntegrity, float pPredictability)
	{
		Debug.Log ("Your parameters are being set. Before being set, they are: ");
		Debug.Log ("Success: " + success);
		Debug.Log ("Integrity: " + integrity);
		Debug.Log ("Predictability " + predictability);
		
		success = pSuccess;
		integrity = pIntegrity;
		predictability = pPredictability;
		
		Debug.Log ("Now that they have been set, they are: ");
		Debug.Log ("Success: " + success);
		Debug.Log ("Integrity: " + integrity);
		Debug.Log ("Predictability " + predictability);
	}
	
	/*
	public float[] GetParameters()
	{
		float[] returnData = new float[3];	// This will need to be changed if the number of parameters changes.
		
		returnData[0] = success;
		returnData[1] = integrity;
		returnData[2] = predictability;
		
		// Debug.Log ("Your parameters are being passed. They are as follows:");
		// Debug.Log ("Success is field 0, at " + returnData[0]);
		// Debug.Log ("Integrity is field 1, at " + returnData[1]);
		// Debug.Log ("Predictability is field 2, at " + returnData[2]);
				
		return returnData;
	}
	*/
	
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
		// Debug.Log ("Your current level of success is " + success);
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
		// Debug.Log ("Your current level of integrity is " + integrity);
		return integrity;
	}
	
	public void SetPredictability(float pPredictability)
	{
		Debug.Log ("Predictability is being set to " + predictability);
		predictability = pPredictability;
	}
	
	public void AddPredictability(float pPredictabilityToAdd)
	{
		predictability += pPredictabilityToAdd;
		Debug.Log ("Your predictability has been increased by " + pPredictabilityToAdd + ". Your current predictability is now " + predictability);
	}
	
	public float GetPredictability()
	{
		// Debug.Log ("Your current level of predictability is " + predictability);
		return predictability;
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
