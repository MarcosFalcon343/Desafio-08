using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    private int cameraNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(cameraNumber >= cameras.Length-1)
            {
                cameras[cameras.Length-1].SetActive(false);
                cameraNumber = 0;
                cameras[cameraNumber].SetActive(true);
            }
            else
            {
                cameras[cameraNumber].SetActive(false);
                cameraNumber++;
                cameras[cameraNumber].SetActive(true);
            }
        }
    }
}
