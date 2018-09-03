﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
namespace PSDUIImporter
{
    public enum ImageSource
    {
        Common,
        Custom,
        Global,

        /// <summary>
        /// 自定义图集
        /// </summary>
        CustomAtlas,
    }
}
