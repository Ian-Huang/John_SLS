using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TextMesh))]
public class TextAreaEditor : Editor
{
	public override void OnInspectorGUI()
	{
		this.DrawDefaultInspector();
		TextMesh current_target = target as TextMesh;
		
		EditorGUILayout.LabelField("文字：", "");
		
		current_target.text = EditorGUILayout.TextArea(current_target.text);
	}
}