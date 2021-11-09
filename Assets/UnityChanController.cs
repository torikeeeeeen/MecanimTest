using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウスクリック時
        if(Input.GetMouseButtonDown(0))
        {
            // Animatorコンポーネントを取得してjumpTriggerをTrueにする
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        
    }
}
