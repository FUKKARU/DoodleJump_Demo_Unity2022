using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        MoveHorizontal();
    }

    private void MoveHorizontal()
    {
        int inputH = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            inputH -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            inputH += 1;
        }

        transform.position += Vector3.right * (inputH * speed * Time.deltaTime);
    }
}
