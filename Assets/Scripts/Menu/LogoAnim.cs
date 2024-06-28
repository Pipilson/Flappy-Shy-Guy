using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoAnim : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite[] logo;
    float spritecount = 0;

    void Update()
    {
        spritecount += Time.deltaTime * 12;

        if (spritecount >= logo.Length)
            spritecount = 0;

        spriterenderer.sprite = logo[(int)spritecount];

        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}