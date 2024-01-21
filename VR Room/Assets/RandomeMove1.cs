using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomeMove1 : MonoBehaviour
{
    public float Speed = 100f;
    Vector3 RandomeDirection;
 
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RandomeDirection = Random.insideUnitSphere*Time.deltaTime;
         Vector3 Movement = RandomeDirection * Speed*Time.deltaTime;
        transform.Translate(Movement);

       
                
        
    }

  

}
 