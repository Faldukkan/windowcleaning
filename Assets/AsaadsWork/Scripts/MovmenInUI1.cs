using UnityEngine;

public class MovmenInUI1 : MonoBehaviour
{
 public float speed = 5f;
 public GameObject MovmentPlace;
 public AudioSource CramUp;
 public AudioSource CramRight;
 //MovmenInUI u;
public void OnTriggerStay(Collider other) {
    if (other.tag=="Right"){
        Debug.Log("right");
        CramRight.Play();
    MovmentPlace.transform.Translate(Vector3.right * speed * Time.deltaTime);
}
 else if (other.tag=="Left"){
     Debug.Log("left");
     CramRight.Play();
    MovmentPlace.transform.Translate(Vector3.left * speed * Time.deltaTime);
}
else if (other.tag=="Up"){
     Debug.Log("Up");
     CramUp.Play();
    MovmentPlace.transform.Translate(Vector3.up * speed * Time.deltaTime);
}
else if (other.tag=="Down"){
     Debug.Log("Down");
     CramUp.Play();
    MovmentPlace.transform.Translate(Vector3.down * speed * Time.deltaTime);
}
    }
   
   

 
}






