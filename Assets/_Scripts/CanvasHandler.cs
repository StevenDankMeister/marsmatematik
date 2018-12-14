using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandler : MonoBehaviour {

    public static CanvasHandler canvasHandler;

    public GameObject exerciseDesc;
    public GameObject requirementsPrefab;

	// Use this for initialization
	void Start () {
        canvasHandler = GetComponent<CanvasHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowObject(GameObject newObject)
    {
        newObject.SetActive(true);
    }

    public void HideObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void SetExerciseParams(GameObject gameObject)
    {
        ExerciseParams exerciseParams = gameObject.GetComponent<ExerciseParams>();
        exerciseDesc.GetComponent < Text >().text = exerciseParams.exerciseDesc;
    }
}
