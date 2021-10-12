using System;
using UnityEngine;

namespace JSONObjects
{
    [Serializable]
    public class Resource
    {
        public int id;
        public string name;
        public string asset_name;
        public AssetBundle asset_bundle;
        public string ui_hint;
    }
}

