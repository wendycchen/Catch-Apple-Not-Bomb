using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    public float dropSpeed = -0.03f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, this.dropSpeed, 0);
        if (transform.position.y < -0.6f)
        {
            Destroy(gameObject);
        }
    }
}
