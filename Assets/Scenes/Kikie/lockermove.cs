using UnityEngine;

public class MoveLockerOnTrigger : MonoBehaviour
{
    public Transform lockerToMove;       // Locker_B ที่ต้องการให้เลื่อน
    public Vector3 moveOffset;           // ทิศทางและระยะที่เลื่อน
    public float moveSpeed = 2f;

    private Vector3 targetPosition;
    private bool shouldMove = false;

    void Start()
    {
        if (lockerToMove != null)
        {
            targetPosition = lockerToMove.position + moveOffset;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldMove = true;
        }
    }

    void Update()
    {
        if (shouldMove && lockerToMove != null)
        {
            Debug.Log("Moving Locker...");
            lockerToMove.position = Vector3.MoveTowards(lockerToMove.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}


