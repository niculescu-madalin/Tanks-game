using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UprageShellPickUpController : MonoBehaviour
{

    private  void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) {
            this.gameObject.SetActive(false);
            other.gameObject.GetComponent<TankShooting>().upgradeShell();
        }
    }
}
