using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentMover : MonoBehaviour
{
    [Header("Navigation Components")]
    public NavMeshAgent agent;
    public Transform moveTarget;
    public float defaultMoveSpeed = 5;

    public bool doMoveAtDoubleSpeed;
    public int myInteger = -56;
    public float myFloat = 4.5f;
    public string myString = "wassup world";





    void DoubleNumber (float num)
    {
        num = num * 2; 
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(moveTarget.position);



        if (doMoveAtDoubleSpeed == true)
        {
            agent.speed = defaultMoveSpeed * 2; 
        }
        else
        {
            agent.speed = defaultMoveSpeed; 
        }




    }
}
