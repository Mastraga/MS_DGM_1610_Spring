using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]

    public int curHP;
    public int maxHP;
    

    [Header ("Player Movement")]
    public float movespeed = 5.0f;  // Speed at which the player moves
    private Rigidbody2D rb;  // Store the referenced 2D Rigidbody

    //Vector2(X,Y)
    Vector2 movement;

    [Header ("Player Combat")]
    public float attackRange; // Range at which the player can attack
    public float attackRate;
    private float lastAttackTime; // Cooldown in between attacks
    public int damage;  
    public LayerMask enemyLayer;




    // Start is called before the first frame update
    void Start()
    {
        //Reference the 2D Rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input for Left Right Movement
        movement.x = Input.GetAxis("Horizontal"); 
        // Input for Up Down Movement
        movement.y = Input.GetAxis("Vertical"); 
    }

    //Set number of calls per frame, better for physics
    void FixedUpdate()
    {
        //Apply physics and move the character
        rb.MovePosition(rb.position + (movement * movespeed * Time.deltaTime));  
    }

    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    void Die()
    {
        Debug.Log("Player has retired to the green plains of Elysium");
    }
}
