using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject arrow;
    [SerializeField] float horizontals;
    [SerializeField] float verticals;
    [SerializeField] bool Stopcheck = false;
    private float MaxHP;


    [Header("플레이어 정보")]
    [SerializeField] float playerspeed = 5f;//플레이어가 이동하는 속도
    [SerializeField] int Weapontype;//무기 리스트

    [Header("플레이어의 능력치 설정")]
    [SerializeField,Range(1,5)] float GameHP;//게임내 플레이어 체력

    Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        MaxHP = GameHP;
    }

    void Start()
    {
        Weapontype = 0;
    }

    void Update()
    {
        move();
        Anim();
        WeaponChange();
        bowattack();
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

    public void bowattack()
    {
        if(Input.GetKeyDown(KeyCode.K))//일반 공격
        {
            if(Weapontype == 0)//원거리(활)일경우
            {
                GameObject bow = Instantiate(arrow);
                Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
                weaponcheck.Attackdamage();

                Debug.Log("원거리");
            }
            else if(Weapontype == 1)//근접일 경우
            {
                Debug.Log("근거리");
            }
            else if(Weapontype == 2)//마법공격일 경우
            {
                Debug.Log("마법");
            }
        }
        if(Input.GetKeyDown(KeyCode.L))//카운터 공격
        {
            if (Weapontype == 0)//원거리(활)일경우
            {
                GameObject bow = Instantiate(arrow);
                Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
                weaponcheck.Counterdamage();

                Debug.Log("원거리 카운터");
            }
            else if (Weapontype == 1)//근접일 경우
            {
                Debug.Log("근접카운터");
            }
            else if (Weapontype == 2)//마법공격일 경우
            {
                Debug.Log("마법카운터");
            }
        }
    }

    private void WeaponChange()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if(Weapontype == 0)//원거리 물리 무기 => 0
            {
                Weapontype = 1;
            }
            else if(Weapontype == 1)//근거리 무기 => 1
            {
                Weapontype = 2;
            }
            else if(Weapontype == 2)//원거리 마법무기 => 2
            {
                Weapontype = 0;
            }
        }
    }
}
