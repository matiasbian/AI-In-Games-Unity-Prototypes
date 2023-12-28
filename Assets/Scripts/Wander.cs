using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomValue = Random.Range(-1.0f, 1.0f);
        float randomAngle = Mathf.Acos(randomValue) * Mathf.Rad2Deg * (Random.Range(0,100) < 50 ? 1 : -1);

        float x = Mathf.Cos(randomAngle) - Mathf.Sin(randomAngle);
        float y = Mathf.Sin(randomAngle) + Mathf.Cos(randomAngle);
        Vector2 wanderDir = new Vector2(x, y) * radius;

        Vector2 wanderPosition = player.position;
        wanderPosition += (Vector2)(player.up * radius);
        wanderPosition += wanderDir;

        transform.position = wanderPosition;
    }
}
