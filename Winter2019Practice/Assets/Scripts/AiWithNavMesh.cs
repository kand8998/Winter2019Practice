using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiWithNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player, destination;
    private void Start()
    {
        destination = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
        
    }
}