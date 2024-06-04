using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    
    Rigidbody rb;
    public float mX;
    public float mZ;
    public float Vr;


    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        Vr = PlayerVariables.instance.rotationSpeed;
    }


    void Update()
    {
        mX = Input.GetAxisRaw("Horizontal");
        mZ = Input.GetAxisRaw("Vertical");
        
    }

    private void FixedUpdate()
    {
        Displacement();
    }

    public void Displacement()
    {
        Vector3 movement = new Vector3(mX, 0, mZ).normalized;

        if (movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref Vr, 0.1f);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            rb.velocity = moveDirection * PlayerVariables.instance.speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
