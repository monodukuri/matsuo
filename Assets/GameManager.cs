// 参考文献
// https://qiita.com/Teach/items/c146c7939db7acbd7eee

using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    MyClass x;  //「x」という名前の箱を作る


    //変数a,b,cの箱を作る
    Vector3 a;
    Vector3 b;
    Vector3 c;

　//動かすオブジェクトを決める

    //　マウスがクリックされた時
    public override void OnPointerClick(UnityEngine.Object targetObject, PointerEventData eventData)
    {
        if (b != null)
        {
            if (x != null)
            {
                x.transform.position = b;
            }
            
        }
        
        x = (MyClass)targetObject;  // クリックされたオブジェクト「targetObject」を、箱「x」に入れる
    }

    void Update()
    {
        if (x != null)  // もし箱「x」が空っぽじゃなければ
        {

         //目標地点を決める

            if (Input.GetMouseButtonUp(0))
            {
                //変数aはクリックした場所のスクリーン座標
                a = Input.mousePosition;

                //変数bは変数aをスクリーン座標からワールド座標へ変換したもの
                //変数bはクリックされた位置のワールド座標
                //b.zはｚ座標を0にする。はじめはz=-10
                b = Camera.main.ScreenToWorldPoint(a);
                b.z = 0f;
            }

            //変数cは画像の現在地のワールド座標
            c = x.transform.position;

            //画像を0.2fのスピードで移動させる
            //0.2fを変更すると画像の移動スピードが変わる
            x.transform.position = Vector3.Lerp(c, b, 10.0f * Time.deltaTime);

        }



    }
}