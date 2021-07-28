using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{

    
    
    [SerializeField]
    float speed = 0;
    [SerializeField]
    float jumpPower = 30;
    [SerializeField]
    Transform[] groundCheckTransforms = null;

    bool isActive = false;
    bool jump = false;
    bool isGrounded = false;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigidBody2D;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody2D = GetComponent<Rigidbody2D>();

        isActive = true;
    }

    void Update()
    {
        GetInput();
        UpdateAnimation();
    }

    void FixedUpdate()
    {
        Move();
    }

    void GetInput()
    {
        if (!isActive)
        {
            return;
        }

        jump = Input.GetButtonDown("Jump");
    }

    void Move()
    {
        if (!isActive)
        {
            return;
        }

        //�ڒn����
        GroundCheck();

        //�W�����v�̑��x�v�Z
        if (jump && isGrounded)
        {
            rigidBody2D.velocity = Vector3.up * jumpPower;
        }

        //���ۂ̈ړ�����
        rigidBody2D.velocity = new Vector2(speed, rigidBody2D.velocity.y);
    }

    void GroundCheck()
    {
        Collider2D[] groundCheckCollider = new Collider2D[groundCheckTransforms.Length];

        //�ڒn����I�u�W�F�N�g�������ɏd�Ȃ��Ă��邩�ǂ������`�F�b�N
        for (int i = 0; i < groundCheckTransforms.Length; i++)
        {
            groundCheckCollider[i] = Physics2D.OverlapPoint(groundCheckTransforms[i].position);

            //�ڒn����I�u�W�F�N�g�̂����A1�ł������ɏd�Ȃ��Ă�����ڒn���Ă�����̂Ƃ��ďI��
            if (groundCheckCollider[i] != null)
            {
                isGrounded = true;
                return;
            }
        }

        //�����܂ł����Ƃ������Ƃ͉����d�Ȃ��Ă��Ȃ��Ƃ������ƂȂ̂ŁA�ڒn���Ă��Ȃ��Ɣ��f����
        isGrounded = false;
    }

    void UpdateAnimation()
    {
        animator.SetBool("Grounded", isGrounded);
    }

}