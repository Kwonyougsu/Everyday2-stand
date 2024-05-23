using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    private static QuestManager instance;

    // [구현사항 2] 정적 프로퍼티 정의
    public static QuestManager Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
           
        }
    }

}
