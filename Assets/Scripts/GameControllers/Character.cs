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
	
	public enum Orientation {
							ORIENTATION_STRAIGHT,
							ORIENTATION_GAY,
							ORIENTATION_BISEXUAL,
							ORIENTATION_UNKNOWN
							}
							
	public Orientation myOrientation = Orientation.ORIENTATION_STRAIGHT;
	
	
	void Start()
	{
		SetAge(startingAge);
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
	
	
}
