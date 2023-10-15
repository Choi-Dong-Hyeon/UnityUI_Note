using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Test : MonoBehaviour
{

    void Start()
    {
   

        Addressables.LoadAssetAsync<GameObject>("Cube").Completed += (obj) =>
        {
            Addressables.InstantiateAsync(obj.Result.name);

        };


    }


}
