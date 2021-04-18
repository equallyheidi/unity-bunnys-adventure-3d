using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cars : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

      
        agent.autoBraking = false;

        GotoNextPoint();
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
        
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject.Find("Rabbit 1").GetComponent<BunnyMovement>().Death();
        StartCoroutine(ExecuteAfterTime(3));

    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject.Find("GameEnd").GetComponent<GameEnding>().Death();
    }
    
    
}
