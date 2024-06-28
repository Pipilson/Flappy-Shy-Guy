using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public float damageDistance = 1;
    public AudioSource die;
    Scene fase;

    // Use this for initialization
    void Start()
    {
        if (!player)
        {
            GameObject.FindGameObjectWithTag("Player");
        }

        fase = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < damageDistance)
        {
            die.Play();
            SceneManager.LoadScene(fase.name);
        }
    }
}