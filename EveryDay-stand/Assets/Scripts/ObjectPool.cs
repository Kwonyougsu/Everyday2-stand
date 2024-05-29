using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    public int poolSize = 300;

    void Start()
    {
        
    }

    //public GameObject Get()
    //{
    //    // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
    //}
    

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
    }
}