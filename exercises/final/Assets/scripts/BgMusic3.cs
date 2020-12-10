using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static BgMusic3 instance = null;
    public static BgMusic3 Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
