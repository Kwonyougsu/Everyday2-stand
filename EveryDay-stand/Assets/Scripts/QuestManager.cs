using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
//              instance = FindObjectOfType(typeof(QuestManager));

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<QuestManager>();
                }
            }
            return instance;
        }
    }

    // [구현사항 3] 인스턴스 검사 로직
    private void Awake()
    {
        if (instance != null) Destroy(gameObject);
        instance = this;
    }
}
