using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponcheck : MonoBehaviour
{
    [Header("�������")]
    [SerializeField] bool Counter = false;//ī���� ����
    [SerializeField] float Sttackdamage = 1f;//���� ������
    

    void Start()
    {
    }

    void Update()
    {
        
    }

    //public void Attackdamage()
    //{
    //    Player player = GetComponent <Player>();
    //    player.Weapontype();

    //    if ( == 0)
    //    {
    //        Debug.Log("����");
    //    }
    //    else if (Weaponlist.Count == 1)
    //    {
    //        Debug.Log("���Ÿ�");
    //    }
    //    else if(Weaponlist.Count == 2)
    //    {
    //        Debug.Log("��������");
    //    }
    //}

    //public void Counterdamage()
    //{
    //    if (Weaponlist.Count == 0)
    //    {
    //        Debug.Log("����ī����");
    //    }
    //    else if (Weaponlist.Count == 1)
    //    {
    //        Debug.Log("���Ÿ�ī����");
    //    }
    //    else if (Weaponlist.Count == 2)
    //    {
    //        Debug.Log("����ī����");
    //    }
    //}


}
