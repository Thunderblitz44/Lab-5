using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{

        public Transform target; // Reference to the target GameObject.
        public Transform footBone;
        void LateUpdate()
        {
            if (target != null)
            {
                // Set the follower's position to match the target's position.
                transform.position = footBone.position;
            }
        }
    }

