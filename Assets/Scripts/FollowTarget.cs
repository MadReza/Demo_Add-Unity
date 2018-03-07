using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    public Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    float mArriveThreshold = 0.05f;

    void Update ()
    {
        if(mTarget != null)
        {
            // TODO: Make the enemy follow the target "mTarget"
            //       only if the target is close enough (distance smaller than "mFollowRange")
            //      Get distance by simple substraction.
            float distance = Vector2.Distance(transform.position, mTarget.position);

            if (distance < mFollowRange)
            {
                Vector3 directionToGo = mTarget.position - transform.position;
                directionToGo.Normalize();

                transform.position += directionToGo * Time.deltaTime * mFollowSpeed;
            }
        }
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}
