using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAsteroid : MonoBehaviour
{
    [SerializeField]
    private float speedRotation;

    void FixedUpdate()
    {
        transform.Rotate(Vector2.down * speedRotation * Time.deltaTime);
    }
}
