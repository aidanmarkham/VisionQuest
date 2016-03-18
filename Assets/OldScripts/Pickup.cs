using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        playerManager = player.GetComponent<PlayerManager>();
        audio = GetComponent<AudioSource>();
	}
    public int level;
    private GameObject player;
    private PlayerManager playerManager;
    public AudioClip impact;
    AudioSource audio;
	// Update is called once per frame
	void Update () {
        
        if (playerManager.level != level)
        {
            this.GetComponent<Renderer>().enabled = false;
            this.GetComponent<CircleCollider2D>().enabled = false;
        }
        else
        {
            this.GetComponent<Renderer>().enabled = true;
            this.GetComponent<CircleCollider2D>().enabled = true;
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        //audio.PlayOneShot(impact, 0.7F);
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerManager>().level += 1;
            
            Destroy(this.gameObject);
        }
    }
}
