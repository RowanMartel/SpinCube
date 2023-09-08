using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    [SerializeField] private Vector3 spinAngle;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(spinAngle, spinSpeed * Time.deltaTime, Space.World);
    }
}