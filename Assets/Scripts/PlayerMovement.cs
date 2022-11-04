using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 12f;

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f) * movementSpeed * Time.deltaTime);
    }
}
