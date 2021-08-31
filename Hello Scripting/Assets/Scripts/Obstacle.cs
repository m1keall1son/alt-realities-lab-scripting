using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Color color;

    MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        render.material.color = color;
    }
}
