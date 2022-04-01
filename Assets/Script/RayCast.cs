using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    // Start is called before the first frame update
    public Camera camera;
    public GameObject focus;// Object selectionnée
    private float distance = 4f;
    // Update is called once per frame

    private void Start()
    {
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, Input.mousePosition, Color.red);
        RaycastHit toucher;
        
        if (Physics.Raycast(ray, out toucher))
        {
            Transform choisi = toucher.transform;
          
            if (choisi.tag =="selectible")
            {
                focus = toucher.collider.gameObject;
               // verifier la distance
                if(
                    (
                     (this.transform.position.x - focus.transform.position.x)
                    *(this.transform.position.x - focus.transform.position.x)
                    +(this.transform.position.z - focus.transform.position.z) 
                    *(this.transform.position.z - focus.transform.position.z)
                    ) 
                    <= distance * distance
                    && Input.GetKeyDown(KeyCode.E))
                {
                    print("yues");
                   focus.gameObject.GetComponent<Selectable>().Interagir();
                }
            }
            else
            {
                focus = null;
            }
        }
    }

}
