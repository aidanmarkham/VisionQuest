using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
    public float speed = 3f;
    public int level = 0;
    private int lastlevel = 0;
    GameObject[] gameObjects;
    public AudioClip impact;
    AudioSource audio;
    public GameObject childplayer;
    
	// Update is called once per frame
	void Update () {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

        if (level != lastlevel)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("Bullet");
            GetComponent<AudioSource>().PlayOneShot(impact, 0.7F);
            for (var i = 0; i < gameObjects.Length; i++)
                Destroy(gameObjects[i]);
        }

        childplayer.transform.position = transform.position;



        lastlevel = level;
	}

    
}
