using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallRemove1 : MonoBehaviour
{
    public GameObject wall;
    [SerializeField]
    private AudioSource audio;





    void Start()
    {
        // GameObject.FindWithTag("RemoveWall 1");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.Play();
            this.gameObject.SetActive(false);
            Destroy(wall);
        }
    }
}
