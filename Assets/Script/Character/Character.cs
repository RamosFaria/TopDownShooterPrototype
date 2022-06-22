using UnityEngine;

public class Character : Entity
{
    public static Character Instance { private set; get; }

    private Rigidbody2D rb2D;
    private Vector2 movementDirection;
    [SerializeField] private float moveSpeed;


    private void Awake()
    {
        Instance = this;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        MovementPattern();
    }

    public override void MovementPattern()
    {
        rb2D.MovePosition(rb2D.position + movementDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
