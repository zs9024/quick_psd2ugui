using UnityEngine;
using System.Collections;
using UnityEditor;
using Quick.UI;
using UnityEditor.UI;

[CustomEditor(typeof(Tab), true)]
[CanEditMultipleObjects]
public class TabEditor : ToggleEditor
{

    SerializedProperty m_PageProperty;

    void OnEnable()
    {
        base.OnEnable();
        m_PageProperty = serializedObject.FindProperty("m_Page");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Tab tab = target as Tab;
        tab.page.IsOn = tab.isOn;

        EditorGUILayout.Space();       
        EditorGUILayout.PropertyField(m_PageProperty);

        string tag = EditorGUILayout.TextField("Tag", tab.tag);
        if (tab.tag != tag)
        {
            tab.tag = tag;
        }

        EditorGUILayout.Space();

        serializedObject.Update();
        serializedObject.ApplyModifiedProperties();
    }
}
