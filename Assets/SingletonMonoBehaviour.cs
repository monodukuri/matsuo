// �Q�l����
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
                    Debug.LogError(t + " ���A�^�b�`���Ă���GameObject�͂���܂���");
                }
            }

            return instance;
        }
    }

    virtual protected void Awake()
    {
        // ���̃Q�[���I�u�W�F�N�g�ɃA�^�b�`����Ă��邩���ׂ�
        // �A�^�b�`����Ă���ꍇ�͔j������B
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


    //�@�}�E�X���N���b�N���ꂽ��
    public virtual void OnPointerClick(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X���N��������
    public virtual void OnPointerEnter(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X���o�čs������
    public virtual void OnPointerExit(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�������ꂽ��
    public virtual void OnPointerDown(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�������ꂽ��
    public virtual void OnPointerUp(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�h���b�O�Ώۂ�����������
    public virtual void OnInitializePotentialDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�h���b�O���J�n���ꂽ
    public virtual void OnBeginDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X���h���b�O����Ă���
    public virtual void OnDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�h���b�O���I��
    public virtual void OnEndDrag(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�I�u�W�F�N�g���h���b�v���ꂽ
    public virtual void OnDrop(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�}�E�X�z�C�[�����X�N���[�����Ă��鎞
    public virtual void OnScroll(UnityEngine.Object targetObject, PointerEventData eventData)
    {
    }

    //�@�I�u�W�F�N�g���I������Ă��鎞�i���t���[���j
    public virtual void OnUpdateSelected(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //�@�I�u�W�F�N�g���I������Ă��鎞�i�I�����ꂽ�u�ԁj
    public virtual void OnSelect(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //�@�I�u�W�F�N�g���I���������ꂽ
    public virtual void OnDeselect(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //�@�L�[���͂ɂ��ړ�
    public virtual void OnMove(UnityEngine.Object targetObject, AxisEventData eventData)
    {
    }

    //�@Submit�{�^���������ꂽ
    public virtual void OnSubmit(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }

    //�@Cancel�{�^���������ꂽ
    public virtual void OnCancel(UnityEngine.Object targetObject, BaseEventData eventData)
    {
    }
}