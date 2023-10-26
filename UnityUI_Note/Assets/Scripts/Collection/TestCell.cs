using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestCellData
{
    public int _Tid { get; set; }
    public Action _callBack;

    public TestCellData(int tid, Action call)
    {
        _Tid = tid;
        _callBack = call;
    }
}

public class TestCell : MonoBehaviour
{
    TestCellData[] _testCell;
    [SerializeField] TextMeshProUGUI _text;

    int dataIndex;

    public void UpdateCell(int tid)
    {
        dataIndex = tid;
        UpdateData(_testCell[dataIndex]);
    }


    public void UpdateData(TestCellData testCell)
    {
        _text.text = "Test";
        gameObject.SetActive(true);
    }


    public void SetData(TestCellData[] cell)
    {
        _testCell = cell;
    }

    public void OnClick()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            _testCell[dataIndex]._callBack?.Invoke();
        });
    }

    void Start()
    {
        OnClick();
    }

}
