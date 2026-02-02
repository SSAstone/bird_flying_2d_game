using UnityEngine;

public class TreeMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 2f;
    public float deadZoneX = -40f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZoneX)
        {
            Destroy(gameObject);
        }
    }
}
