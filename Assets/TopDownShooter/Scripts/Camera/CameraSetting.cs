using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu (menuName = "TopDownShooter/Camera/Camera Settings")]
   
    public class CameraSetting : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float speed = 1;
        public float Speed { get { return speed; } }

        [Header("Position")]
        [SerializeField] private Vector3 positionOffset;
        public Vector3 PositionOffset { get { return positionOffset; } }

        [SerializeField] private float positionLerp;
        public float PositionLerp { get { return positionLerp; } }
    }

}
