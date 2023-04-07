using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private GameObject textField;

    private void OnTriggerEnter(Collider other)
    {
        this.textField.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        this.textField.SetActive(false);
    }
    
}
