using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidLevelRise : MonoBehaviour
{

    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0f, 0.014f, 0f);
    }
    
}
