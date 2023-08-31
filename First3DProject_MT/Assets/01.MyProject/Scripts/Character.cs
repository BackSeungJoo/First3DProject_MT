using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Animator animator;

    public float moveSpeed = 1.0f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        // 수평 방향 입력을 받습니다.
        float horizontalInput = Input.GetAxis("Horizontal");
        // 수직 방향 입력을 받습니다.
        float verticalInput = Input.GetAxis("Vertical");

        // 입력을 기반으로 움직임 벡터를 계산합니다.
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.fixedDeltaTime;

        if (movement == Vector3.zero)
        {
            Idle();
        }

        else
        {
            Move();

            // 캐릭터의 현재 위치에 움직임 벡터를 더해 새로운 위치를 계산합니다.
            transform.Translate(movement);
        }


        
    }

    public void Idle()
    {
        animator.SetBool("Walk", false);
        animator.SetBool("Attack", false);
    }

    public void Move()
    {
        animator.SetBool("Walk", true);
        animator.SetBool("Attack", false);
    }
}
