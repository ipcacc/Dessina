using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int gold;

    // Start is called before the first frame update
    void Start()
    {
        if (gold > 50) ;
        {
            Debug.Log("물건을 구매하셨습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("현재 골드:" + gold);
        }
    }
}
