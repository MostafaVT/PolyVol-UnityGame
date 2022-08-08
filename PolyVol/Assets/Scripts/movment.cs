using UnityEngine;

public class movment : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;

    //REFERENCES
    private CharacterController controller;

    private void start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void update()
    {
        Move();
    }

    private void Move()
    {
        float moveZ = Input.GetAxis("Vertical");

        moveDirection = new Vector3 (0, 0, moveZ);
        moveDirection *= walkSpeed;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
