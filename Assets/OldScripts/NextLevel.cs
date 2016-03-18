using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public int levelToLoad;
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
