using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers _instance;

    public static Managers Instance { get { Init(); return _instance; } }


    AddressableManager _addressable = new AddressableManager();
    public AddressableManager ExAddressable { get { return Instance._addressable; } }


    static void Init()
    {
        if (_instance == null)
        {

            GameObject go = new GameObject { name = "@Managers" };
            _instance = go.AddComponent<Managers>();
            DontDestroyOnLoad(go);
        }
    }


}
