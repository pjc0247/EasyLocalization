using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EasyLocalization))]
public class EasyLocalizationEditor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Reset"))
        {
            ((EasyLocalization)target).Awake();
        }

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("KO"))
        {
            ((EasyLocalization)target).SetActive(SystemLanguage.Korean);
        }
        if (GUILayout.Button("EN"))
        {
            ((EasyLocalization)target).SetActive(SystemLanguage.English);
        }
        if (GUILayout.Button("JP"))
        {
            ((EasyLocalization)target).SetActive(SystemLanguage.Japanese);
        }
        GUILayout.EndHorizontal();
    }
}

