using UnityEngine;
using System.Collections;

namespace BensCustomCode {

	public class CustomVectorOperations {
		
		public Vector2 FlattenVector(Vector3 pInputVector)
		{
			Vector2 outputVector; 
			
			outputVector.x = pInputVector.x;
			outputVector.y = pInputVector.y;
			
			return outputVector;
		}
	}

}


