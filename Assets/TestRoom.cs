using UnityEngine;
using System.Collections;
using Fungus;
using BensCustomCode;

public class TestRoom : Room {

	public View topLeftView;
	public View bottomRightView;
	public View overView;
	
	public Building[] buildingButtons;
	
	public Button zoomButton;
	
	// public SpriteRenderer clouds;
	
	private Camera mainCamera;
	
	private CustomVectorOperations customVectorOp;
	
	void Start()
	{
		mainCamera = Camera.main;
		customVectorOp = new CustomVectorOperations();
	}
	
	void Update()
	{
		ShowFlaggedButtons();
	}

	void OnEnter()
	{
		// HideSprite(clouds);
		ZoomIn();
		ButtonCheck();
	}
	
	void ZoomIn()
	{
		Debug.Log("Zooming in.");
		Variables.SetBoolean("zoomedIn", true);
		Call (ButtonCheck);
		StartSwipePan(topLeftView, bottomRightView, 1f);
		// FadeSprite(clouds, 0, 0.5f);
	}
	
	void ZoomOut()
	{
		Debug.Log ("Zooming out.");
		Variables.SetBoolean("zoomedIn", false);
		Call (ButtonCheck);
		PanToView(overView, 1f, true);
		// FadeSprite(clouds, 1, 0.5f);	// TODO create an animation instead.
	}
	
	void ButtonCheck()
	{
		HideButton(zoomButton);
		if (Variables.GetBoolean("zoomedIn"))
			ShowButton(zoomButton, ZoomOut);
		if (!Variables.GetBoolean("zoomedIn"))
			ShowButton(zoomButton, ZoomIn);
	}
	
	void TileSprite(SpriteRenderer pSpriteToTile)
	{
		Bounds spriteBounds = pSpriteToTile.bounds;
		Vector2 topLeft = customVectorOp.FlattenVector(spriteBounds.min);
		Vector2 bottomRight = customVectorOp.FlattenVector(spriteBounds.max);
		
		float height = topLeft.y - bottomRight.y;
		float width = bottomRight.x - topLeft.x;
		
		// Vector2 spritePos = customVectorOp.FlattenVector(spriteBounds.center);
		
		bool centerOnCamera = IsOnCamera(spriteBounds);
		
	}
	
	bool IsOnCamera (Vector2 pLocToCheck)
	{
		// Create a 3D proxy point
		Vector3 temp3DVector;
		temp3DVector.x = pLocToCheck.x;
		temp3DVector.y = pLocToCheck.y;
		temp3DVector.z = 0.0f;
		Vector2 temp2DVector = customVectorOp.FlattenVector(mainCamera.WorldToViewportPoint(temp3DVector));
		// Get the 2D world to viewport point.
		if (temp2DVector.x >= 0 &&
			temp2DVector.x <= 1 &&
			temp2DVector.y >= 0 &&
			temp2DVector.y <= 1)
			// Return true if the point falls within the bounds of the float.
			return true;
		
		// Otherwise, return false.
		return false;
		
	}
	
	bool IsOnCamera(Bounds boundsToCheck)
	{
		// Start with the centre
		Vector2 temp2DVector = customVectorOp.FlattenVector(mainCamera.WorldToViewportPoint(boundsToCheck.center));
		
		if (temp2DVector.x >= 0 &&
		    temp2DVector.x <= 1 &&
		    temp2DVector.y >= 0 &&
		    temp2DVector.y <= 1)
			// Return true if the point falls within the bounds of the float.
			return true;
			
		// Check the left edge.
		temp2DVector = customVectorOp.FlattenVector(mainCamera.WorldToViewportPoint(boundsToCheck.min));
		
		if (temp2DVector.x >= 0 &&
			temp2DVector.x <= 1)
			// Return true if the point falls within the bounds of the float.
			return true;
		
		
		
		// Check the top edge.
		// No need to re-define the temp2DVector since the top edge is also in the min object
		if (temp2DVector.y >= 0 &&
			temp2DVector.y <= 1)
			// Return true of the point falls within the bounds of the float.
			return true;
			
							
		// Check the right edge.
		temp2DVector = customVectorOp.FlattenVector(mainCamera.WorldToViewportPoint(boundsToCheck.max));
		
		if (temp2DVector.x >= 0 &&
			temp2DVector.x <= 1)
			return true;
		
		
		// Check the bottom edge.
		if (temp2DVector.y >= 0 &&
			temp2DVector.y <= 1)
			return true;
		
		// If all the above fails, return false;
		return false;
		
	}
	
	void ShowFlaggedButtons()
	{
		for (int i = 0; i < buildingButtons.Length; i++)
		{
			if (buildingButtons[i].visible)
			{
				ShowButton(buildingButtons[i].thisButton, buildingButtons[i].Examine);
			}
		}
	}
}
