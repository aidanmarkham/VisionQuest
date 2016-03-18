using UnityEngine;
using System.Collections;

public class PointAtPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        point = false;
        
        
        
	}
    public GameObject target;
    private bool point;
    public GameObject entry;
    

    
    float rot_z;
    
	void Update () {
        //transform.LookAt(target.GetComponent<Transform>());
        if (point == true)
        {
            Vector3 diff = target.GetComponent<Transform>().position - transform.position;
            diff.Normalize();

            rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
            
            
        }
        if (entry.GetComponent<StartCircle>().playerInside == false)
        {
            point = true;
        }

        
        
        
	}
}
