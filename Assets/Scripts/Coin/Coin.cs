using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject player;
    public float damageDistance = 1;
    public AudioSource getCoin;

    // Use this for initialization
    void Start()
    {
        if (!player)
        {
            GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < damageDistance)
        {
            Destroy(gameObject);
            getCoin.Play();
        }
    }
}