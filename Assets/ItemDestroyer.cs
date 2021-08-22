using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    public Vector3 unitychanposition;


    // Update is called once per frame
    void Update()
    {
        unitychanposition = GameObject.Find("unitychan").transform.position;
        if(this.transform.position.z + 5 <= unitychanposition.z)
        {
            Destroy(this.gameObject);
        }
    }
}
