using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Assets : MonoBehaviour {

	int balance;
	int debt;
	int caymans;
	int hiddenCash;
	public List<Building> ownedProperties;
	BuildingControl bc;
	
	void Start()
	{
		bc = BuildingControl.GetInstance();
	}

	public int GetCaymans()
	{
		return caymans;
	}
	
	public int GetHiddenCash()
	{
		return hiddenCash;
	}

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
	
	public void SetCaymans(int pCaymans)
	{
		Debug.Log ("Caymans value being set from " + caymans + " to " + pCaymans + ".");
		caymans = pCaymans;
	}
	
	public void SetHiddenCash(int pHiddenCash)
	{
		Debug.Log ("Hidden cash value being set from " + hiddenCash + " to " + pHiddenCash + ".");
		hiddenCash = pHiddenCash;
	}
	
	public void SetDebt(int pDebt)
	{
		Debug.Log ("Setting debt to " + pDebt);
		debt = pDebt;
	}
	
	public void AddToCaymens(int pToAdd)
	{
		Debug.Log ("Adding €" + Denominator.NumbersToMoney(pToAdd) + " to Caymans.");
		caymans += pToAdd;
		Debug.Log ("Caymans is now €" + Denominator.NumbersToMoney(caymans));
	}
	
	public void AddToHiddenCash(int pToAdd)
	{
		Debug.Log ("Adding €" + Denominator.NumbersToMoney(pToAdd) + " to Hidden Cash.");
		caymans += pToAdd;
		Debug.Log ("Hidden Cash is now €" + Denominator.NumbersToMoney(hiddenCash));
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
	
	public void BuyProperty()
	{
		bc.activeBuilding.SetOwnership(true);
		ownedProperties.Add(bc.activeBuilding);		
		AddToBalance(-bc.activeBuilding.cost);
		FindObjectOfType<ActionPoints>().SubtractActionPoints(bc.activeBuilding.actionPointCostToBuy);	
		FindObjectOfType<Reputation>().AddSuccess(bc.activeBuilding.prestige);
	}
}
