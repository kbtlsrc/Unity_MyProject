using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{
    public class CameraControl : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private Transform camera;
        [SerializeField] private float speed = 3;

        // Update is called once per frame
        void Update()
        {


            camera.rotation = Quaternion.Lerp(camera.rotation, Quaternion.LookRotation(target.position - camera.position),Time.deltaTime * speed);

        }
    }

}
