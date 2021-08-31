using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float speed = 100.0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 randDir = Random.onUnitSphere;
        //rb.AddForce(new Vector3(randDir.x, 0, randDir.y) * Random.Range(1,100));
    }

    void OnMove(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();
        rb.AddForce(new Vector3(dir.x, 0, dir.y) * speed);
    }
}
