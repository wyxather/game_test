using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] List<Transform> points;
    int index;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
	index = 0;
    }

    void FixedUpdate()
    {
	RaycastHit2D ray = Physics2D.Raycast(transform.position, target.position - transform.position);
	if (ray.collider != null && ray.collider.CompareTag("Player"))
	{        
            agent.SetDestination(target.position);
            agent.speed = 5.0f;
	}
        else
	{
	    if (Vector3.Distance(points[index].position, transform.position) <= 1.0f)
	    {
		index += 1;
		if (index >= points.Count)
		{
		    index = 0;
		}
	    }
	    agent.SetDestination(points[index].position);
            agent.speed = 1.0f;
	}
    }

    // Update is called once per frame
    void Update()
    {
    }
}
