using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovmenInUI : MonoBehaviour
{
 public float speed = 5f;
    

   public void Update()

    {  
       
    }

    public void  MoveForward()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveBackward()
    {
        
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }


}






