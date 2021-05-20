// 参考文献
// https://gametukurikata.com/basic/mouseevent
// https://qiita.com/Teach/items/c146c7939db7acbd7eee

using UnityEngine;
using UnityEngine.EventSystems;

public class MyClass : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler
, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler
, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler
{
    private GameManager manager;
    // ↑ 「GameManager」を部長のクラス名に書き換える

    void Start()
    {
        manager = GameManager.Instance;
        // ↑ 「GameManager」を部長のクラス名に書き換える
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        this.manager.OnPointerClick(this, eventData);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.manager.OnPointerEnter(this, eventData);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.manager.OnPointerExit(this, eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        this.manager.OnPointerDown(this, eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.manager.OnPointerUp(this, eventData);
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        this.manager.OnInitializePotentialDrag(this, eventData);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        this.manager.OnBeginDrag(this, eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.manager.OnDrag(this, eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.manager.OnEndDrag(this, eventData);
    }

    public void OnDrop(PointerEventData eventData)
    {
        this.manager.OnDrop(this, eventData);
    }

    public void OnScroll(PointerEventData eventData)
    {
        this.manager.OnScroll(this, eventData);
    }

    public void OnUpdateSelected(BaseEventData eventData)
    {
        this.manager.OnUpdateSelected(this, eventData);
    }

    public void OnSelect(BaseEventData eventData)
    {
        this.manager.OnSelect(this, eventData);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        this.manager.OnDeselect(this, eventData);
    }

    public void OnMove(AxisEventData eventData)
    {
        this.manager.OnMove(this, eventData);
    }

    public void OnSubmit(BaseEventData eventData)
    {
        this.manager.OnSubmit(this, eventData);
    }

    public void OnCancel(BaseEventData eventData)
    {
        this.manager.OnCancel(this, eventData);
    }
}