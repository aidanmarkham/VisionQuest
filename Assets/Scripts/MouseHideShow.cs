using UnityEngine;
using System.Collections;

public class MouseHideShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public bool showMouse;
	// Update is called once per frame
	void Update () {
        if (showMouse)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
	}
}
