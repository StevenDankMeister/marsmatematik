using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonDB : MonoBehaviour {

    public List<string> completedLessons;

    private void Start()
    {
        completedLessons = new List<string>();
    }
}
