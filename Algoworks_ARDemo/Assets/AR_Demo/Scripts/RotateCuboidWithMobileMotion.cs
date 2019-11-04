using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCuboidWithMobileMotion : MonoBehaviour
{
    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        Vector3 _previousEulerAngles = transform.eulerAngles;
        Vector3 _gyroInput = -Input.gyro.rotationRateUnbiased;

        Vector3 _targetEulerAngles = _previousEulerAngles + _gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        
        transform.eulerAngles = _targetEulerAngles;
    }
}
