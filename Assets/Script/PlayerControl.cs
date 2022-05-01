using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform ActiveFollower, MainCharacter;

    private void OnTriggerEnter(Collider other) // sort by collision priority.
    {

        //if (other.gameObject.transform.tag == "Follower")
        //{

        //    other.gameObject.transform.parent = ActiveFollower.transform;
        //    ActiveFollower.SetAsFirstSibling();


        //    if (ActiveFollower.childCount > 1 || !ActiveFollower.GetChild(transform.childCount).gameObject.AddComponent<CollisionManager>())
        //    {
        //        ActiveFollower.GetChild(transform.childCount).gameObject.AddComponent<CollisionManager>();
        //        Debug.Log("addeddd");
        //    }


        //}

        if (other.gameObject.transform.tag == "Follower")
        {


            if (ActiveFollower.transform.GetComponentInChildren<PlayerControl>())
            {
                if (gameObject.transform.tag == "Stacked")
                {
                    other.gameObject.transform.parent = ActiveFollower.transform;
                    ActiveFollower.SetAsFirstSibling();
                }


            }



        }
        if (other.gameObject.transform.tag == "Player") // first node while we first hit other followers.
        {
            if (gameObject.transform.tag == "Stacked")
            {
                transform.gameObject.transform.parent = ActiveFollower.transform;
                ActiveFollower.SetAsFirstSibling();

            }
        }
    }










}





