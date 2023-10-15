using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

 public class AddressableManager 
{

     public Dictionary<string, UnityEngine.Object> _resource = new Dictionary<string, UnityEngine.Object>();

     public void LoadAsync<T>(string key, Action<T> callback = null) where T : UnityEngine.Object
    {

        if (_resource.TryGetValue(key, out UnityEngine.Object resource))
        {
            callback.Invoke(resource as T);
            return;
        }

        var asyncOperation = Addressables.LoadAssetAsync<T>(key);

        asyncOperation.Completed += (op) =>
        {
            _resource.Add(key, op.Result);
            callback.Invoke(op.Result);
        };


    }




}
