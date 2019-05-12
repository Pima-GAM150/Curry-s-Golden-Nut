using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelFinish;
    public GameObject goldenNut;
    public GameObject nutCollected;


    public void Start()
    {
        levelFinish.SetActive(false);
        goldenNut.SetActive(false);
        nutCollected.SetActive(false);
    }
    public void LevelDone()
    {

        StartCoroutine("GoldenNut");
        StartCoroutine("NutCollected");
 
    }

    private IEnumerator GoldenNut()
    {
        yield return new WaitForSeconds(.25f);
        goldenNut.SetActive(true);
    }
    private IEnumerator NutCollected()
    {
        yield return new WaitForSeconds(.75f);
        nutCollected.SetActive(true);
    }
}