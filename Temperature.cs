using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
  
    public Health health;
    public int damageDealt = 2;
    public float nowTemp = 36.7f;
    public float normalTemp = 36.7f;
    public float criticalTemp = 34.5f;
    public float rateTemp = 0.1f;
    public float rateTempTimer = 1;
    public float rateTempDelay = 2;

    void Update()
    {
        nowTemp -= rateTemp * Time.deltaTime;
        print(nowTemp);
        if (nowTemp <= criticalTemp)
        {

            if (nowTemp <= criticalTemp)
            {
                health.TakeDamage(damageDealt);
                rateTempTimer += rateTempDelay;
            }
            else
            {
                rateTempTimer -= Time.deltaTime;
            }
        }
    }
}
