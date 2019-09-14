using UnityEngine;
using System.Collections;

public class thanosZombie : MonoBehaviour {
  

  // Use this for initialization
  void Start () {
      //start the walking animation
   // GetComponent<Animation>().Play ("walk");
  }


  //for this to work both need colliders, one must have rigid body, and the zombie must have is trigger checked.
  void OnTriggerEnter (Collider col)
  {
    //first disable the zombie's collider so multiple collisions cannot occur
    GetComponent<BoxCollider>().enabled = false;
    //destroy the bullet
    Destroy(col.gameObject);
    //stop the zombie from moving forward by setting its destination to it's current position
   // agent.destination = gameObject.transform.position;
    //stop the walking animation and play the falling back animation
    GetComponent<Animation>().Stop ();
   // GetComponent<Animation>().Play ("back_fall");
    //destroy this zombie in six seconds.
    Destroy (gameObject, 3);
  
  }

}
