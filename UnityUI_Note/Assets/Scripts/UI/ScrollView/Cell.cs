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

    //�����س��� ������ CellData�� �ε�����ȣ�� �����Ѵ�
    public void UpdateCellData(int dataindex)
    {
        _dataindex = dataindex;
        UpdateData(_celldata[_dataindex]);
    }

    //������ �ε�����° CellData�� �Ӽ��� �����Ѵ�.
    public void UpdateData(CellData celldata)
    {
        _text.SetText(celldata.Index.ToString());
        gameObject.SetActive(true);
    }

    // �̹� ä���� CellData�� �޾ƿ´�
    public void SetData(CellData[] celldata)
    {
        _celldata = celldata;
    }


}
