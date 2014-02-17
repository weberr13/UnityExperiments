using UnityEngine;
using System.Collections;

public class BustDownDoor : MonoBehaviour
{
   public Camera theCamera;
   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void OnMouseDown ()
   {
      if (theCamera) {
         rigidbody.AddForce (theCamera.transform.forward * 500);
      } else {
         rigidbody.AddForce (-transform.forward * 500);
      }
   }

}
