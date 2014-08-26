using UnityEngine;
using System.Collections;

public class StoryEntity : MonoBehaviour {

	public string name;
	public enum EntityType {ENTITY_TYPE_CHARACTER, 
							ENTITY_TYPE_COMPANY, 
							ENTITY_TYPE_DEVELOPER, 
							ENTITY_TYPE_NEWSPAPER,
							ENTITY_TYPE_JOURNALIST,
							ENTITY_TYPE_POLITICIAN,
							ENTITY_TYPE_PLAYER}
	
	public EntityType typeOfEntity;
	
	
	
}
