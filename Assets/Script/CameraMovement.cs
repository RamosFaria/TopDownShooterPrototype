using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float threshold;

    void Update()
    {
        //Vector3 targetPos = (Character.Instance.transform.position - MousePosition.MousePos()) / 2;
        //
        //targetPos.x = Mathf.Clamp(targetPos.x, -threshold + Character.Instance.transform.position.x, threshold + Character.Instance.transform.position.x);
        //targetPos.y = Mathf.Clamp(targetPos.y, -threshold + Character.Instance.transform.position.y, threshold + Character.Instance.transform.position.y);
        //
        //this.transform.position = targetPos;
    }
}
