using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Weapon")]
[System.Serializable]
public class WeaponStats : ScriptableObject
{
    public string WeaponName;
    public Sprite WeaponSprite;

    public Bullet BulletPrefab;

    public int BaseDamage;
    public int MagazineSize;
    public float ReloadTime;
}
