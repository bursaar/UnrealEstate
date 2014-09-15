using UnityEngine;
using System.Collections;

public class StoryNegotiation : StoryRoom {

	public enum NegotiationType {
								STORY_NEGOTIATION_TENANT,
								STORY_NEGOTIATION_PROPERTYOWNER,
								STORY_NEGOTIATION_BANKMANAGER,
								STORY_NEGOTIATION_POLITICIAN,
								STORY_NEGOTIATION_CHILD
								}
								
	public NegotiationType thisNegotiation;
	
	int theirGoal;
	int theirInitialOffer;
	float rollTarget;
	
	
	public void SetTheirGoal (int pNewGoal)
	{
		Debug.Log ("Setting the goal for " + otherParty.entityName + " to " + pNewGoal);
		theirGoal = pNewGoal;
	}
	
	public int GetTheirGoal ()
	{
		return theirGoal;
	}
	
	public void SetTheirInitialOffer(int pStartingOffer)
	{
		Debug.Log ("Setting the initial offer for " + otherParty.entityName + " to " + pStartingOffer);
		theirInitialOffer = pStartingOffer;
	}
	
	public int GetTheirInitialOffer()
	{
		return theirInitialOffer;
	}
	
	
	void OnEnter()
	{
		switch (thisNegotiation)
		{
		case NegotiationType.STORY_NEGOTIATION_BANKMANAGER:
			// Call (BankManagerNegotiation);
			break;
		case NegotiationType.STORY_NEGOTIATION_CHILD:
			// Call (ChildNegotation);
			break;
		case NegotiationType.STORY_NEGOTIATION_POLITICIAN:
			// Call (PoliticianNegotation);
			break;
		case NegotiationType.STORY_NEGOTIATION_PROPERTYOWNER:
			// Call (PropertyOwnerNegotiation);
			break;
		case NegotiationType.STORY_NEGOTIATION_TENANT:
			// Call (TenancyNegotiation);
			break;
		}
	}
	
	
	void TenancyNegotiation()
	{
		rollTarget = 7.0f;
		/*SetCharacter(otherParty.entityName);
		Say ("Oh, hi " + playerChar.MrOrMs() + " " + playerChar.entityName);
		Say ("What can I do for you?");
		SetCharacter(playerChar.entityName);
		Say ("I'd like to discuss your rent.");
		SetCharacter(otherParty.entityName);
		Say ("It was definitely paid on time, we were just looking at the account this morning!");
		SetCharacter(playerChar.entityName);
		Say ("Ha, yes. That's not the issue I'm afraid. I'm going to have to increase your rent.");
		SetCharacter(otherParty.entityName);
		Say ("What? When?");
		SetCharacter(playerChar.entityName);
		Say ("Effective immediately, of course.");
		SetCharacter(otherParty.entityName);
		Say ("But you can't do that, we've only been here a few months!");
		SetCharacter(playerChar.entityName);
		Say ("I know, but looking at the market, I have no choice.");
		SetCharacter(otherParty.entityName);
		Say ("No, I mean it's illegal. You can't do this.");
		SetCharacter(playerChar.entityName);
		AddOption("Aggressive", AggressiveTenancy);
		AddOption("Manipulative", ManipulativeTenancy);
		Say ("Respond:");*/
	}
	
	void AggressiveTenancy()
	{
		/*SetCharacter(playerChar.entityName);
		Say ("If you dare talk to a solicitor about this I will drag you through the courts until you are bankrupt and homeless.");*/
		rollTarget -= 4.0f;
		otherParty.AddDispositionTowardsYou(-3.0f);
		/*SetCharacter(otherParty.entityName);
		Say ("How much?");
		SetCharacter(playerChar.entityName);
		AddOption("By ten percent.", RentUpByTen);
		AddOption("By twelve percent.", RentUpByTwelve);
		AddOption ("By fifteen percent.", RentUpByFifteen);
		AddOption ("By twenty percent.", RentUpByTwenty);*/
	}
	
	void ManipulativeTenancy()
	{
		/*SetCharacter(playerChar.entityName);
		Say ("I know, I'm really sorry, but if I don't increase rents and make the payments, this building could be reposessed and we could all lose everything.");*/
		otherParty.AddDispositionTowardsYou(1.0f);
		/*Say ("Please, you have to help me.");*/
		otherParty.AddDispositionTowardsYou(0.3f);
		/*SetCharacter(otherParty.entityName);
		Say ("How much?");
		SetCharacter(playerChar.entityName);
		AddOption("By ten percent.", RentUpByTen);
		AddOption("By twelve percent.", RentUpByTwelve);
		AddOption ("By fifteen percent.", RentUpByFifteen);
		AddOption ("By twenty percent.", RentUpByTwenty);*/
	}
	
	void RentUpByTen()
	{
		rollTarget += 0.5f;
		bool success = RollForSuccess(rollTarget, otherParty.GetDispositionTowardsYou());
		
		if (success)
		{
			/*SetCharacter(otherParty.entityName);
			Say ("OK, look, that's fine. Whatever.");*/
		} else {
			/*SetCharacter(otherParty.entityName);
			Say ("No, we can't pay that. We'll have to move out.");*/
		}
	}
	
	void RentUpByTwelve()
	{
		rollTarget += 1.0f;
		bool success = RollForSuccess(rollTarget, otherParty.GetDispositionTowardsYou());
		
		if (success)
		{
			/*SetCharacter(otherParty.entityName);
			Say ("OK, look, that's fine. Whatever.");*/
		} else {
			/*SetCharacter(otherParty.entityName);
			Say ("No, we can't pay that. We'll have to move out.");*/
		}
	}
	
	void RentUpByFifteen()
	{
		rollTarget += 2.0f;
		bool success = RollForSuccess(rollTarget, otherParty.GetDispositionTowardsYou());
		
		if (success)
		{
			/*SetCharacter(otherParty.entityName);
			Say ("OK, look, that's fine. Whatever.");*/
		} else {
			/*SetCharacter(otherParty.entityName);
			Say ("No, we can't pay that. We'll have to move out.");*/
		}
	}
	
	void RentUpByTwenty()
	{
		rollTarget += 3.0f;
		bool success = RollForSuccess(rollTarget, otherParty.GetDispositionTowardsYou());
		
		if (success)
		{
			/*SetCharacter(otherParty.entityName);
			Say ("OK, look, that's fine. Whatever.");*/
		} else {
			/*SetCharacter(otherParty.entityName);
			Say ("No, we can't pay that. We'll have to move out.");*/
		}
	}
	
	void PropertyOwnerNegotiation()
	{
		
	}
	
	void BankManagerNegotiation()
	{
	
	}
	
	void PoliticianNegotation()
	{
	
	}
	
	void ChildNegotation()
	{
	
	}
}
