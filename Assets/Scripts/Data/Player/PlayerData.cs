﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public struct RoleInfoLite
    {
        public string roleId;
        public string roleName;
        public int roleLevel;
        public int serverId;
    }

    public struct RoleInfo
    {
        public string roleId;
        public string roleName;
        public int roleLevel;
        public int serverId;
    }

    public class PlayerBaseData : Data
    {
        public string accountId;
        public List<RoleInfoLite> roleInfoLiteList = new List<RoleInfoLite>();
        public RoleInfo roleInfo;
        public PlayerNotification notification = new PlayerNotification();
    }
}