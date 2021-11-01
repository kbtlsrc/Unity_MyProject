using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Health {
    public class healthCond : MonoBehaviour
    {
        [SerializeField] private float health = 100;


        public void Hit(float damage)
        {
            health -= damage;
            if (health <= 0)
                Debug.Log("Health zero");
            else
                Debug.Log("Current health: " + health);
        }




    }
}
