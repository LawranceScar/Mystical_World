using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using CandiceAIforGames.AI;

public class MainPatrol : CandiceAIController
{
   /* public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    public float WaitingTime = 1f;
    private float SaveWaiting;

    public static bool IsWalking; 



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GotoNextPoint();

        SaveWaiting = WaitingTime; 
    }


    void GotoNextPoint()
    {

        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        GotoIf();
    }

    public void GotoIf()
    {
        if (IsWalking == false)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                WaitingTime -= Time.deltaTime;
                if (WaitingTime <= 0)
                {
                    GotoNextPoint();
                    WaitingTime = SaveWaiting;
                }
            }
        }
    } */
}
