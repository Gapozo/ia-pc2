using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundLimiter : MonoBehaviour
{
  
    [SerializeField]
    [Range(1, 20)]
    private int radius;
    private float SizeX;

    public Transform Target;
    [SerializeField]
    private Transform Follower;

    private void Awake()
    {
    }

    private void Update()
{
      
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
