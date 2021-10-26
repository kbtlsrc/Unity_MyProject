using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] Transform camera;
        [SerializeField] CameraSetting setting;

        void Update()
        {
            RotationFollow();
            MovementFollow();
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
