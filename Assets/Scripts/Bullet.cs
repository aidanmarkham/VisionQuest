using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;
    public float rotationSpeed;

    
    Transform myTrans;
    Vector3 myPos;
    Vector3 myRot;
    

    float angle;

	// Use this for initialization
	void Start () {
        
        myTrans = transform;
        myPos = myTrans.position;
        myRot = myTrans.rotation.eulerAngles;
        
	}
    public float Speed{
        get { return speed; }
        set { speed = value; }
    }

    public float RotationSpeed
    {
        get { return rotationSpeed; }
        set { rotationSpeed = value; }
    }
	
	// Update is called once per frame
	void Update () {
        myRot.z += rotationSpeed;
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;
        myPos.x += (Mathf.Cos(angle) * speed) * Time.deltaTime;
        myPos.y += (Mathf.Sin(angle) * speed) * Time.deltaTime;

        myTrans.position = myPos;
        myTrans.rotation = Quaternion.Euler(myRot);
	}
}
