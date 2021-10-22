using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events{ 
    [CreateAssetMenu (menuName="Events/Action2/Jumping Settings")]
public class JumpingSetting : ScriptableObject
{
        [SerializeField] private Vector3 jump;
        public Vector3 Jump { get { return jump; } }

  
}
}
