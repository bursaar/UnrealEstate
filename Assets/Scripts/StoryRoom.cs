using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;

public class StoryRoom : MonoBehaviour {

	public string storyTitle;
	public Character playerChar;
	public Character otherParty;
	public Dialog thisEventDialog;
	
	public enum StoryType 	{
							STORY_NEGOTIATION
							}
	
	public void SetAntagonist(Character pAntagonist)
	{
		otherParty = pAntagonist;
	}
	
	public Character GetAntagonist()
	{
		return otherParty;
	}
	
	void OnEnter()
	{
		/*SetDialog(thisEventDialog);
		SetCharacter(otherParty.entityName);*/
		// Say ("Hello there, " + playerChar.entityName + ".");
		/*SetCharacter(playerChar.entityName);*/
		// Say ("Hi! You must be " + otherParty.entityName + ".");
	}
	
	public bool RollForSuccess(float pTarget, float pModifier)
	{
		float roll = Random.Range(1, 20) + pModifier;
		if (roll >= pTarget)
		{
			Debug.Log ("The roll was successful!");
			return true;
		} else {
			Debug.Log ("The roll was not successful. Sorry.");
			return false;
		}
	}
	
}
