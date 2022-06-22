using System.Collections.Generic;
using UnityEngine;

public class ShotPool : MonoBehaviour
{
    public Bullet bulletPrefab;

    private Queue<Bullet> bulletShot = new Queue<Bullet>();

    public static ShotPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Bullet Get()
    {
        if(bulletShot.Count ==0)
        {
            AddShots(1);
        }

        return bulletShot.Dequeue();
    }

    private void AddShots(int count)
    {
        Bullet bullet = Instantiate(bulletPrefab);
        bullet.gameObject.SetActive(false);
        bulletShot.Enqueue(bullet);
    }

    public void ReturnToPool(Bullet bulletToReturn)
    {
        bulletToReturn.gameObject.SetActive(false);
        bulletShot.Enqueue(bulletToReturn);
    }

}
