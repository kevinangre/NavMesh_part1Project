﻿using UnityEngine;
using System.Collections;

public class waypoint : MonoBehaviour
{
    [SerializeField]
    float debugDrawRadius = 1.0F;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, debugDrawRadius);
    }
}
