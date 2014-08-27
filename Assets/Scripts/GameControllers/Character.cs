using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : StoryEntity {

	public enum Gender 	{
						GENDER_MALE,
						GENDER_FEMALE
						}
						
	public Gender myGender = Gender.GENDER_MALE;
	
	public int startingAge;
	int age;
	int quarterCounter = 4;		//TODO create sets, gets and modifiers.
	
	public enum Orientation {
							ORIENTATION_STRAIGHT,
							ORIENTATION_GAY,
							ORIENTATION_BISEXUAL,
							ORIENTATION_UNKNOWN
							}
							
	public Orientation myOrientation = Orientation.ORIENTATION_STRAIGHT;
	
	public GameObject characterToClone;
	
	List<Character> siblings;
	List<Character> children;
	List<Character> parents;
	List<Character> friends;
	
	public void CreateChild(string pName, int pAge, Gender theirGender, Orientation theirOrientation)
	{
		GameObject childObject = Instantiate(characterToClone);
		childObject.transform.SetParent = this;
	}
	
	public void AddFriend(Character friend)
	{
		friend.friends.Add(this);
		this.friends.Add(friend);
		Debug.Log ("Now " + this.name + " and " + friend.name + " are friends!");
	}
	
	public void SetAge(int pAge)
	{
		age = pAge;
	}
	
	public int GetAge()
	{
		return age;
	}
	
	public void AddToCast()
	{
		FindObjectOfType<TurnQueue>().AddCharactersToCast(this);
	}
	
	public void IncrementAge()
	{
		if (quarterCounter > 0)
		{
			Debug.Log ("Not birthday time for " + name + " yet, counting down. " + quarterCounter + " quarters left.");
			quarterCounter--;
		} else {
			Debug.Log ("Birthfday time for " + name + "! Going from " + age + " to " + (age + 1) + ".");
			age++;
			quarterCounter = 4;
		}
	}
	
	
}
