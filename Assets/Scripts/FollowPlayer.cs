using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Start()
    {
        transform.Rotate(180,0,180);
    }
    void Update()
    {
        transform.position = player.position + offset;
    }
}
