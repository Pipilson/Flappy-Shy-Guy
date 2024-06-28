using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Recomecar : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Menu");
        }

        if (Input.GetKey(KeyCode.S))
        {
            Application.Quit();
        }
    }
}