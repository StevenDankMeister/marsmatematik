using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGameObject : MonoBehaviour {

    public void HideObject(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void ShowObject(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}
