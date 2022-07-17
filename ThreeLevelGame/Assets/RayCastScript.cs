using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down * 5, Color.green);
        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 5))
        {
            Debug.Log("Hit");
            if(hit.collider.gameObject.name=="FPSController")
            {
                Destroy(GetComponent<Rigidbody>());
            }
        }
    }
}
