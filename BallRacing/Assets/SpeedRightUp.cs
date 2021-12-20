using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRightUp : MonoBehaviour
{
    Rigidbody2D Rigidbody1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody1 = collision.GetComponent<Rigidbody2D>();
        Rigidbody1.AddForce(new Vector2(20f,20f),ForceMode2D.Impulse);

    }
}
