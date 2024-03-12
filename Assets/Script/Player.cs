using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float horizontal;
    [SerializeField] float vertical;

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
        float horizontal = Input.GetAxisRaw("Horizontal");//좌우
        float vertical = Input.GetAxisRaw("Vertical");//상하

        transform.position += new Vector3(horizontal * playerspeed, vertical * playerspeed, 0) * Time.deltaTime;


    }

    private void Anim()
    {
        
        int fixedHorizontal = (int)horizontal;
        int fixedvertical = (int)vertical;
        animator.SetFloat("Horizontal", fixedHorizontal);
        animator.SetFloat("Vertical", fixedvertical);

    }
}
