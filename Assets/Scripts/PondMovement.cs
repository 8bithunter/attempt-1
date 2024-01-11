using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PondMovement : MonoBehaviour
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
        while (true)
        {
            yield return new WaitForSeconds(2f);

            float randomAngle = Random.Range(30f, 150f);

            Vector2 randomDirection = Quaternion.Euler(0, 0, randomAngle) * Vector2.right;

            body.velocity = randomDirection * 5f;
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
