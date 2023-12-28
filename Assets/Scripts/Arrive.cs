using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float maxSpeed;
    [SerializeField] float deceleration;

    Vector2 currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 distance = target.position - transform.position;
        Vector2 distanceAtMaxSpeed = distance.normalized * maxSpeed * Time.fixedDeltaTime;
        Vector2 arriveSpeed = distance * deceleration * Time.fixedDeltaTime;

        Vector2 finalSpeed = (arriveSpeed.magnitude > distanceAtMaxSpeed.magnitude ? distanceAtMaxSpeed : arriveSpeed) - currentSpeed;

        transform.position = (Vector2)transform.position + finalSpeed;

    }
}
