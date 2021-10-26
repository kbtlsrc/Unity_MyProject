using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody rb;
        [SerializeField] private InputSettings ins;
        [SerializeField] private MovementSettings ms;
        void Update()
        {
            rb.MovePosition(rb.position +(rb.transform.forward * ins.Vertical * ms.VerticalSpeed));
            rb.MovePosition(rb.position +(rb.transform.right * ins.Horizontal * ms.HorizontalSpeed));
        }
    }

}
