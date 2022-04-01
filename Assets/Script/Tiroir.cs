using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiroir : MonoBehaviour
{
    private bool ouvert = false;
    private float speed = 0.005f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
        if (ouvert == true&&(Mathf.Sqrt(this.transform.localPosition.x*this.transform.localPosition.x)<=4.5f && Mathf.Sqrt(this.transform.localPosition.z* this.transform.localPosition.z) <=4.5f))
        {
            if (this.transform.localRotation.y == 0.5f)
            {
                this.transform.Translate(new Vector3(speed, 0f, 0f));
            }
            if (this.transform.localRotation.y == 1f)
            {
                this.transform.Translate(new Vector3(0f, 0f, -speed));
            }
            if (this.transform.localRotation.y == 1.5f)
            {
                this.transform.Translate(new Vector3(-speed, 0f, 0f));
            }
            if (this.transform.localRotation.y == 0f)
            {
                this.transform.Translate(new Vector3(0f, 0f, speed));
            }
            this.GetComponent<BoxCollider>().enabled = false;
            
        } 
    }
    public void code()
    {
        ouvert = true;
    }
}
