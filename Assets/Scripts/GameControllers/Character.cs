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
	
	public List<Character> siblings;
	public List<Character> children;
	public List<Character> parents;
	public List<Character> friends;
	
	public void CreateChild(string pName, int pAge, Gender theirGender, Orientation theirOrientation)
	{
		GameObject childObject = (GameObject)Instantiate(characterToClone);
		childObject.transform.SetParent(this.transform);
		Character childCharacter = childObject.GetComponent<Character>();
		FindObjectOfType<TurnQueue>().AddCharactersToCast(childCharacter);
		children.Add(childCharacter);
		childCharacter.AddParent(this);
		childCharacter.entityName = pName;
		childCharacter.SetAge(pAge);
		childCharacter.myGender = theirGender;
		childCharacter.myOrientation = theirOrientation;
	}
	
	public void AddParent(Character pParent)
	{
		parents.Add(pParent);
	}
	
	public void AddFriend(Character friend)
	{
		friend.friends.Add(this);
		this.friends.Add(friend);
		Debug.Log ("Now " + this.entityName + " and " + friend.entityName + " are friends!");
	}
	
	public void SetAge(int pAge)
	{
		Debug.Log ("Setting age for " + entityName + " to " + pAge);
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
	
	public void SetBirthdayQuarter(int pQuarter)
	{
		if (pQuarter <= 4)
		{
			Debug.Log ("Setting " + entityName + "'s birthday quarter to " + pQuarter);
			quarterCounter = pQuarter;
		} else {
			Debug.Log ("Quarter value supplied to " + entityName + "'s SetBirthdayQuarter method is out of range.");
		}
	}
	
	public void IncrementAge()
	{
		if (quarterCounter > 0)
		{
			Debug.Log ("Not birthday time for " + entityName + " yet, counting down. " + quarterCounter + " quarters left.");
			quarterCounter--;
		} else {
			Debug.Log ("Birthfday time for " + entityName + "! Going from " + age + " to " + (age + 1) + ".");
			age++;
			quarterCounter = 4;
		}
	}
	
	
}
