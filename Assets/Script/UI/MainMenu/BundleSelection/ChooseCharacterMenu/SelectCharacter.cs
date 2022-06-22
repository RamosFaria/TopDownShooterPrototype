using UnityEngine;
using System;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private CharacterSkills currentCharacterSelected;

    public static event Action<CharacterSkills> OnCurrentCharacterSelectedChanged;

    public void UpdateCharacterSelected()
    {
        OnCurrentCharacterSelectedChanged?.Invoke(currentCharacterSelected);
    }
}
