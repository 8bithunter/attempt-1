using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TadpoleMovement : MonoBehaviour
{
    public Sprite spriteRight;
    public Sprite spriteLeft;

    private Rigidbody2D body;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(StartRandomVelocity());

    }

    IEnumerator StartRandomVelocity()
    {
        System.Random random = new System.Random();

        while (true)
        {
            yield return new WaitForSeconds((float)random.NextDouble() * 2 + 1);

            float randomAngle = UnityEngine.Random.Range(0, 360);

            Vector2 randomDirection = Quaternion.Euler(0, 0, randomAngle) * Vector2.right;

            body.velocity = randomDirection * 5;
        }
    }

    void Update()
    {
        if (body.velocity.x > 0.025)
        {
            spriteRenderer.sprite = spriteRight;
        }
        else if (body.velocity.x < -0.025)
        {
            spriteRenderer.sprite = spriteLeft;
        }
    }
}