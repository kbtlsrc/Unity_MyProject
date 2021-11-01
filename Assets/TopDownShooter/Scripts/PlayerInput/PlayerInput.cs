using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private InputSettings inset;
        [SerializeField] private InputSettings inputTower;
        private Vector3 mouseInput;
        // Update is called once per frame
        private void Update()
        {
            inset.Horizontal = Input.GetAxis("Horizontal");
            inset.Vertical = Input.GetAxis("Vertical");


            inputTower.Horizontal = (Input.mousePosition.x - mouseInput.x);
            mouseInput = Input.mousePosition;
        }
    }

}
