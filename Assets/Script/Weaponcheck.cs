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

    private void attackcheck()
    {
        
    }

    public void Attackdamage(int _weaponType)
    {
        if(_weaponType == 0)//���Ÿ� ����
        {
            Debug.Log("���Ÿ�");
        }
        else if(_weaponType == 1)//���� ����
        {
            Debug.Log("�ٰŸ�");
        }
        else if(_weaponType == 2)//��������
        {
            Debug.Log("����");
        }
    }

    public void Counterdamage(int _weaponType)
    {
        if (_weaponType == 0)//���Ÿ� ����
        {
            Debug.Log("���Ÿ� ī����");
        }
        else if (_weaponType == 1)//���� ����
        {
            Debug.Log("�ٰŸ� ī����");
        }
        else if (_weaponType == 2)//��������
        {
            Debug.Log("���� ī����");
        }
    }


}
