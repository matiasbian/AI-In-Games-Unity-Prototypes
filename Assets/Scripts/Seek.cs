using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
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
        Vector2 targetNormalizedDistance = (target.position - transform.position).normalized;
        Vector2 desiredPosition = targetNormalizedDistance * speed * Time.deltaTime;

        Vector2 seek = desiredPosition - currentSpeed;
        //currentSpeed = seek;
        Debug.Log(seek);
        transform.position = (Vector2)transform.position + seek;
    }
}
