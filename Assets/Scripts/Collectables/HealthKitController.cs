using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitController : MonoBehaviour
{
    public float m_healthAmount;

    private  void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) {
            this.gameObject.SetActive(false);
            other.gameObject.GetComponent<TankHealth>().TakeHealthKit(m_healthAmount);
        }
    }
}
