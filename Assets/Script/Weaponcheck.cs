using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponcheck : MonoBehaviour
{
    [Header("�������")]
    [SerializeField] bool Counter = false;//ī���� ����
    [SerializeField] float AttackdamageMax = 1f;//���� ������
    

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void Attackdamage()
    {
        Player player = GetComponent<Player>();
    }

    public void Counterdamage()
    {

    }


}
