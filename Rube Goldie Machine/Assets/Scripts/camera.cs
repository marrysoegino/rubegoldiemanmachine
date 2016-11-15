using UnityEngine;
using System.Collections;

public class cameracontroller : MonoBehaviour
{
    //public GameObject Camera1;
    // public GameObject Camera2;

    public GameObject[] Cameras;

    // Use this for initialization
    void Start()
    {
        //Camera1.SetActive(true);
        //Camera2.SetActive(false);
        DeactivateCameras();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Camera1.SetActive(!Camera1.active);
            //Camera2.SetActive(!Camera2.active);
            DeactivateCameras();
            if (currect)
                currentCam += 1;
            Cameras[currectCam].SetActive(true);
        }
    }
    public void DeactivateCameras()
    {
        for (int i = 0; i < Camera.Length; i++)
        {
            Cameras[i].SetActive(false);
        }
    }
}
