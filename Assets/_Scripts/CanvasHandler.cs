using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasHandler : MonoBehaviour {

    public static CanvasHandler canvasHandler;

    public GameObject exerciseDesc;
    public GameObject requirementsTextPrefab;
    public GameObject requirementsTextPivot;

    public GameObject lessonDB;

    private LessonDB LessonDB;
    private GameObject requirementsText;

	void Start () {
        canvasHandler = GetComponent<CanvasHandler>();
        LessonDB = lessonDB.GetComponent<LessonDB>();
	}
	
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

        Vector3 offset = new Vector3();

        foreach (string s in exerciseParams.requirements)
        {
            CreateRequirementsText(offset, s);
            SetRequirementsTextColor(s);

            offset.y += -20;
        }
    }

    private void SetRequirementsTextColor(string s)
    {
        if (LessonDB.completedLessons.Contains(s))
        {
            requirementsText.GetComponent<Text>().color = Color.green;
        }
        else
        {
            requirementsText.GetComponent<Text>().color = Color.red;
        }
    }

    private void CreateRequirementsText(Vector3 offset, string s)
    {
        requirementsText = Instantiate(requirementsTextPrefab, requirementsTextPivot.transform.position + offset, Quaternion.identity, requirementsTextPivot.transform);
        requirementsText.GetComponent<Text>().text = s;
    }

    public void AddLessonToDB()
    {
        string test = "Test1";

        LessonDB.completedLessons.Add(test);
    }
}
