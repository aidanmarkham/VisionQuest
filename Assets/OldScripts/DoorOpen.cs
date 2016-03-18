using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
	}
    private GameObject player;
    private PlayerMovement playerMovement;
    public GameObject prefab;
	// Update is called once per frame
	void Update () {
        
        if (playerMovement.level == 9)
        {
            Instantiate(prefab, transform.position, transform.rotation * Quaternion.Euler(0, 0, -90));
            Destroy(this.gameObject);
        }
	}
}
