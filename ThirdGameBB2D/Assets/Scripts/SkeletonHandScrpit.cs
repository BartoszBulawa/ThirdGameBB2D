using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHandScrpit : MonoBehaviour
{

    private Rigidbody2D Skeleton_Hand_RigidBody2d;
    public static int SkeletonHandBonus_Collected = 0;


    private string topRangeTrigger = "SkeletonHandTopTrigger";
    private string finishPosition = "SkeletonHandFinishPosition";


    private bool Top_Range_trigger_has_been_reached = false;
    private bool SkeletonHand_has_killed_the_monster = false;


    void Awake()
    {
        Skeleton_Hand_RigidBody2d = GetComponent<Rigidbody2D>();
        Is_SkeletonHand_Has_missed_or_killed_the_monster();
    }
    private void Update()
    {
        if(Is_SkeletonHand_Has_missed_or_killed_the_monster().Equals(false) && Player.SkeletonHand_is_executing)
        {
            Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, 10);  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SkeletonHand_has_killed_the_monster = true;
            FindObjectOfType<Score>().Reward_for_destroyed_monser();
            Destroy(collision.gameObject);
        }
     
        else if (collision.gameObject.CompareTag(topRangeTrigger))
        {
            Top_Range_trigger_has_been_reached = true;
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
            Player.SkeletonHand_is_executing = false;
        }
    }
    private void pullBackSkeletonHand()
    {
        Skeleton_Hand_RigidBody2d.velocity = new Vector2(0, -10);
    }
    private bool Is_SkeletonHand_Has_missed_or_killed_the_monster()
    {
        if (Top_Range_trigger_has_been_reached || SkeletonHand_has_killed_the_monster)
            return (true);
        else
            return (false);
    }

}
