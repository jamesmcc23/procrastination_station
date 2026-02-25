using UnityEngine;

public class player_controller : MonoBehaviour
{
    #region "Variables"
    [SerializeField] private float acceleration = 10.00f;
    private float sprint_speed;
    [SerializeField] private float decceleration = .7f;
    private Rigidbody2D rb;
   
    #endregion

   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }
    void FixedUpdate()
    {
        

        
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocityX += (acceleration + sprint_speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocityX -= (acceleration + sprint_speed);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocityY += (acceleration + sprint_speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocityY -= (acceleration + sprint_speed);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint_speed = acceleration * 0.5f;
        }
        else
        {
             sprint_speed = 0;
        }
        rb.linearVelocityX *= decceleration;
        rb.linearVelocityY *= decceleration;
    }

}
