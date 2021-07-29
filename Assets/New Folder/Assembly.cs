using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour //PascalCasing
{
    [SerializeField] private float speed = if; //camelCasing
    [SerializeField] private GameObject goal2;


    // == equal to
    // != not equal to
    // < less than
    // > greater than
    // <= less than or equal to
    // >= greater than or eqal to

    void Update()
    {
        // float distance = (goal.transform.position - transform.position).magnitude;

        float distance2 = Vector2.Distance(transform.position, goal.transform.position);

        if (distance2 > 0.0f)
        {
            //the direction from A to B
            //direction = B - A
            Vector2 direction = (goal.transform.position - transform.position).normalized;
            Vector2 aiPosition = transform.position;
            aiPosition += direction * speed Time.deltaTime;
            transform.position = aiPosition
        }
    }

}