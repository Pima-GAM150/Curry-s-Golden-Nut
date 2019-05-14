using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDetection : MonoBehaviour
{
    public GameObject Screen;
    public GameObject levelController;
    public GameObject goldenNut;
    public GameObject reset;

    public Animator anim;

    private void Update()
    {
        if (Input.GetButtonDown("Reset"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name is "Home of the Nut")
        {
            Screen.SetActive(true);
            reset.SetActive(false);
            levelController.GetComponent<Movement>().levelDone = true;
            Screen.GetComponent<LevelComplete>().LevelDone();
            Destroy(goldenNut.gameObject);
            Audiomanager.instance.Play("NutCollected");
        }
        if(col.name is "Curry Trap")
        {
            Dead();
        }
        if(col.name is "Evil Curry")
        {
            Dead();
        }
    }

    public void Dead()
    {
        Audiomanager.instance.Play("Dead");
        anim.SetBool("Dead", true);
        levelController.GetComponent<Movement>().levelDone = true;
    }
}
