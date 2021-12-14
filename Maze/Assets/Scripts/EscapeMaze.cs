using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMaze : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }
}
