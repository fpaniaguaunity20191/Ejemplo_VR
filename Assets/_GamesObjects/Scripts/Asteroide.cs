using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour {
    public GameObject prefabExplosion;
    public void Destroy()
    {
        Instantiate(prefabExplosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
