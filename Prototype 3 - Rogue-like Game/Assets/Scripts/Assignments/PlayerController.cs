using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]

    public int curHP;
    public int maxHP;
    public HealthBar healthBar;
    

    [Header ("Player Movement")]
    public float moveSpeed = 5.0f;  // Speed at which the player moves
    private Rigidbody2D rb;  // Store the referenced 2D Rigidbody

    //Vector2(X,Y)
    private Vector2 movement;
    private Vector2 direction;

    [Header ("Player Combat")]
    public float attackRange; // Range at which the player can attack
    public float attackRate;
    private float lastAttackTime; // Cooldown in between attacks
    public int damage;  
    public LayerMask enemyLayer;


    [Header("Inventory")]
    public int key;
    public int coins;
    public int gems;



    // Start is called before the first frame update
    void Start()
    {
        //Reference the 2D Rigidbody component
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;

        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        // Input for Left Right Movement
        movement.x = Input.GetAxis("Horizontal"); 
        // Input for Up Down Movement
        movement.y = Input.GetAxis("Vertical"); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >= attackRate)
            {
                Attack();
            }
        }
    }

    //Set number of calls per frame, better for physics
    void FixedUpdate()
    {
        //Apply physics and move the character
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.deltaTime));  
        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;
    }

    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;  //curHP = curHP - damage;
        healthBar.SetHealth(curHP);

        if(curHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("You lost and you should feel bad about yourself");
    }
}
