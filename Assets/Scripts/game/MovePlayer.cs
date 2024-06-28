using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    float velocity = 20;
    public SpriteRenderer spriterenderer;
    public Sprite[] spritefly;
    public AudioSource audioengine;
    float spritecount = 0;
    float velocityrotor = 10;

    // Update is called once per frame
    void Update()
    {
        FisicaFake();
        Chegada();

        spritecount += Time.deltaTime * velocityrotor;

        if (spritecount >= spritefly.Length)
            spritecount = 0;

        spriterenderer.sprite = spritefly[(int)spritecount];
    }

    private void Chegada()
    {
        if (transform.position.x >= 28)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    void FisicaFake()
    {
        velocityrotor = 10;
        audioengine.pitch = 0.4f;

        //if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 200)
        //{
            transform.position += new Vector3(0.1f, 0, 0) * Time.deltaTime * velocity;
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -12)
        //{
        //    transform.position += new Vector3(-0.1f, 0, 0) * Time.deltaTime * velocity;
        //}

        //jump
        if (Input.GetKey(KeyCode.Space) && transform.position.y < 4.5f)
        {
            transform.position += new Vector3(0, 0.1f, 0) * Time.deltaTime * 30;
            velocityrotor = 30;
            audioengine.pitch = 0.6f;
        }

        else
        {
            //chao fake
            if (transform.position.y > -3.4f)
            {
                //gravidade fake
                transform.position += (Vector3.down * 0.06f) * Time.deltaTime * 50;
            }
        }
    }
}