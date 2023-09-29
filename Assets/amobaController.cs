using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amobaController : MonoBehaviour
{
    
  [SerializeField]
  float speed = 1;

  int food = 0;

    void Update()
    {
        float xMovement = Input.GetAxisRaw("Horizontal");
        float yMovement = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(xMovement, yMovement);
        movement = movement.normalized * speed * Time.deltaTime;

        transform.Translate(movement);

    }
        void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "algea")
            {
                food++;
                Debug.Log(food);
            }
        }
}
