using UnityEngine;
using System.Collections;

public class Assets : MonoBehaviour {

	int balance;
	int debt;
	Building[] ownedProperties;

	public int GetBalance()
	{
		return balance;
	}
	
	public int GetDebt()
	{
		return debt;
	}
	
	public void SetBalance(int pBal)
	{
		Debug.Log ("Setting balance to " + pBal);
		balance = pBal;
	}
	
	public void SetDebt(int pDebt)
	{
		Debug.Log ("Setting debt to " + pDebt);
		debt = pDebt;
	}
	
	public void AddToBalance(int pToAdd)
	{
		Debug.Log ("Adding €" + pToAdd + " to balance.");
		balance += pToAdd;
		Debug.Log ("Balance is now €" + balance);
	}
	
	public void AddToDebt(int pToAdd)
	{
		Debug.Log ("Adding €" + pToAdd + " to debt.");
		debt += pToAdd;
		Debug.Log ("Debt is now €" + debt);
	}
	
	public void TakeOutLoan(int pBorrowed)
	{
		Debug.Log ("Taking out a loan of €" + pBorrowed);
		debt -= pBorrowed;
		balance += pBorrowed;
		Debug.Log ("The balance is now €" + balance + " and the debt is €" + debt);
	}
}
