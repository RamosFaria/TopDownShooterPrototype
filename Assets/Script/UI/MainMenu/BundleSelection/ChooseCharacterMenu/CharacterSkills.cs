using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CharacterSkill")]
[System.Serializable]
public class CharacterSkills : ScriptableObject
{
    public string Description;
    public Sprite CharacterSprite;
    public int MaxHealth;

    //Depois colocar as skills

}
