using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static class Denominator {

	public static string NumbersToString(int number)
	{
	
	/*
		string stringToReturn;
		
		List<int> numerators;
		
		for (int i = 1000000000; i > 0; i /= 10)
		{
			if (number > i)
			{
				numerators.Add(number / i);
			}
		}
		
		
		stringToReturn = numerators[9] + numerators[8] + numerators[7] + numerators[6] + numerators[5] + numerators[4] + numerators[3] + numerators[2] + numerators[1] + numerators[0];
		
		return stringToReturn;
		
	*/	
		
	// Create a string here
	// Find out how big the number is.
		// Greater than 1000000000 - billions.
			// Divide by 1000000000, multiply by 100, add to the string after a decimal point.
		// Greater than 1000000 - millions.
			// Divide by 1000000, multiply by 100, add to the string after a decimal point.
		// Greater than 1000 - thousands.
			// Divide by 1000, multiply by 100, add to the string after a decimal point.
			
		// Give the right append
		
		// Return the amount (might have to return with the above magnitudes run in series.
		
		
		return "NO_VAL";
	}
}
