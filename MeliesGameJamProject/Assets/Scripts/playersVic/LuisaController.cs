﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuisaController : MonoBehaviour
{
    public float speed = 20;
    private Vector3 pos;

    private void Start()
    {

    }

    void Update()
    {

        pos = transform.position;
        pos.x += speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;
    }
}
