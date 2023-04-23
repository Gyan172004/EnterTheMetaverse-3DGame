using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{  
   public Transform playerObj;
   protected NavMeshAgent enemyMesh;
    // Start is called before the first frame update
    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMesh.SetDestination(playerObj.position);
    }
}
