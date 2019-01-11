using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLvl : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
    }
    //SceneManager.GetActiveScene().buildIndex + 1
}
