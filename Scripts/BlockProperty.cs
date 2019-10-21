using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Doozy.Engine.UI;

public enum ClearDirection
{
    up = 0,
    left,
    right,
    down
}

public class SpecialType {
    public bool canBomb;//是否炸弹消除
    public int bombNum; //炸几次
    public bool sameColor;//同色消除（邻边格子同色消除即可消除）
}

public class SpandType
{
    public int spandDirection;
    public int spandNum;//延展出去要增加的层数
}

public class SpecialBlock { 

}

public class BlockProperty : MonoBehaviour
{
    public bool isEmpty;
    public bool canClear;           // 是否能消除
    public bool specialClear;       // 是否需要特殊消除
    public SpecialType specialType; // 特殊消除类型
    public int clearNum;            // 需要消除几次（普通消除）
    public ClearDirection clearDirection; //掉落方向
    public bool canSpand;           //是否会延展
    public SpandType spandType;
    public bool isSpecialBlock;     //是否是特殊道具



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
