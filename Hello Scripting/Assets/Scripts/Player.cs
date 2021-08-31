using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randDir = Random.onUnitSphere;
        rb.AddForce(new Vector3(randDir.x, 0, randDir.y) * Random.Range(1,100));
    }
}
