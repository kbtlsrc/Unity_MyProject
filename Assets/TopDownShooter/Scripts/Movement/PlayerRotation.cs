using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;


namespace TopDownShooter.Movement
{
    public class PlayerRotation : MonoBehaviour
    {
        [SerializeField] private InputSettings inputTower;
        [SerializeField] private Transform tower;

        void Update()
        {
            tower.Rotate(0, inputTower.Horizontal, 0, Space.Self);
        }
    }
}