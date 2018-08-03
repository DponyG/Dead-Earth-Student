using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class KeepSceneFocused : MonoBehaviour {

    public bool FocusScene;

	// Use this for initialization
	void Start () {

        if(FocusScene && Application.isEditor)
        {
            EditorWindow.FocusWindowIfItsOpen(typeof (SceneView));
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
