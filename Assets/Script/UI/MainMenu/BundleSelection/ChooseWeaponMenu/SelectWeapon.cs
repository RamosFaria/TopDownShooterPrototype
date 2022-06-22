using UnityEngine;
using System;

public class SelectWeapon : MonoBehaviour
{
    [SerializeField] private WeaponStats currentWeapon;

    public static event Action<WeaponStats> OnCurrentWeaponSelectedChanged;

    public void UpdateWeaponSelected()
    {
        OnCurrentWeaponSelectedChanged?.Invoke(currentWeapon);
    }


}
