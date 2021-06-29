using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsmove : MonoBehaviour
{
    public float speed;
    private float spd;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
