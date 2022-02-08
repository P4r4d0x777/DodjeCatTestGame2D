using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float _rotateSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, _rotateSpeed));    
    }
}
