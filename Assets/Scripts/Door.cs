using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    // Use this for initialization
    public int levelToLoad;
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
