using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour

{
    public NavMeshAgent enemy;
    public Transform Player;
    public GameObject DeathMenuUI;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LILI"))
        {
            DeathMenuUI.SetActive(true);
            Debug.Log("Spiders...");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
