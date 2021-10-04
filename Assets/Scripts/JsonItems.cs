using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ListItems
{
    public Items[] Items;
}

[Serializable]

public class Items
{
    public string AssetBundle;
    public int IdMurales;
    public string AssetBundleName;

}