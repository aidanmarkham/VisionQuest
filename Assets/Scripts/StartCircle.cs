using UnityEngine;
using System.Collections;

public class StartCircle : MonoBehaviour {

    public bool playerInside;
	// Use this for initialization
	void Start () {
        playerInside = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInside = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInside = false;
        }
    }
}
