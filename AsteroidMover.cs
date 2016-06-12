using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AsteroidMover : MonoBehaviour{

    public float speed = 1.0f;
    
    void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + new Vector3(0.1f, 0, 0), Time.deltaTime * speed);
    }
}
