using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HugeJump : MonoBehaviour
{
    
    public static int HugeJumpColleced = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HugeJumpColleced ++;
            Destroy(gameObject);
        }
    }
    public static void DoHugeJump()
    {
        Player.myBody.AddForce(new Vector2(0f, 18f), ForceMode2D.Impulse);
        HugeJumpColleced--;
    }


}
