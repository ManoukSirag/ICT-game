using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint1;

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = RespawnPoint1.transform.position;
    }
}
