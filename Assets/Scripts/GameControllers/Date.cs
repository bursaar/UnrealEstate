using UnityEngine;
using System.Collections;

public class Date : MonoBehaviour {

	int quarter = 1;
	int year = 1995;
	
	// TODO think about starting this a year or so before the boom so we see things change.
	
	public int GetQuarter()
	{
		return quarter;
	}
	
	public int GetYear()
	{
		return year;
	}
	
	public void InitialiseWithDefaultValues()
	{
		quarter = 1;
		year = 1995;
	}
	
	public void IncrementQuarter()
	{
		if (quarter < 4)
		{
			quarter++;
		} else {
			year++;
			quarter = 1;
		}
	}
	
}
