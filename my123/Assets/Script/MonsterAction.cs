using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAction : MonoBehaviour
{

    #region 資料區
    private Rigidbody2D rig;
    private Transform left1, righet1;
    private float speed = 3.5f;
    private float leftx, rightx;
    private bool FaceLeft;


    #endregion

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        leftx =0;
        rightx =20;
        //Destroy(left1.gameObject);
        //Destroy(righet1.gameObject);
    }


    void Update()
    {
        Move();
    }

    private void Move()
    {
        //  如果臉向左
        if (FaceLeft)
        {

            rig.velocity = new Vector2(-speed,0);

            if (transform.position.x < leftx)
            {
                transform.localPosition = new Vector3(leftx, 0, 0);
                FaceLeft = false;
            }


        }
        else 
        {
            rig.velocity = new Vector2(speed,0);

                if (transform.position.x>rightx)
                {
                      transform.localPosition = new Vector3(rightx, 0, 0);
                FaceLeft = true;
                }
        }

    }







}
