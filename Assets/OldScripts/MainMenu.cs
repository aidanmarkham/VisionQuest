using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public bool isStart;
	// Update is called once per frame
	void Update () {
        if (isStart)
        {
            Application.LoadLevel(1);
        }
	}
}
