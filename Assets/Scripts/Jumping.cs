using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Events
{
    public class Jumping : MonoBehaviour
    {
        [SerializeField] private Rigidbody rg;
        [SerializeField] private JumpingSetting js;
        // Update is called once per frame
        void Update()

        {
            bool spaceKey = Input.GetKeyDown(KeyCode.Space);
            if (spaceKey)
            {
                rg.AddForce(js.Jump, ForceMode.Impulse);
            }

        }
    }
}