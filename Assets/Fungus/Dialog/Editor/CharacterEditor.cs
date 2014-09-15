using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Fungus
{

	[CustomEditor (typeof(Character))]
	public class CharacterEditor : Editor
	{
		Material spriteMaterial;

		SerializedProperty nameTextProp;
		SerializedProperty nameColorProp;
		SerializedProperty profileSpriteProp;
		SerializedProperty notesProp;

		void OnEnable()
		{
			nameTextProp = serializedObject.FindProperty ("nameText");
			nameColorProp = serializedObject.FindProperty ("nameColor");
			profileSpriteProp = serializedObject.FindProperty ("profileSprite");
			notesProp = serializedObject.FindProperty ("notes");

			Shader shader = Shader.Find("Sprites/Default");
			if (shader != null)
			{
				spriteMaterial = new Material(shader);
				spriteMaterial.hideFlags = HideFlags.DontSave;
			}
		}

		void OnDisable()
		{
			DestroyImmediate(spriteMaterial);
		}

		public override void OnInspectorGUI() 
		{
			serializedObject.Update();

			EditorGUILayout.PropertyField(nameTextProp, new GUIContent("Name Text", "Name of the character display in the dialog"));

			EditorGUILayout.PropertyField(nameColorProp, new GUIContent("Name Color", "Color of name text display in the dialog"));

			EditorGUILayout.PropertyField(profileSpriteProp, new GUIContent("Image", "Character image sprite to display in the dialog"));

			EditorGUILayout.PropertyField(notesProp, new GUIContent("Notes", "Notes about this story character (personality, attibutes, etc.)"));

			EditorGUILayout.Separator();

			Character t = target as Character;
			if (t.profileSprite != null &&
			    spriteMaterial != null)
			{
				EditorGUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				float aspect = (float)t.profileSprite.texture.width / (float)t.profileSprite.texture.height;
				Rect imagePreviewRect = GUILayoutUtility.GetAspectRect(aspect, GUILayout.Width(150), GUILayout.ExpandWidth(false));
				GUILayout.FlexibleSpace();
				EditorGUILayout.EndHorizontal();

				DrawPreview(imagePreviewRect, t.profileSprite.texture);
			}

			serializedObject.ApplyModifiedProperties();
		}

		public void DrawPreview(Rect previewRect, Texture2D texture)
		{
			if (texture == null)
			{
				return;
			}
			EditorGUI.DrawPreviewTexture(previewRect, 
			                             texture,
			                             spriteMaterial);
		}
	}

}