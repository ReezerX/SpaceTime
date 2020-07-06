using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatEnchounter : MonoBehaviour
{
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //loading level with build string
            SceneManager.LoadScene(levelName);

            Debug.Log("why wont you work T_T");
        }
    }
 
}
