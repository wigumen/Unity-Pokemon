using UnityEngine;

public class smoothcam : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform Target;

    private void Start()
    {
        transform.position = PlayerStats.playerPos;
    }

    private void Update()
    {
        Vector3 newPosition = Target.position;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}