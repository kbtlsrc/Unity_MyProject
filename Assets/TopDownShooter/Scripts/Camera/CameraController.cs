using System.Collections;
using System.Collections.Generic;
using TopDownShooter.Shooting;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] Transform camera;
        [SerializeField] CameraSetting setting;
        public ShooterManager shmanager;

        void Update()
        {
            RotationFollow();
            MovementFollow();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Try shoot");
                shmanager.Shoot(camera.position, camera.forward);
            }
        }

        private void RotationFollow()
        {

            camera.rotation = Quaternion.Lerp(camera.rotation, 
                Quaternion.LookRotation(target.position - camera.position),
                Time.deltaTime * setting.Speed);

        }

        private void MovementFollow()
        {
            camera.position = Vector3.Lerp(camera.position, target.position + setting.PositionOffset,
                Time.deltaTime * setting.PositionLerp);
        }
    }

}
