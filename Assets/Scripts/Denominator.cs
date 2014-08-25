﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

static class Denominator {

	static string NumbersToString(int pNumber)
	{
	
		string newString = "NO_VAL";
	
		if (pNumber > 1000)
		{
			float newNumber = pNumber / 1000;
			newString = newNumber.ToString("N2");
			return newString;
		}
		
		if (pNumber < 1000)
		{
			newString = pNumber + "k";
			return newString;
		}
		
		return "NO_VAL";
	}
	
	// FIXME Doesn't show complete decimal places!
	public static string NumbersToMoney(int pNumber)
	{
		string stringToReturn = "€" + NumbersToString(pNumber);
		return stringToReturn;
		
	}
	
	static string SeparatedByMagnitudeVersionTwo(int pNumber)
	{
		string stringToReturn = "NO_VAL";
		
		
		
		return stringToReturn;
	}
	
	static string SeparateByMagnitudeVersionOne(int pNumber)
	{
		// TODO look up a more precise way to make these calculations!
		int newNumberMillions = (pNumber / 1000);
		int newNumberHundredThousands = ((pNumber - (newNumberMillions * 1000)) / 100);
		int newNumberTenThousands = ((pNumber - (newNumberHundredThousands * 100)) / 10);
		string newString = newNumberMillions + "." + newNumberHundredThousands + newNumberTenThousands + "m";
		return newString;
	}
}
