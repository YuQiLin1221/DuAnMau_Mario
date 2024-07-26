using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaiDuoi : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float minDistance = 3f;
    public string playerTag = "player";
    private Transform player;
    private Animator animator;
    private bool facingRight = true;

    void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (player == null)
            return;

        Vector3 direction = (player.position - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= minDistance)
        {
            transform.position += direction * moveSpeed * Time.deltaTime;
            
        }

 
        if (direction.x < 0 && facingRight)
        {
            Flip();
        }
        else if (direction.x > 0 && !facingRight)
        {
            Flip();
        }
        
    }

    private void Flip()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    
}
