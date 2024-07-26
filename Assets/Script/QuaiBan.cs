using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaiBan : MonoBehaviour
{
    // Start is called before the first frame update
    private int direction = 1;
    private float moveSpeed = 3;

    void Update()
    {
        Vector3 movement = new Vector3(direction, 0f, 0f); // Đổi thành x: direction
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        if (transform.position.x >= 5f || transform.position.x <= -5f) // Đổi thành khoảng cách xa nhất bạn muốn
        {
            direction *= -1;
        }
    }
}
