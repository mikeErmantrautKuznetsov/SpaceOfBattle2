using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMove : MonoBehaviour
{
    private float speedBelt = 3f;
    private float RangeX = 30f;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speedBelt * Time.deltaTime);

        if (transform.position.x < -RangeX)
        {
            transform.position = new Vector2(5, 0);
        }
    }
}
