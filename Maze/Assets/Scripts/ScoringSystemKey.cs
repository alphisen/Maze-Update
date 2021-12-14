using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystemKey : MonoBehaviour
{
    public GameObject scoreTextKey;
    public static int theScoreKey;


    void Update()
    {

        scoreTextKey.GetComponent<Text>().text = "" + theScoreKey;

    }



}
