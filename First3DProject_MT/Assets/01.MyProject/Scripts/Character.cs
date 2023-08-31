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
        // ���� ���� �Է��� �޽��ϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        // ���� ���� �Է��� �޽��ϴ�.
        float verticalInput = Input.GetAxis("Vertical");

        // �Է��� ������� ������ ���͸� ����մϴ�.
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.fixedDeltaTime;

        if (movement == Vector3.zero)
        {
            Idle();
        }

        else
        {
            Move();

            // ĳ������ ���� ��ġ�� ������ ���͸� ���� ���ο� ��ġ�� ����մϴ�.
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
