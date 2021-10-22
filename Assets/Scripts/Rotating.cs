using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events { 
public class Rotating : MonoBehaviour
{
   
    [SerializeField] private RotateSetting rs;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rs.Speed * Time.deltaTime);
        
    }
}
        }