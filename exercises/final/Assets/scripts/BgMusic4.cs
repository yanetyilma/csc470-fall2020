using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private static BgMusic4 instance = null;
    public static BgMusic4 Instance
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
