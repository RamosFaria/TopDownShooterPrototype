using UnityEngine;
using System;

public abstract class Entity : MonoBehaviour
{
    //StatsList
    protected float AttackSpeed;
    public int MaxHealth;
    public int Health;


    public static event Action<Entity, int> OnTakeHit;

    public virtual void TakeHit(Entity entity, int damage)
    {
        OnTakeHit?.Invoke(entity, damage);
    }

    public virtual void TakeDamage(int damage)
    {
        this.Health -= damage;
        if (this.Health <= 0)
        {
            this.Death();
        }
    }

    public virtual void Death()
    {
        this.gameObject.SetActive(false);
    }

    public abstract void MovementPattern();

}
