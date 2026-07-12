using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    void Start()
    {
        Invoke("Dest", 0.5f);//生成されてから0.5秒後にDest()を呼び出す
    }

    public void Dest()
    {
        Destroy(this.gameObject);
    }
}
