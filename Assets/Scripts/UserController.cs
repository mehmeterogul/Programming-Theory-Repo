using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                HandleDestroy(hit); // ABSTRACTION
            }
        }
    }

    private static void HandleDestroy(RaycastHit hit) // ABSTRACTION
    {
        GameObject temp = hit.collider.gameObject;

        if (temp.CompareTag("Obstacle"))
        {
            Destroy(temp);
        }
    }
}
