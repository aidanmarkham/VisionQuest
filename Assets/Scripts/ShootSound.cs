using UnityEngine;
using System.Collections;

public class ShootSound : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        

        rotating = false;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().Pause();
    }
    public GameObject target;
    private bool point;
    public GameObject entry;
    private bool rotating;
    float rot_z;
    float rot_z_old;
	
	// Update is called once per frame
	void Update () {
        Vector3 diff = target.GetComponent<Transform>().position - transform.position;
        diff.Normalize();

        rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        

        if (rot_z == rot_z_old)
        {
            rotating = false;
        }
        else
        {
            rotating = true;
        }
        if (point == true)
        {
            if (rotating && GetComponent<AudioSource>().isPlaying == false)
            {

                GetComponent<AudioSource>().UnPause();
            }
            else if (rotating == false && GetComponent<AudioSource>().isPlaying == true)
            {
                GetComponent<AudioSource>().Pause();
            }
        }
        if (entry.GetComponent<StartCircle>().playerInside == false)
        {
            point = true;
        }

        rot_z_old = rot_z;
	}
}
