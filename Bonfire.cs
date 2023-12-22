using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float fireTime = 15;
    public float heatDiss = 0.2f;

    void Update()
    {
        fireTime -= Time.deltaTime;
        if (fireTime <= 0)
        {
            fireTime -= Time.deltaTime;

            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            Temperature temperature = other.GetComponent<Temperature>();

            if (temperature.nowTemp < temperature.normalTemp);
            {
                temperature.nowTemp += heatDiss * Time.deltaTime;
            }
        }
    }
}
