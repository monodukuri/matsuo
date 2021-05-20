// 参考文献
// https://qiita.com/Teach/items/c146c7939db7acbd7eee

using UnityEngine;
using System;
using UnityEngine.EventSystems;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                Type t = typeof(T);

                instance = (T)FindObjectOfType(t);
                if (instance == null)
                {
                    Debug.LogError(t + " をアタッチしているGameObjectはありません");
                }
            }

            return instance;
        }
    }

    virtual protected void Awake()
    {
        // 他のゲームオブジェクトにアタッチされているか調べる
        // アタッチされている場合は破棄する。
        CheckInstance();
    }

    protected bool CheckInstance()
    {
        if (instance == null)
        {
            instance = this as T;
            return true;
        }
        else if (Instance == this)
        {
            return true;
        }
        Destroy(this);
        return false;
    }


    //　マウスがクリックされた時
    public virtual void OnPointerClick(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスが侵入した時
    public virtual void OnPointerEnter(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスが出て行った時
    public virtual void OnPointerExit(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスが押された時
    public virtual void OnPointerDown(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスが離された時
    public virtual void OnPointerUp(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスドラッグ対象が見つかった時
    public virtual void OnInitializePotentialDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスドラッグが開始された
    public virtual void OnBeginDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスがドラッグされている
    public virtual void OnDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスドラッグが終了
    public virtual void OnEndDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　オブジェクトがドロップされた
    public virtual void OnDrop(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　マウスホイールをスクロールしている時
    public virtual void OnScroll(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //　オブジェクトが選択されている時（毎フレーム）
    public virtual void OnUpdateSelected(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //　オブジェクトが選択されている時（選択された瞬間）
    public virtual void OnSelect(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //　オブジェクトが選択解除された
    public virtual void OnDeselect(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //　キー入力による移動
    public virtual void OnMove(UnityEngine.Object targetObject, AxisEventData eventData)
    {
    }

    //　Submitボタンが押された
    public virtual void OnSubmit(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //　Cancelボタンが押された
    public virtual void OnCancel(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }
}