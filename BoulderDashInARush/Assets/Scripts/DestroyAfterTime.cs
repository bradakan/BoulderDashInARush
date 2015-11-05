using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("DestroySelf", 0.5f);
    }

    // Update is called once per frame
    void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}
