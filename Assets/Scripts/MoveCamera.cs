using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
   public float speed = 20;
   private Vector3 startPosition3;
   // Use this for initialization
   void Start ()
   {
      startPosition3 = transform.position;
   }
	
   // Update is called once per frame
   void Update ()
   {
      float vertValue = Input.GetAxis ("CameraV");
      float horValue = Input.GetAxis ("CameraH");

      if (Input.GetButtonDown ("ResetCamera")) {
         transform.position = startPosition3;
      } else {
         if (vertValue != 0) {
            transform.Translate (Vector3.up * vertValue * speed * Time.deltaTime);
         }
         if (horValue != 0) {
            transform.Translate (Vector3.right * horValue * speed * Time.deltaTime);
         }
      }
   }

}
