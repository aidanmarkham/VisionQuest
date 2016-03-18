using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
    public GameObject player;
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(player);
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }
    void OnBecameInvisible()
    {
        SceneManager.LoadScene(0);
    }
}
