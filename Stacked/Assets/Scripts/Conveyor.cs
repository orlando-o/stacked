using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public bool objectOnConveyor = false;

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            objectOnConveyor = true;
            other.attachedRigidbody.AddForce(transform.right * -0.0039f, ForceMode.VelocityChange);
        }
    }

    void OnTriggerExit(Collider other)
    {
        objectOnConveyor = false;
    }
}
