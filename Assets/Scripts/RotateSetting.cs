using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{
    [CreateAssetMenu(menuName = "Events/Action1/Rotate Setting")]
    public class RotateSetting : ScriptableObject
    {
        [SerializeField] private float speed = 1;
        public float Speed { get { return speed; } }

    }
}
