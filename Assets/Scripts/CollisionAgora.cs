using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionAgora : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger occurred with: " + other.gameObject.name);
       
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger out with: " + other.gameObject.name);
    }
}
