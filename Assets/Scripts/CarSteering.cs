using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour
{

    Rigidbody2D rb2d;

    [SerializeField] float AccelerationPower = 5f;
    [SerializeField] float steeringPower = 5f;
    float steeringAmount, speed, direction;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        steeringAmount = -Input.GetAxis("Horizontal");
        speed = Input.GetAxis("Vertical") * AccelerationPower;
        direction = Mathf.Sign(Vector2.Dot(rb2d.velocity, rb2d.GetRelativeVector(Vector2.up)));
        rb2d.rotation += steeringAmount * steeringPower * rb2d.velocity.magnitude * direction;

        rb2d.AddRelativeForce(Vector2.up * speed);

        rb2d.AddRelativeForce(-Vector2.right * rb2d.velocity.magnitude * steeringAmount / 2);
    }

}
