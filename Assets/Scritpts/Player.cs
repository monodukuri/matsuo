using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //インスペクターで設定する
    public float speed;

    //プライベート変数
    private Animator anim = null;
    private Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントのインスタンスを捕まえる
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //キー入力されたら行動する
        float horizontalKey = Input.GetAxis("Horizontal");
        float Verticalkey = Input.GetAxis("Vertical");

        float xSpeed = 0.0f;

        if (horizontalKey > 0)//右
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = speed;
        }
        else if (horizontalKey < 0)//左
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = -speed;
        }
        else if (Verticalkey > 0)
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
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
