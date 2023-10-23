using TMPro;
using UnityEngine;

public class CellData 
{
    public int Index { get; set; }

    public CellData(int index)
    {
        Index = index;
    }
}


public class Cell : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    CellData[] _celldata;
    public int _dataindex;

    //생성해놓은 수많은 CellData를 인덱스번호로 선택한다
    public void UpdateCellData(int dataindex)
    {
        _dataindex = dataindex;
        UpdateData(_celldata[_dataindex]);
    }

    //선택한 인덱스번째 CellData의 속성을 가공한다.
    public void UpdateData(CellData celldata)
    {
        _text.SetText(celldata.Index.ToString());
        gameObject.SetActive(true);
    }

    // 이미 채워진 CellData를 받아온다
    public void SetData(CellData[] celldata)
    {
        _celldata = celldata;
    }


}
