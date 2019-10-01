using UnityEngine;

public class Limiter : MonoBehaviour
{
    [Range(1, 20)]
    [SerializeField]
    private int SizeY = 5;
    private float SizeX;

    [SerializeField]
    private Transform Target;
    [SerializeField]
    private Transform Follower;

    private void Awake()
    {
        SizeX = SizeY * (16f / 9f);
    }

    private void Update()
    {
        /*float posX = Target.position.x;
        if(posX < -SizeX)
        {
            posX = -SizeX;
        }
        if (posX > SizeX)
        {
            posX = SizeX;
        }

        float posY = Target.position.y;
        if (posY < -SizeY)
        {
            posY = -SizeY;
        }
        if (posY > SizeY)
        {
            posY = SizeY;
        }

        Follower.position = new Vector3(posX, posY, -10);*/

        Follower.position = new Vector3(
            Mathf.Clamp(Target.position.x, -SizeX, SizeX),
            Mathf.Clamp(Target.position.y, -SizeY, SizeY),
            -10);
    }

    private void OnDrawGizmos()
    {
        float h = SizeY * 2;
        float w = h * (16f / 9f);
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, new Vector3(w, h));
    }
}
