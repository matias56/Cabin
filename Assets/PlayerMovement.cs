using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController cc;

    public float speed = 12f;
    public float jumpPower = 3f;
    public float gravity = -9.81f * 2;
    bool isMoving;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundLayer;

    Vector3 velocity;

    bool isGrounded;
    private Vector3 lastPos = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        cc.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpPower * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        if(lastPos != gameObject.transform.position)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        cc.Move(velocity * Time.deltaTime);

        lastPos = gameObject.transform.position;
    }
}
