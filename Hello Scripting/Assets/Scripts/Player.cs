using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public float speed = 100.0f;
    Rigidbody rb;
    MeshRenderer render;
    Vector3 curDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 randDir = Random.onUnitSphere;
        //rb.AddForce(new Vector3(randDir.x, 0, randDir.y) * Random.Range(1,100));
        
        rb.AddForce(curDirection * speed);
        
        //kinematic
        //rb.position += curDirection * speed * Time.deltaTime;
    }

    void OnMove(InputValue input)
    {
        Vector2 dir = input.Get<Vector2>();
        curDirection = new Vector3(dir.x, 0, dir.y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Obstacle obs = collision.gameObject.GetComponent<Obstacle>();
            render.material.color = obs.color;
        }
    }
}
