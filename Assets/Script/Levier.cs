using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour
{

    public void activate()
    {
        if (this.transform.rotation.x > 40.0f && this.transform.rotation.x < 60.0f)
        {
            this.transform.Rotate(this.transform.rotation.x + 90.0f, 0.0f, 0.0f, Space.Self);
            this.transform.Translate(this.transform.localPosition.x, this.transform.localPosition.y + 1.0f, this.transform.localPosition.z -1.0f,Space.Self);
        }
        if (this.transform.rotation.x > -160.0f && this.transform.rotation.x < 100.0f)
        {
            this.transform.Rotate(this.transform.rotation.x + 90.0f, 0.0f, 0.0f, Space.Self);
            this.transform.Translate(this.transform.localPosition.x, this.transform.localPosition.y + 1.0f, this.transform.localPosition.z - 1.0f, Space.Self);
        }
        if (this.transform.rotation.x > 110.0f && this.transform.rotation.x < 150.0f)
        {
            this.transform.Rotate(this.transform.rotation.x + 90.0f, 0.0f, 0.0f, Space.Self);
            this.transform.Translate(this.transform.localPosition.x, this.transform.localPosition.y - 1.0f, this.transform.localPosition.z + 1.0f, Space.Self);
        }
        if (this.transform.rotation.x > -90.0f && this.transform.rotation.x < 0.0f)
        {
            this.transform.Rotate(this.transform.rotation.x + 90.0f, 0.0f, 0.0f, Space.Self);
            this.transform.Translate(this.transform.localPosition.x , this.transform.localPosition.y - 1.0f, this.transform.localPosition.z + 1.0f, Space.Self);
        }
    }
}
