using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public Transform platform;
    public Transform startPoint;
    public Transform endPoint;

    private int currentDirection = 1;

    int direction = 1;

    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = CurrentMovementTarget();
        Vector2 currentPosition = platform.position;
        Vector2 movement = (target - currentPosition).normalized * speed * Time.deltaTime;

        if (movement.magnitude >= Vector2.Distance(currentPosition, target))
        {
            platform.position = target;
            direction *= -1;
        }
        else
        {
            platform.position += (Vector3)movement;
        }
    }
    private void OnDrawGizmos()
    {
        if (platform != null && startPoint != null && endPoint != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(platform.transform.position, startPoint.position);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(platform.transform.position, endPoint.position);
        }
    }
    Vector2 CurrentMovementTarget()
    {
        if (direction != currentDirection)
        {
            currentDirection = direction;
            float targetScaleX = (direction == 1) ? 1f : -1f;
            platform.localScale = new Vector3(targetScaleX, 1f, 1f);
        }

        return (direction == 1) ? endPoint.position : startPoint.position;
    }
}
