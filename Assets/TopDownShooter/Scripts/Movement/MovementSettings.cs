using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Movement
{
    [CreateAssetMenu (menuName = "TopDownShooter/Movement/ Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        public float HorizontalSpeed = 5;
        public float VerticalSpeed = 5;
        
    }

}
