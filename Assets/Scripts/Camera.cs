using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class Camera : MonoBehaviour
{

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public bool whichCamera = false;



    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(switchKey))        
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}