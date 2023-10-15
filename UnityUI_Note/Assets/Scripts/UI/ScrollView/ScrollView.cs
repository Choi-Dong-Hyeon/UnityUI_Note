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

        //실제 프리팹 을 생성한다
        for(int i=0; i<100; i++)
        {
            Instantiate(_cellItem,_contents.transform);
        }

        //리슽트에 CellData의 인덱스번호를 매겨 생성한다.
        for (int i = 0; i < 100; i++)
        {
            _celldata.Add(new CellData(i));
        }

        //Contents산하에 생성한 프리팹 자식들을 전부 배열에 넣는다.
        Cell[] _cell = _contents.GetComponentsInChildren<Cell>();

        //각 Cell의 인덱스번째에 해당하는 스크립트에 존재하는 CellData를 채우기위해 여기서 채워준 리스트를 배열형태로 바꾸어 넘겨준다.
        for (int i = 0; i < _cell.Length; i++)
        {
            _cell[i].SetData(_celldata.ToArray());
        }

        //각 Cell의 인덱스번째에 해당하는 Celldata에 접근한다. 속성가공은 Cell스크립트에서 한다
        for(int i=0; i<_cell.Length; i++)
        {
            _cell[i].UpdateCellData(i);
        }
    }

    /*
     * Data를 List안에 전부 객체생성하여 인덱스번0~100까지 넣는다
     * 게임오브젝트(Cell)를 생성하여 Contents오브젝트에 부모에 위치시킨다.
     * MonoBehaviour가 붙어있는 Cell을 배열로 만든다
     * 각 Cell배열에 있는 CellData를 관리할 수 있다
     */

}
