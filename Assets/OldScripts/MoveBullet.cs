using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	// Use this for initialization

    public float speed;
    public float rotationSpeed;

    public float[] speedArray; 
    public float[] rotArray;
    Transform myTrans;
    Vector3 myPos;
    Vector3 myRot;
    private GameObject player;
    private PlayerMovement playerMovement;

    float angle;

	void Start () {
        rotArray = new float[10] {0, 0, 0, 0, 0,0, -.2f, .3f, 0, 0 };
        speedArray = new float[10] {3, 3, 3, 3, 5, 2, 3,   3, 3, 0};
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        myRot.z += rotArray[playerMovement.level];
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;
        myPos.x += (Mathf.Cos(angle) * speedArray[playerMovement.level]) * Time.deltaTime;
        myPos.y += (Mathf.Sin(angle) * speedArray[playerMovement.level]) * Time.deltaTime;

        myTrans.position = myPos;
        myTrans.rotation = Quaternion.Euler(myRot);
	}
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    
}
