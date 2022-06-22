using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MousePosition : MonoBehaviour
{
    [HideInInspector]public static Transform objectInUse { get; set;}

    private static float gunRotation;

    private static Camera mainCamera;

    public virtual void Awake()
    {
        mainCamera = Camera.main;
    }
    public static Vector3 MousePos()
    {

        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    public static float GunRotationAngle()
    {
        Vector3 difference = mainCamera.ScreenToWorldPoint(Input.mousePosition) - objectInUse.position;

        difference.Normalize();

        gunRotation = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        
        return gunRotation;
    }

    //mudar animação do jogador de acordo com o angulo
    //usar um conjunto pra travar os pontos de mudança de animação
    //e também para verificar a velocidade do player enquanto se move

}
