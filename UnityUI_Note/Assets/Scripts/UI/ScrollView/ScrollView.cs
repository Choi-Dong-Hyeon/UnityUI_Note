using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollView : MonoBehaviour
{
    [SerializeField] ScrollRect _scrollRect;
    [SerializeField] GameObject _contents;
    [SerializeField] GameObject _cellItem;

    List<CellData> _celldata = new List<CellData>();
    // [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] [] <- CellData
   

    void Start()
    {

        //���� ������ �� �����Ѵ�
        for(int i=0; i<100; i++)
        {
            Instantiate(_cellItem,_contents.transform);
        }

        //����Ʈ�� CellData�� �ε�����ȣ�� �Ű� �����Ѵ�.
        for (int i = 0; i < 100; i++)
        {
            _celldata.Add(new CellData(i));
        }

        //Contents���Ͽ� ������ ������ �ڽĵ��� ���� �迭�� �ִ´�.
        Cell[] _cell = _contents.GetComponentsInChildren<Cell>();

        //�� Cell�� �ε�����°�� �ش��ϴ� ��ũ��Ʈ�� �����ϴ� CellData�� ä������� ���⼭ ä���� ����Ʈ�� �迭���·� �ٲپ� �Ѱ��ش�.
        for (int i = 0; i < _cell.Length; i++)
        {
            _cell[i].SetData(_celldata.ToArray());
        }

        //�� Cell�� �ε�����°�� �ش��ϴ� Celldata�� �����Ѵ�. �Ӽ������� Cell��ũ��Ʈ���� �Ѵ�
        for(int i=0; i<_cell.Length; i++)
        {
            _cell[i].UpdateCellData(i);
        }
    }

    /*
     * Data�� List�ȿ� ���� ��ü�����Ͽ� �ε�����0~100���� �ִ´�
     * ���ӿ�����Ʈ(Cell)�� �����Ͽ� Contents������Ʈ�� �θ� ��ġ��Ų��.
     * MonoBehaviour�� �پ��ִ� Cell�� �迭�� �����
     * �� Cell�迭�� �ִ� CellData�� ������ �� �ִ�
     */

}
