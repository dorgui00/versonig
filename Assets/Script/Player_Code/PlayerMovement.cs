using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed; // Vitesse de déplacement

    void Update()
    {
        // Déplacement horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        // Déplacement vertical
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
    }
}
