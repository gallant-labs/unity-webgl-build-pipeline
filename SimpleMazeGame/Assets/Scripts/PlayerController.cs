using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float health=10f;
    public float horizontal;
    public float vertical;
    public float speed = 4.5f;


    // Start is called before the first frame update
    void Start()
    {
        // add something
    }

    // Update is called once per frame
    void Update()
    {
        // need to add movement logic here
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        transform.Translate(Vector3.left * horizontal * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * vertical * Time.deltaTime * speed);


       DisableOnDeath();
    }

    // Disable once dead
    public void DisableOnDeath()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }

   
}
