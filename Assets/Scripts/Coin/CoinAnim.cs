using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    public SpriteRenderer spriterenderer;
    public Sprite[] coin;
    float spritecount = 0;

    void Update()
    {
        spritecount += Time.deltaTime * 8;

        if (spritecount >= coin.Length)
            spritecount = 0;

        spriterenderer.sprite = coin[(int)spritecount];
    }
}