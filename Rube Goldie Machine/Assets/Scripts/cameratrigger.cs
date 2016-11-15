using UnityEngine;
using System.Collections;

public class cameratrigger : MonoBehaviour
{

    //public GameObject camToActivate;
    public int camNumber;

    public camerasscript controller;

    void OnTriggerEnter(Collider other)
    {

        controller.DeactivateCameras();
        controller.activateCamera(camNumber);

    }
}