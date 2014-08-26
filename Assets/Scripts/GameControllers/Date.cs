using UnityEngine;
using System.Collections;

public class Date : MonoBehaviour {

	public int startingQuarter = 1;
	public int startingYear = 1995;

	int quarter = 1;
	int year = 1995;
	
	// TODO think about starting this a year or so before the boom so we see things change.
	// TODO think about letting this go a year into the boom befor being NAMA'd
	
	public int GetQuarter()
	{
		return quarter;
	}
	
	public int GetYear()
	{
		return year;
	}
	
	public void SetDate(int pQuarter, int pYear)
	{
		Debug.Log ("The date is being set manually. The old date is Q" + quarter + " of " + year + ".");
		quarter = pQuarter;
		year = pYear;
		Debug.Log ("The new date is Q" + quarter + " of " + year + ".");
	}
	
	public void InitialiseWithDefaultValues()
	{
		Debug.Log ("The date is being set with initial values. The quarter is being set to " + startingQuarter + " and the year is being set to " + startingYear + ".");
		quarter = startingQuarter;
		year = startingYear;
	}
	
	public void IncrementQuarter()
	{
		Debug.Log ("The quarter is going to be incremented by one. It was Q" + quarter + " of " + year + ".");
		if (quarter < 4)
		{
			quarter++;
		} else {
			year++;
			quarter = 1;
		}
		Debug.Log("It's now Q" + quarter + " of " + year + ".");
	}
	
}
