using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponcheck : MonoBehaviour
{
    [Header("무기관리")]
    [SerializeField] bool Counter = false;//카운터 여부
    [SerializeField] float Sttackdamage = 1f;//무기 데미지
    

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
    //        Debug.Log("근접");
    //    }
    //    else if (Weaponlist.Count == 1)
    //    {
    //        Debug.Log("원거리");
    //    }
    //    else if(Weaponlist.Count == 2)
    //    {
    //        Debug.Log("마법공격");
    //    }
    //}

    //public void Counterdamage()
    //{
    //    if (Weaponlist.Count == 0)
    //    {
    //        Debug.Log("근접카운터");
    //    }
    //    else if (Weaponlist.Count == 1)
    //    {
    //        Debug.Log("원거리카운터");
    //    }
    //    else if (Weaponlist.Count == 2)
    //    {
    //        Debug.Log("마법카운터");
    //    }
    //}


}
