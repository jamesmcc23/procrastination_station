using UnityEngine;

public class player_control_3D : MonoBehaviour
{
    [SerializeField] float acceleration = 20f;
    [SerializeField] float decceleration = 1f;
    [SerializeField] float sprint_speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.rotation.Quaternion += 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.rotation -= (acceleration + sprint_speed);
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

    }
}
