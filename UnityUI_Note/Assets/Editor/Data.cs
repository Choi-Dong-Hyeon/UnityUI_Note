using System;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public partial class Data : ScriptableObject
{
    public List<DataTable> DataTable;


}


//[Serializable]
//public class DataList
//{
//    [SerializeField] List<DataTable> _dataList = new List<DataTable>();
//    public List<DataTable> DataListe { get => _dataList; }
//}

//[Serializable]
//public class DataDict : SerializableDictionary<int, DataList> { }
