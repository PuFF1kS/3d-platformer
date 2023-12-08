using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        Player player = other.GetComponent<Player>();

        player.CollectCoins();

        Destroy(gameObject);
    }

}
