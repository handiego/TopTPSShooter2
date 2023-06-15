using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Camera/Config")]
public class CameraConfig : ScriptableObject
{
    public float turnSmooth;
    public float pivotSpeed;
    public float yRotationSpeed;
    public float xRotationSpeed;
    public float minAngle;
    public float maxAngle;
    public float normalZ;
    public float normalX;
    public float normalY;
    public float aimZ;
    public float aimX;
    
}
