﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;

namespace Module
{
    public class ActorMove : UpdateModule
    {
        protected override void InitRequiredDataType()
        {
            _requiredDataTypeList.Add(typeof(ActorData));
            _requiredDataTypeList.Add(typeof(Physics2DData));
            _requiredDataTypeList.Add(typeof(SpeedData));
            _requiredDataTypeList.Add(typeof(ResourceStateData));
        }

        public override bool IsUpdateRequired(Data.Data data)
        {
            return data.GetType() == typeof(SpeedData);
        }

        public override void Refresh(ObjectData objData)
        {
            var resourceStateData = objData.GetData<ResourceStateData>();
            if (!resourceStateData.isInstantiated)
            {
                return;
            }

            var speedData = objData.GetData<SpeedData>();
            if (speedData.speed == 0)
            {
                Stop(objData.ObjectId);
                return;
            }

            var actorData = objData.GetData<ActorData>();
            if (!ActorController.CanMove(actorData.currentState))
            {
                return;
            }

            if ((actorData.currentState & (int)ActorStateType.Move) == 0)
            {
                speedData.speed = 0;
                return;
            }

            var physics2DData = objData.GetData<Physics2DData>();
            var speed = speedData.speed;
            speedData.speed = speed - physics2DData.friction;
            if (speedData.speed <= 0)
            {
                speedData.speed = 0;
                physics2DData.force.x = 0;

                ActorAnimator.Stop(objData, ActorStateType.Move);

                actorData.currentState &= ~(int)ActorStateType.Move;
                objData.SetDirty(actorData);
            }
            else
            {
                physics2DData.force.x = speed;

                objData.SetDirty(physics2DData);
            }
        }
    }
}