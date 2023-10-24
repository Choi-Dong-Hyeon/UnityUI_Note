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
        DataTable data = new DataTable();

        data.Index = this.Index;
        data.Name = this.Name;

        return data;
    }

}


