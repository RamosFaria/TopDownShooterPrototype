using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSelectedBundle : MonoBehaviour
{
    public static SetSelectedBundle Instance { private set; get; }

    public SelectedBundle selectedBundle;

    private Character character;

    private Gun weapon;

    private void Awake()
    {
        Instance = this;
        character = FindObjectOfType<Character>();
        weapon = FindObjectOfType<Gun>();

        character.GetComponent<SpriteRenderer>().sprite = selectedBundle.characterSelected.CharacterSprite;

        weapon.GetComponent<SpriteRenderer>().sprite = selectedBundle.weaponSelected.WeaponSprite;
        

    }
}
