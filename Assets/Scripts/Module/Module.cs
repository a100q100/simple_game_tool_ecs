﻿using UnityEngine;
using System.Collections.Generic;
using System;

namespace Module{
    public abstract class Module
    {
        protected List<int> _objectIdList = new List<int>();

        public abstract bool IsBelong(List<Data.Data> dataList);

        public virtual void OnAdd(int objId) { }
        public virtual void OnRemove(int objId) { }

        public void OnIdListChanged()
        {
            _objectIdList.Clear();

            var objectIdList = ObjectData.GetModuleAddedObjectList(GetType());
            if (objectIdList != null)
            {
                _objectIdList.AddRange(objectIdList);
            }
        }

        bool _enabled;
        public bool enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                if (_enabled == value)
                {
                    return;
                }

                if (_enabled)
                {
                    OnEnable();
                }
                else
                {
                    OnDisable();
                }
            }
        }
        
        protected virtual void OnEnable() { }
        protected virtual void OnDisable() { }
    }
}