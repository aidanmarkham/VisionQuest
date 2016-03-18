using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    

    public int level = 0;
    private int lastlevel = 0;


    GameObject[] gameObjects;



    public AudioClip impact;
    AudioSource audio;
    

    // Update is called once per frame
    void Update()
    {
        

        if (level != lastlevel) // when the player levels up
        {
            gameObjects = GameObject.FindGameObjectsWithTag("Bullet"); // find all bullets
            GetComponent<AudioSource>().PlayOneShot(impact, 0.7F); // play level up noise
            for (var i = 0; i < gameObjects.Length; i++) // actually destroy all the bullets
                Destroy(gameObjects[i]);
        }

        lastlevel = level;
    }


}
