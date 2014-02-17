using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour
{

   public float moveSpeed = 10f;
   public float turnSpeed = 50f;
   // Use this for initialization
   void Start ()
   {

   }
	
   // Update is called once per frame
   void Update ()
   {
      if (Input.GetAxis ("Vertical") > 0) {
         transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
      }
      if (Input.GetAxis ("Vertical") < 0) {
         transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
      }
      if (Input.GetAxis ("Horizontal") > 0) {
         transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
      }
      if (Input.GetAxis ("Horizontal") < 0) {
         transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
      }
   }

}
