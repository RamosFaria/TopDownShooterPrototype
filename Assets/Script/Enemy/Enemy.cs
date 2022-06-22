using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class Enemy : Entity
{

    protected NavMeshAgent agent;

    public virtual void Awake()
    {
        this.agent = this.GetComponent<NavMeshAgent>();
        this.agent.updateRotation = false;
        this.agent.updateUpAxis = false;
    }

}
