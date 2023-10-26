using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUI_Scroll : MonoBehaviour
{



    [SerializeField] TestAction _testAction;
    void Start()
    {

        List<TestCellData> _testCellData = new List<TestCellData>();

        for (int i = 0; i < 1; i++)
        {
            _testCellData.Add(new TestCellData(i, _testAction.Show));
        }

        TestCell[] _testCellArray = GetComponentsInChildren<TestCell>();

        for (int i = 0; i < _testCellArray.Length; i++)
        {
            _testCellArray[i].SetData(_testCellData.ToArray());
        }
     
        for (int i = 0; i < _testCellArray.Length; i++)
        {
            _testCellArray[i].UpdateCell(i);
        }



    }

}
