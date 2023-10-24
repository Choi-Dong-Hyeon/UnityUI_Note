using System;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public partial class Data
{
    [SerializeField] public DataDict _dataDic;
    DataList _dataList;
    [SerializeField] Data _data;

    public void UpdateData()
    {
        for (int i = 0; i < 6; i++)
        {
            DataTable.Add(new DataTable());
            DataTable[i] = _data.DataTable[i];
        }

        _dataList.DataListe = _data.DataTable;

        for (int i = 0; i < 3; i++)
        {
            _dataDic.Add(i, _dataList, null);

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
public class DataDict : SerializableDictionary<int, DataList, string> { }