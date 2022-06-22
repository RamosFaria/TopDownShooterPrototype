using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    public int Damage;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnEnable()
    {
        transform.rotation = Quaternion.Euler(0, 0, MousePosition.GunRotationAngle());
    }

    private void Update()
    {
        
        rb.AddForce( transform.right * 15);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ShotPool.Instance.ReturnToPool(this);

        var entity = collision.collider.GetComponent<Entity>();
        if(entity != null)
        {
            entity.TakeHit(entity, Damage);
        }

    }

}
