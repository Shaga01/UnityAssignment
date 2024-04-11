using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Bird"))
                {
                   
                    // Access the BirdController script of the hit bird
                   BirdControlelr birdController = hit.collider.GetComponentInParent<BirdControlelr>();
                    if (birdController != null)
                    {
                        
                        birdController.OnHitBird(1); 
                    }
                }
            }
        }
    }
}
