using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObject/SelectedBundle")]
[System.Serializable]
public class SelectedBundle : ScriptableObject
{
    public CharacterSkills characterSelected;
    public WeaponStats weaponSelected;
}
