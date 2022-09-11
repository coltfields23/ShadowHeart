using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cameramovement : MonoBehaviour
{

    public float cameraposx = 0;
    public float cameraposy = 0;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x + cameraposx, target.transform.position.y + cameraposy, -10);
    }
}
