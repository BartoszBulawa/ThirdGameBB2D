using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    private Rigidbody2D myBody;
    private string Monster_is_moving = "MonsterIsMoving";
    private Animator anim;



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("SkeletonHand"))
    //    {
    //        FindObjectOfType<Score>().Reward_for_destroyed_monser();
    //        Destroy(gameObject);
    //    }
    //}


    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() 
    {
        if (Player.Player_is_stopping_Monsters)
        {
            myBody.velocity = new Vector2(0, myBody.velocity.y);
            anim.SetBool(Monster_is_moving, false);
        }
       
        else
        {
            myBody.velocity = new Vector2(speed, myBody.velocity.y);
            anim.SetBool(Monster_is_moving, true);
        }
    }
}
