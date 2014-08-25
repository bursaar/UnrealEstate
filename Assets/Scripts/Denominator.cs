using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static class Denominator {

	static string NumbersToString(int number)
	{
		if (number > 1000)
		{
			long newNumber = number / 1000;
			string newString = newNumber.ToString("#.00") + "m";
			return newString;
		}
		
		if (number < 1000)
		{
			string newString = number.ToString() + "k";
			return newString;
		}
		
		return "NO_VAL";
	}
	
	// FIXME Doesn't show complete decimal places!
	public static string NumbersToMoney(int number)
	{
		string stringToReturn = "€" + NumbersToString(number);
		return stringToReturn;
		
	}
}
