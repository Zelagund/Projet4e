﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl01 : MonoBehaviour {

    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level01");
    }

}
