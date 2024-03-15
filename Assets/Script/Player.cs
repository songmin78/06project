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
    [SerializeField] List<int> Weaponlist = new List<int>();//���� ����Ʈ

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
        Weapontype();
    }

    void Update()
    {
        move();
        WeaponChange();
        Anim();
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
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bow = Instantiate(arrow);
            Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
            //weaponcheck.Attackdamage();
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject bow = Instantiate(arrow);
            Weaponcheck weaponcheck = bow.GetComponent<Weaponcheck>();
            //weaponcheck.Counterdamage();
        }
    }

    private void WeaponChange()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {

        }
    }

    public void Weapontype()
    {
        Weaponlist.Add(0);//��������
        Weaponlist.Add(1);//���Ÿ�����
        Weaponlist.Add(2);//��������
    }
}
