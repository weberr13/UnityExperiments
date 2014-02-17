using UnityEngine;
using System.Collections;

public class BustDownDoor : MonoBehaviour
{

   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void OnMouseDown ()
   {
      rigidbody.AddForce (-transform.forward * 500);
      rigidbody.useGravity = true;
   }

}
