using UnityEngine;
using System.Collections;

public class OldShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
        audio = GetComponent<AudioSource>();
	}
    private float nextActionTime = 0.0f;
    private float nextActionTimeRot = 0.0f;
    public AudioClip impact;
    AudioSource audio;
    private float[] periodArray =    { .5f, .25f, .125f, .0625f,   .1f,   .25f, .1f,   .05f, .05f, float.MaxValue };
    private float[] rotPeriodArray = { .5f, .25f, .125f, .0625f,   .5f,   .05f, .05f,  .05f, .05f, .1f};
    private float[] selfRotArray =   {   4, 182f,   91f,  45.5f,   193,   181f,   3,   183f, 201f,  1};
    private float[] bulletRotArray = new float[10] {0, 0, 0, 0, 0,0, -.2f, .3f, 0, 0 };
    private float[] bulletSpeedArray = new float[10] {3, 3, 3, 3, 5, 2, 3,   3, 3, 0};
    private GameObject player;
    private PlayerMovement playerMovement;




    
    public GameObject prefab;
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            
            nextActionTime += periodArray[playerMovement.level];
            
            Instantiate(prefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, -90));
            audio.PlayOneShot(impact, 0.7F);
            
        }
        if (Time.time > nextActionTimeRot)
        {
            
            nextActionTimeRot += rotPeriodArray[playerMovement.level];

            transform.rotation *= Quaternion.Euler(0, 0, selfRotArray[playerMovement.level]);

        }
	}
    
}
