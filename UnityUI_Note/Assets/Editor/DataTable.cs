using System;
using System.Collections.Generic;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;


[Serializable]
public partial class DataTable
{

    [SerializeField] int index;
    [JsonProperty] public int Index { get { return index; } set { index = value; } }

    [SerializeField] string name;
    [JsonProperty] public string Name { get { return name; } set { name = value; } }



    public DataTable Clone()
    {
        var data=new DataTable();

        data.index = index;
        data.name = name;

        return data;
    }

}


