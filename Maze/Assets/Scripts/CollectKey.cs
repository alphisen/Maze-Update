using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKey : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // collectSound.Play();
            ScoringSystemKey.theScoreKey += 1;
           // this.gameObject.SetActive(false);
        }

    }
}
