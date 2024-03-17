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


    [Header("�÷��̾� ����")]
    [SerializeField] float playerspeed = 5f;//�÷��̾ �̵��ϴ� �ӵ�
    [SerializeField] int Weapontype;//���� ����Ʈ

    [Header("�÷��̾��� �ɷ�ġ ����")]
    [SerializeField,Range(1,5)] float GameHP;//���ӳ� �÷��̾� ü��

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
        horizontals = Input.GetAxisRaw("Horizontal");//�¿�
        verticals = Input.GetAxisRaw("Vertical");//����

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
        if(Input.GetKeyDown(KeyCode.K))//�Ϲ� ����
        {
            if(Weapontype == 0)//���Ÿ�(Ȱ)�ϰ��
            {
                GameObject bow = Instantiate(arrow);
                Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
                weaponcheck.Attackdamage();

                Debug.Log("���Ÿ�");
            }
            else if(Weapontype == 1)//������ ���
            {
                Debug.Log("�ٰŸ�");
            }
            else if(Weapontype == 2)//���������� ���
            {
                Debug.Log("����");
            }
        }
        if(Input.GetKeyDown(KeyCode.L))//ī���� ����
        {
            if (Weapontype == 0)//���Ÿ�(Ȱ)�ϰ��
            {
                GameObject bow = Instantiate(arrow);
                Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
                weaponcheck.Counterdamage();

                Debug.Log("���Ÿ� ī����");
            }
            else if (Weapontype == 1)//������ ���
            {
                Debug.Log("����ī����");
            }
            else if (Weapontype == 2)//���������� ���
            {
                Debug.Log("����ī����");
            }
        }
    }

    private void WeaponChange()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if(Weapontype == 0)//���Ÿ� ���� ���� => 0
            {
                Weapontype = 1;
            }
            else if(Weapontype == 1)//�ٰŸ� ���� => 1
            {
                Weapontype = 2;
            }
            else if(Weapontype == 2)//���Ÿ� �������� => 2
            {
                Weapontype = 0;
            }
        }
    }
}
