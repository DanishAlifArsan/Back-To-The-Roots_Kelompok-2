using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("Miner"))
        {
            coll.transform.position = Vector2.MoveTowards(coll.transform.position, transform.position, 2 * Time.deltaTime);
        }
    }
}