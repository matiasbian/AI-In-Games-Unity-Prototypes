using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] float speed;
    Vector2 currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 fleeDistanceNormalized = (transform.position - target.position).normalized;
        Vector2 desiredPosition = fleeDistanceNormalized * speed * Time.deltaTime;
        Vector2 flee = desiredPosition - currentSpeed;

        transform.position = (Vector2)transform.position + flee;

    }
}
