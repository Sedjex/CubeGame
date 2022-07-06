using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class CubeRoad : MonoBehaviour
{
    public GameObject bonusEffect;
    public Transform goal;
    LineRenderer lineRenderer;


    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = agent.path.corners.Length;
        lineRenderer.SetPositions(agent.path.corners);
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bonus":
                {
                    Instantiate(bonusEffect, transform.position, Quaternion.identity);
                }
                break;

            case "Boom":
                print("boom");
                break;
        }
    }

}
