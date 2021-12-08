using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
   private void OnCollisionEnter(Collision collisionInfo)
   {
       if(collisionInfo.gameObject.name == "Player")
       {
           collisionInfo.gameObject.transform.SetParent(transform);
       }
   }

   private void OnCollisionExit(Collision collisionInfo)
   {
       if(collisionInfo.gameObject.name == "Player")
       {
           collisionInfo.gameObject.transform.SetParent(null);
       }
   }
}