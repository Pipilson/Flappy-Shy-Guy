﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comecar : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}