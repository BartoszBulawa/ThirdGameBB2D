using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPullingMonstersTrigger : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
