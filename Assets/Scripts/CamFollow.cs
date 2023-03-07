using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform cameraTargetToFollow;

    public float smoothSpeed;
    public Vector3 offSet;

    private void Start()
    {
        offSet = transform.position - cameraTargetToFollow.position;
    }
    private void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offSet + cameraTargetToFollow.position, smoothSpeed);
        transform.position = new Vector3(transform.position.x, newPos.y, transform.position.z);
    }

}
