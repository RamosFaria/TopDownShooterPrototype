using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawn;

    public WeaponStats weaponStats;

    private Transform arm;

    private void Awake()
    {
        arm = FindObjectOfType<Arm>().transform;
        
    }

    private void Start()
    {
        SetValues();
    }

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        //add magazine size, reload time
        if(Input.GetButtonDown("Fire1"))
        {
            var shot = ShotPool.Instance.Get();
            shot.gameObject.transform.position = bulletSpawn.position;
            shot.gameObject.SetActive(true);
        }
    }

    private void SetValues()
    {
        ShotPool.Instance.bulletPrefab = weaponStats.BulletPrefab;
        ShotPool.Instance.bulletPrefab.Damage = weaponStats.BaseDamage;


    }

    //public void EquipWeapon()
    //{
    //    this.transform.SetParent(arm);
    //    transform.localPosition = new Vector2(1,0);
    //    transform.localRotation = Quaternion.Euler(0, 0, 0);
    //    SetValues();
    //}

}
