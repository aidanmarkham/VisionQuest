using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public float speed = 3f;

    GameObject[] gameObjects;


    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //gets input
        transform.position += move * speed * Time.deltaTime; // applies the input


    }


}