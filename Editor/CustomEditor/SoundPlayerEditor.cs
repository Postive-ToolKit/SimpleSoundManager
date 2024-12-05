using Postive.SimpleSoundAssetManager.Runtime;
using UnityEditor;
using UnityEngine;
namespace Postive.SimpleSoundManager.Editor.CustomEditor
{
    [CustomPropertyDrawer(typeof(SoundPlayer))]
    public class SoundPlayerEditor : PropertyDrawer
    {
        private Vector3 _soundPlayPosition;
        private Transform _soundPlayTransform;
        private int _heightIndex = 0;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            
            _heightIndex = 0;
            EditorGUI.BeginProperty(position, label, property);
            SerializedProperty soundName = property.FindPropertyRelative("_soundName");
            
            
            
            _heightIndex++;
            position.y += 2;
            property.serializedObject.Update();
            EditorGUI.PropertyField(new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight), soundName);
            property.serializedObject.ApplyModifiedProperties();
            
            if (!Application.isPlaying) {
                EditorGUI.EndProperty();
                return;
            }
            
            float halfWidth = position.width / 2;
            
            position.y += EditorGUIUtility.singleLineHeight + 2f;
            _heightIndex++;
            _soundPlayPosition = EditorGUI.Vector3Field(new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight), "Sound Position", _soundPlayPosition);
            
            position.y += EditorGUIUtility.singleLineHeight + 2f;
            _heightIndex++;
            _soundPlayTransform = EditorGUI.ObjectField(new Rect(position.x , position.y, position.width, EditorGUIUtility.singleLineHeight), "Sound Transform", _soundPlayTransform, typeof(Transform), true) as Transform;
            
            position.y += EditorGUIUtility.singleLineHeight + 2f;
            _heightIndex++;
            if (GUI.Button(new Rect(position.x, position.y, halfWidth, EditorGUIUtility.singleLineHeight), "Play Sound At Position")) {
                SoundManager.PlaySound(soundName.stringValue, _soundPlayPosition);
            }
            if (GUI.Button(new Rect(position.x + halfWidth, position.y, halfWidth, EditorGUIUtility.singleLineHeight), "Play Sound At Transform")) {
                SoundManager.PlaySoundAtTransform(soundName.stringValue, _soundPlayTransform);
            }
            
            EditorGUI.EndProperty();
        }
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return (EditorGUIUtility.singleLineHeight + 2f) * _heightIndex;
        }
    }
}