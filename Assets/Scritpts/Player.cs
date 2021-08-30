using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�C���X�y�N�^�[�Őݒ肷��
    public float speed; //���x
    public float jumpSpeed; //�W�����v���x
    public float gravity; //�d��
    public GroundCheck ground; //�ڒn����

    //�v���C�x�[�g�ϐ�
    private Animator anim = null;
    private Rigidbody2D rb = null;
    private bool isGround = false;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̃C���X�^���X��߂܂���
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�ڒn����𓾂�
        isGround = ground.IsGround();

        //�L�[���͂��ꂽ��s������
        float horizontalKey = Input.GetAxis("Horizontal");
        float verticalKey = Input.GetAxis("Vertical");

        float xSpeed = 0.0f;
        float ySpeed = -gravity;

        if (isGround)
        {
            if (verticalKey > 0)
            {
                ySpeed = jumpSpeed;
            }
        }

        if (horizontalKey > 0)//�E
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = speed;
        }
        else if (horizontalKey < 0)//��
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = -speed;
        }
        else if (verticalKey > 0)
        {
            rb.AddForce(new Vector3(0, 10.0f, 0)); // transform.position = new Vector3(1, 2, 1);
            anim.SetBool("jump", true);
            xSpeed = speed;
        }

        else
        {
            anim.SetBool("run", false);
            xSpeed = 0.0f;
        }
        //�C�����K�vanim.SetBool("jump", isJump);
        //anim.SetBool("ground", isGround);
        rb.velocity = new Vector2(xSpeed, ySpeed);
    }
}