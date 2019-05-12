using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutCollection : MonoBehaviour
{
    public GameObject Target;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name is "Curry")
        {
            Target.SetActive(true);
            print("Turn the " + Target.name + " on.");
            Target.GetComponent<LevelComplete>().LevelDone();
            Destroy(this.gameObject);
        }
    }
}
