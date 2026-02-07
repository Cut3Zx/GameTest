using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
    }
}
