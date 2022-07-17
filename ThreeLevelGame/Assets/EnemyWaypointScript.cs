using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypointScript : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed=5;
    int currentWaypoint;
    Vector3 target, moveDirection;

    // Update is called once per frame
    void Update()
    {
        target = waypoints[currentWaypoint].position;
        moveDirection = target - transform.position;
        if(moveDirection.magnitude < 1)
        {
            currentWaypoint = ++currentWaypoint % waypoints.Length;
        }
        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }
}
