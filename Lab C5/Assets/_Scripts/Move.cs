using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = -9.8f;

    CharacterController cc;
    Vector3 velocity;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        GetComponent<CharacterController>()
            .SimpleMove(move * speed);
    }
}
