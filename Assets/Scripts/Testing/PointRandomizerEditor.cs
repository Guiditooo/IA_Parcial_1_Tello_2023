using UnityEngine;
using UnityEditor;

namespace IA
{

    [CustomEditor(typeof(PointRandomizer))]
    public class PointRandomizerEditor : Editor
    {
        SerializedProperty pointCountProperty;
        SerializedProperty boundsProperty;
        SerializedProperty minDistProperty;
        SerializedProperty maxAttemptsProperty;

        void OnEnable()
        {
            pointCountProperty = serializedObject.FindProperty("pointCount");
            maxAttemptsProperty = serializedObject.FindProperty("maxAttempts");
            boundsProperty = serializedObject.FindProperty("bounds");
            minDistProperty = serializedObject.FindProperty("minimumNeighborDistance");
        }
        public override void OnInspectorGUI()
        {
            PointRandomizer pointRandomizer = (PointRandomizer)target;
            serializedObject.Update();
            EditorGUILayout.PropertyField(pointCountProperty);
            EditorGUILayout.PropertyField(minDistProperty);
            EditorGUILayout.PropertyField(maxAttemptsProperty);
            EditorGUILayout.PropertyField(boundsProperty);
            serializedObject.ApplyModifiedProperties();
            if (GUILayout.Button("Randomize Points"))
            {
                pointRandomizer.RandomizePointsPos();
            }
        }

    }
}
