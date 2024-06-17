using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDroneTransformLerpMono : MonoBehaviour
{
    public Transform m_target;
    public Transform m_whatToMove;
    public float m_lerpSpeed = 0.1f;
    void Update()
    {
        if (m_target != null && m_whatToMove != null)
        {
            m_whatToMove.position = Vector3.Lerp(m_whatToMove.position, m_target.position, m_lerpSpeed);
            m_whatToMove.rotation = Quaternion.Lerp(m_whatToMove.rotation, m_target.rotation, m_lerpSpeed);
        }
    }
}
