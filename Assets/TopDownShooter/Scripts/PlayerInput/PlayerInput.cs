using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private InputSettings inset;
        // Update is called once per frame
        private void Update()
        {
            inset.Horizontal = Input.GetAxis("Horizontal");
            inset.Vertical = Input.GetAxis("Vertical");
        }
    }

}
