using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;


[CreateAssetMenu]
public partial class Data
{

    [SerializeField] public List<DataTable> _copy = new List<DataTable>();
    [SerializeField] public DataDict _dataDic;


    public string aaa;

    public Data()
    {
        _copy = DataTable;

    }


    public void SetData()
    {
        DataTable = _copy;

        _copy = DataTable;

        aaa = "11111;";
        DataList da = new DataList();

        da.DataListe = DataTable;

        for (int i = 0; i < 3; i++)
        {
            _dataDic.Add(i, da, i);

        }
    }

}





[Serializable]
public class DataList
{
    [SerializeField] List<DataTable> _dataList = new List<DataTable>();
    public List<DataTable> DataListe { get => _dataList; set { _dataList = value; } }
}

[Serializable]
public class DataDict : SerializableDictionary<int, DataList, int> { }