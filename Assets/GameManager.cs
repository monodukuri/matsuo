// �Q�l����
// https://qiita.com/Teach/items/c146c7939db7acbd7eee

using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    MyClass x;  //�ux�v�Ƃ������O�̔������


    //�ϐ�a,b,c�̔������
    Vector3 a;
    Vector3 b;
    Vector3 c;

�@//�������I�u�W�F�N�g�����߂�

    //�@�}�E�X���N���b�N���ꂽ��
    public override void OnPointerClick(UnityEngine.Object targetObject, PointerEventData eventData)
    {
        if (b != null)
        {
            if (x != null)
            {
                x.transform.position = b;
            }
            
        }
        
        x = (MyClass)targetObject;  // �N���b�N���ꂽ�I�u�W�F�N�g�utargetObject�v���A���ux�v�ɓ����
    }

    void Update()
    {
        if (x != null)  // �������ux�v������ۂ���Ȃ����
        {

         //�ڕW�n�_�����߂�

            if (Input.GetMouseButtonUp(0))
            {
                //�ϐ�a�̓N���b�N�����ꏊ�̃X�N���[�����W
                a = Input.mousePosition;

                //�ϐ�b�͕ϐ�a���X�N���[�����W���烏�[���h���W�֕ϊ���������
                //�ϐ�b�̓N���b�N���ꂽ�ʒu�̃��[���h���W
                //b.z�͂����W��0�ɂ���B�͂��߂�z=-10
                b = Camera.main.ScreenToWorldPoint(a);
                b.z = 0f;
            }

            //�ϐ�c�͉摜�̌��ݒn�̃��[���h���W
            c = x.transform.position;

            //�摜��0.2f�̃X�s�[�h�ňړ�������
            //0.2f��ύX����Ɖ摜�̈ړ��X�s�[�h���ς��
            x.transform.position = Vector3.Lerp(c, b, 10.0f * Time.deltaTime);

        }



    }
}