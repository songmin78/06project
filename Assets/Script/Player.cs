using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float horizontals;
    [SerializeField] float verticals;
    [SerializeField] bool Stopcheck = false;

    [Header("플레이어 정보")]
    [SerializeField] float playerspeed = 5f;

    Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {

    }

    void Update()
    {
        move();
        Anim();
    }

    public void move()
    {
        horizontals = Input.GetAxisRaw("Horizontal");//좌우
        verticals = Input.GetAxisRaw("Vertical");//상하

        if (horizontals != 0)
        {
            verticals = 0;
        }
        else if (verticals != 0)
        {
            horizontals = 0;
        }
        transform.position += new Vector3(horizontals * playerspeed, verticals * playerspeed, 0) * Time.deltaTime;

    }
    private void Anim()
    {
        animator.SetFloat("Horizontal", (int)horizontals);
        animator.SetFloat("Vertical", (int)verticals);

        if (horizontals != 0)
        {
            transform.localScale = new Vector3(horizontals, 1, 1);
        }
    }
}
