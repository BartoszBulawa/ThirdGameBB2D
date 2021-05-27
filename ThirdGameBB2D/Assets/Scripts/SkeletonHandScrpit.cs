using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHandScrpit : MonoBehaviour
{

    private Rigidbody2D Skeleton_Hand_RigidBody2d;
    private Transform MainHandPos;
    public static int SkeletonHandBonus_Collected = 0;


    private string topRangeTrigger = "SkeletonHandTopTrigger";
    private string finishPosition = "SkeletonHandFinishPosition";

    //public static int update_hand_initiator = 0;

    private bool trigger_used = false;

    private bool Check_condition()
    {
        return (trigger_used);
    }

    void Awake()
    {
        Skeleton_Hand_RigidBody2d = GetComponent<Rigidbody2D>();
        Check_condition();
    }
    private void Update()
    {
        if(trigger_used==false && Player.SkeletonHand_is_executing)
        {
            Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, 10);
            
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            trigger_used = true;
            FindObjectOfType<Score>().Reward_for_destroyed_monser();
            Destroy(collision.gameObject);
        }
     
        else if (collision.gameObject.CompareTag(topRangeTrigger))
        {
            trigger_used = true;
            pullBackSkeletonHand();
        }
        else if (collision.gameObject.CompareTag(finishPosition))
        {
            SkeletonHandBonus_Collected --;
            Player.SkeletonHand_is_executing = false;
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("BasePosForMainHand"))
        {
            Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, 0);
           // MainHandPos.position = new Vector3(0, -22, 563);
            Player.SkeletonHand_is_executing = false;
        }
    }

    //public void PlayerHasUsedTheSkeletonHand()
    //{
    //    MoveSkeletonsHandUp();
    //}
    //public void MoveSkeletonsHandUp()
    //{
    //    Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, 10);
    //}
    private void pullBackSkeletonHand()
    {
        Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, -10);
    }



}
