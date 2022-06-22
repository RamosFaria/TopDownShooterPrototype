using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MousePosition
{
    public override void Awake()
    {
        base.Awake();
        objectInUse = GetComponentInParent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, GunRotationAngle());
    }


}
