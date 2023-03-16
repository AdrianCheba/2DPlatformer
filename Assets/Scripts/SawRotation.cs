using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotation : MonoBehaviour
{
    private readonly float speed = 550000f;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, 360 * speed);

    }
}
